﻿
using CefSharp.WinForms;
using System.Windows.Forms;

namespace ScreenTools
{
    partial class MainWindow
    {
        
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.语言设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平台总览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产线一览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产线监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视频会议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检测内核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.截屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.截屏时隐藏当前窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.audioRecord = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.screenShot = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1109, 560);
            this.webBrowser1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.语言设置ToolStripMenuItem,
            this.平台总览ToolStripMenuItem,
            this.产线一览ToolStripMenuItem,
            this.产线监控ToolStripMenuItem,
            this.视频会议ToolStripMenuItem,
            this.检测内核ToolStripMenuItem,
            this.截屏ToolStripMenuItem,
            this.录屏ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 26);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 语言设置ToolStripMenuItem
            // 
            this.语言设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.EnglishToolStripMenuItem});
            this.语言设置ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.语言设置ToolStripMenuItem.MergeIndex = 0;
            this.语言设置ToolStripMenuItem.Name = "语言设置ToolStripMenuItem";
            this.语言设置ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(3);
            this.语言设置ToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.语言设置ToolStripMenuItem.Text = "语言设置";
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.中文ToolStripMenuItem.Text = "中文";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.中文ToolStripMenuItem_Click);
            // 
            // EnglishToolStripMenuItem
            // 
            this.EnglishToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem";
            this.EnglishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.EnglishToolStripMenuItem.Text = "English";
            this.EnglishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // 平台总览ToolStripMenuItem
            // 
            this.平台总览ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.平台总览ToolStripMenuItem.Name = "平台总览ToolStripMenuItem";
            this.平台总览ToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.平台总览ToolStripMenuItem.Text = "平台总览";
            this.平台总览ToolStripMenuItem.Click += new System.EventHandler(this.平台总览ToolStripMenuItem_Click);
            // 
            // 产线一览ToolStripMenuItem
            // 
            this.产线一览ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.产线一览ToolStripMenuItem.Name = "产线一览ToolStripMenuItem";
            this.产线一览ToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.产线一览ToolStripMenuItem.Text = "产线一览";
            this.产线一览ToolStripMenuItem.Click += new System.EventHandler(this.产线一览ToolStripMenuItem_Click);
            // 
            // 产线监控ToolStripMenuItem
            // 
            this.产线监控ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.产线监控ToolStripMenuItem.Name = "产线监控ToolStripMenuItem";
            this.产线监控ToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.产线监控ToolStripMenuItem.Text = "产线监控";
            // 
            // 视频会议ToolStripMenuItem
            // 
            this.视频会议ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.视频会议ToolStripMenuItem.Name = "视频会议ToolStripMenuItem";
            this.视频会议ToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.视频会议ToolStripMenuItem.Text = "视频会议";
            // 
            // 检测内核ToolStripMenuItem
            // 
            this.检测内核ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.检测内核ToolStripMenuItem.Name = "检测内核ToolStripMenuItem";
            this.检测内核ToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.检测内核ToolStripMenuItem.Text = "检测内核";
            this.检测内核ToolStripMenuItem.Click += new System.EventHandler(this.检测内核ToolStripMenuItem_Click);
            // 
            // 截屏ToolStripMenuItem
            // 
            this.截屏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.截屏时隐藏当前窗口ToolStripMenuItem});
            this.截屏ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.截屏ToolStripMenuItem.Name = "截屏ToolStripMenuItem";
            this.截屏ToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.截屏ToolStripMenuItem.Text = "截屏";
            // 
            // 截屏时隐藏当前窗口ToolStripMenuItem
            // 
            this.截屏时隐藏当前窗口ToolStripMenuItem.CheckOnClick = true;
            this.截屏时隐藏当前窗口ToolStripMenuItem.Name = "截屏时隐藏当前窗口ToolStripMenuItem";
            this.截屏时隐藏当前窗口ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.截屏时隐藏当前窗口ToolStripMenuItem.Text = "截屏时隐藏当前窗口";
            this.截屏时隐藏当前窗口ToolStripMenuItem.Click += new System.EventHandler(this.截屏时隐藏当前窗口ToolStripMenuItem_Click);
            // 
            // 录屏ToolStripMenuItem
            // 
            this.录屏ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.录屏ToolStripMenuItem.Name = "录屏ToolStripMenuItem";
            this.录屏ToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.录屏ToolStripMenuItem.Text = "录屏";
            this.录屏ToolStripMenuItem.Click += new System.EventHandler(this.录屏ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.audioRecord);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.screenShot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 34);
            this.panel1.TabIndex = 16;
            // 
            // audioRecord
            // 
            this.audioRecord.Location = new System.Drawing.Point(334, 2);
            this.audioRecord.Name = "audioRecord";
            this.audioRecord.Size = new System.Drawing.Size(160, 30);
            this.audioRecord.TabIndex = 2;
            this.audioRecord.Tag = "false";
            this.audioRecord.Text = "录音";
            this.audioRecord.UseVisualStyleBackColor = true;
            this.audioRecord.Click += new System.EventHandler(this.audioRecord_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "录屏";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // screenShot
            // 
            this.screenShot.Location = new System.Drawing.Point(2, 2);
            this.screenShot.Name = "screenShot";
            this.screenShot.Size = new System.Drawing.Size(160, 30);
            this.screenShot.TabIndex = 0;
            this.screenShot.Text = "截屏";
            this.screenShot.UseVisualStyleBackColor = true;
            this.screenShot.Click += new System.EventHandler(this.screenShot_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1109, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Bepsun监控系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 语言设置ToolStripMenuItem;
        private ToolStripMenuItem 中文ToolStripMenuItem;
        private ToolStripMenuItem EnglishToolStripMenuItem;
        private ToolStripMenuItem 平台总览ToolStripMenuItem;
        private ToolStripMenuItem 产线一览ToolStripMenuItem;
        private ToolStripMenuItem 产线监控ToolStripMenuItem;
        private ToolStripMenuItem 视频会议ToolStripMenuItem;
        private ToolStripMenuItem 检测内核ToolStripMenuItem;
        private ToolStripMenuItem 截屏ToolStripMenuItem;
        private ToolStripMenuItem 截屏时隐藏当前窗口ToolStripMenuItem;
        private ToolStripMenuItem 录屏ToolStripMenuItem;
        private Panel panel1;
        private Button audioRecord;
        private Button button2;
        private Button screenShot;
    }
}
