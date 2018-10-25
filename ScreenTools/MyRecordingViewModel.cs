﻿using Captura;
using Captura.Audio;
using Captura.Models;
using Captura.ViewModels;
using Screna;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;


namespace ScreenTools
{
    class MyRecordingViewModel : ViewModelBase
    {

        IRecorder _recorder;
        IVideoSourcePicker VideoSourcePicker;
        LanguageManager LanguageManager = LanguageManager.Instance;
        ISystemTray SystemTray = null;
        string _currentFileName;
        IPreviewWindow _previewWindow;
        WebcamOverlay _webcamOverlay;
        AudioSource _audioSource;
        IRegionProvider RegionProvider;
        FullScreenSourceProvider FullScreenProvider;
        ScreenSourceProvider ScreenSourceProvider;
        WindowSourceProvider WindowSourceProvider;
        RegionSourceProvider RegionSourceProvider;
        NoVideoSourceProvider NoVideoSourceProvider;
        DeskDuplSourceProvider DeskDuplSourceProvider;
        IEnumerable<IImageWriterItem> ImageWriters;
        FFmpegWriterProvider FFmpegWriterProvider;
        GifWriterProvider GifWriterProvider;
        StreamingWriterProvider StreamingWriterProvider;

        SharpAviWriterProvider SharpAviWriterProvider = new SharpAviWriterProvider();

        DiscardWriterProvider DiscardWriterProvider = new DiscardWriterProvider();

        VideoViewModel _videoViewModel;

        public MyRecordingViewModel(AudioSource audioSource) : base(new Settings(), LanguageManager.Instance)
        {
            _audioSource = audioSource;
            _currentFileName = Settings.GetFileName(".avi", "2018-10-24.avi");
            VideoSourcePicker = new VideoSourcePicker();
            //_audioSource = new BassAudioSource(Settings.Audio);
            RegionProvider = new RegionSelector(VideoSourcePicker);
            _webcamOverlay = new WebcamOverlay(new WebCamProvider(), Settings);
            _previewWindow = new PreviewWindowService();
            FullScreenProvider = new FullScreenSourceProvider(LanguageManager, new FullScreenItem());
            ScreenSourceProvider = new ScreenSourceProvider(LanguageManager, VideoSourcePicker);
            WindowSourceProvider = new WindowSourceProvider(LanguageManager, VideoSourcePicker, new RegionSelector(VideoSourcePicker));
            RegionSourceProvider = new RegionSourceProvider(LanguageManager, RegionProvider);
            NoVideoSourceProvider = new NoVideoSourceProvider(LanguageManager);
            DeskDuplSourceProvider = new DeskDuplSourceProvider(LanguageManager, VideoSourcePicker);
            ImageWriters = new IImageWriterItem[4] { new EditorWriter(), new ClipboardWriter(SystemTray, LanguageManager), null, null };
            SharpAviWriterProvider = new SharpAviWriterProvider();
            DiscardWriterProvider = new DiscardWriterProvider();
            FFmpegWriterProvider = new FFmpegWriterProvider(new FFmpegSettings());
            GifWriterProvider = new GifWriterProvider(LanguageManager, new GifItem(new GifSettings()));
            StreamingWriterProvider = new StreamingWriterProvider();
            _videoViewModel = new VideoViewModel(
                RegionProvider,
                ImageWriters,
                Settings,
                LanguageManager,
                FullScreenProvider,
                ScreenSourceProvider,
                WindowSourceProvider,
                RegionSourceProvider,
                NoVideoSourceProvider,
                DeskDuplSourceProvider,
                FFmpegWriterProvider,
                SharpAviWriterProvider,
                GifWriterProvider,
                StreamingWriterProvider,
                DiscardWriterProvider
                );
        }
        public CustomOverlaysViewModel CustomOverlays { get; }
        public CustomImageOverlaysViewModel CustomImageOverlays { get; }

        public void StartRecoding()
        {

            //图像
            IImageProvider imgProvider;

            try
            {
                imgProvider = GetImageProvider();
            }
            catch (Exception e)
            {
                ServiceProvider.MessageProvider.ShowException(e, e.Message);

                return;
            }
            //声音
            IAudioProvider audioProvider = null;

            try
            {
                Settings.Audio.Enabled = true;
                if (Settings.Audio.Enabled && !Settings.Audio.SeparateFilePerSource)
                {
                    audioProvider = _audioSource.GetMixedAudioProvider();
                }
            }
            catch (Exception e)
            {
                ServiceProvider.MessageProvider.ShowException(e, e.Message);

                imgProvider?.Dispose();

                return;
            }
            //视频写入
            IVideoFileWriter videoEncoder;

            try
            {
                videoEncoder = GetVideoFileWriterWithPreview(imgProvider, audioProvider);
            }
            catch (Exception e)
            {
                ServiceProvider.MessageProvider.ShowException(e, e.Message);

                imgProvider?.Dispose();
                audioProvider?.Dispose();

                return;
            }

            _recorder = new Recorder(videoEncoder, imgProvider, Settings.Video.FrameRate, audioProvider);
            _recorder.Start();
        }

        public async Task StopAudioRecording()
        {
            // Reference Recorder as it will be set to null
            var rec = _recorder;
            var task = Task.Run(() => rec.Dispose());

            _recorder = null;

            try
            {
                await task;
            }
            catch (Exception e)
            {
                ServiceProvider.MessageProvider.ShowException(e, "Error occurred when stopping recording.\nThis might sometimes occur if you stop recording just as soon as you start it.");

                return;
            }
        }


        IImageProvider GetImageProvider()
        {
            Func<Point, Point> transform = P => P;

            var imageProvider = _videoViewModel.SelectedVideoSourceKind?.Source?.GetImageProvider(Settings.IncludeCursor, out transform);

            if (imageProvider == null)
                return null;

            var overlays = new List<IOverlay>
            {
                new CensorOverlay(Settings.Censored)
            };

            if (!Settings.WebcamOverlay.SeparateFile)
            {
                overlays.Add(_webcamOverlay);
            }

            overlays.Add(new MousePointerOverlay(Settings.MousePointerOverlay));

            

            // Custom Image Overlays

            return new OverlayedImageProvider(imageProvider, transform, overlays.ToArray());
        }

        IVideoFileWriter GetVideoFileWriterWithPreview(IImageProvider ImgProvider, IAudioProvider AudioProvider)
        {
            if (_videoViewModel.SelectedVideoSourceKind is NoVideoSourceProvider)
                return null;

            _previewWindow.Init(ImgProvider.Width, ImgProvider.Height);

            return new WithPreviewWriter(GetVideoFileWriter(ImgProvider, AudioProvider), _previewWindow);
        }

        IVideoFileWriter GetVideoFileWriter(IImageProvider ImgProvider, IAudioProvider AudioProvider, string FileName = null)
        {
            if (_videoViewModel.SelectedVideoSourceKind is NoVideoSourceProvider)
                return null;

            _videoViewModel.SelectedVideoWriterKind = SharpAviWriterProvider;
            return (SharpAviWriterProvider.Last()).GetVideoFileWriter(new VideoWriterArgs
            {
                FileName = FileName ?? _currentFileName,
                FrameRate = Settings.Video.FrameRate,
                VideoQuality = Settings.Video.Quality,
                ImageProvider = ImgProvider,
                AudioQuality = Settings.Audio.Quality,
                AudioProvider = AudioProvider
            });
        }
    }
}
