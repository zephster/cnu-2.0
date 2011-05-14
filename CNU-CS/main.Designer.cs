namespace CNU_CS
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_lastDownloadedText = new System.Windows.Forms.Label();
            this.lbl_latestBuildText = new System.Windows.Forms.Label();
            this.lbl_lastDownloaded = new System.Windows.Forms.Label();
            this.lbl_latestBuild = new System.Windows.Forms.Label();
            this.btn_checkUpdate = new System.Windows.Forms.Button();
            this.btn_viewChangelog = new System.Windows.Forms.Button();
            this.btn_downloadUpdate = new System.Windows.Forms.Button();
            this.progress_download = new System.Windows.Forms.ProgressBar();
            this.gui_tabs = new System.Windows.Forms.TabControl();
            this.tab_main = new System.Windows.Forms.TabPage();
            this.group_update = new System.Windows.Forms.GroupBox();
            this.btn_cancelDownload = new System.Windows.Forms.Button();
            this.lbl_downloadProgress = new System.Windows.Forms.Label();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gui_tabs.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.group_update.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_lastDownloadedText
            // 
            this.lbl_lastDownloadedText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastDownloadedText.Location = new System.Drawing.Point(12, 30);
            this.lbl_lastDownloadedText.Name = "lbl_lastDownloadedText";
            this.lbl_lastDownloadedText.Size = new System.Drawing.Size(110, 20);
            this.lbl_lastDownloadedText.TabIndex = 0;
            this.lbl_lastDownloadedText.Text = "Last Downloaded:";
            this.lbl_lastDownloadedText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_latestBuildText
            // 
            this.lbl_latestBuildText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latestBuildText.Location = new System.Drawing.Point(12, 10);
            this.lbl_latestBuildText.Name = "lbl_latestBuildText";
            this.lbl_latestBuildText.Size = new System.Drawing.Size(110, 20);
            this.lbl_latestBuildText.TabIndex = 0;
            this.lbl_latestBuildText.Text = "Latest Build:";
            this.lbl_latestBuildText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_lastDownloaded
            // 
            this.lbl_lastDownloaded.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastDownloaded.Location = new System.Drawing.Point(118, 32);
            this.lbl_lastDownloaded.Name = "lbl_lastDownloaded";
            this.lbl_lastDownloaded.Size = new System.Drawing.Size(66, 16);
            this.lbl_lastDownloaded.TabIndex = 0;
            this.lbl_lastDownloaded.Text = "000000";
            this.lbl_lastDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_latestBuild
            // 
            this.lbl_latestBuild.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latestBuild.Location = new System.Drawing.Point(118, 12);
            this.lbl_latestBuild.Name = "lbl_latestBuild";
            this.lbl_latestBuild.Size = new System.Drawing.Size(66, 16);
            this.lbl_latestBuild.TabIndex = 0;
            this.lbl_latestBuild.Text = "??????";
            this.lbl_latestBuild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_checkUpdate
            // 
            this.btn_checkUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_checkUpdate.Location = new System.Drawing.Point(15, 53);
            this.btn_checkUpdate.Name = "btn_checkUpdate";
            this.btn_checkUpdate.Size = new System.Drawing.Size(162, 36);
            this.btn_checkUpdate.TabIndex = 1;
            this.btn_checkUpdate.Text = "Check for Update";
            this.btn_checkUpdate.UseVisualStyleBackColor = true;
            this.btn_checkUpdate.Click += new System.EventHandler(this.btn_checkUpdate_Click);
            // 
            // btn_viewChangelog
            // 
            this.btn_viewChangelog.Location = new System.Drawing.Point(8, 64);
            this.btn_viewChangelog.Name = "btn_viewChangelog";
            this.btn_viewChangelog.Size = new System.Drawing.Size(144, 48);
            this.btn_viewChangelog.TabIndex = 2;
            this.btn_viewChangelog.Text = "View Changelog";
            this.btn_viewChangelog.UseVisualStyleBackColor = true;
            // 
            // btn_downloadUpdate
            // 
            this.btn_downloadUpdate.Location = new System.Drawing.Point(8, 16);
            this.btn_downloadUpdate.Name = "btn_downloadUpdate";
            this.btn_downloadUpdate.Size = new System.Drawing.Size(144, 48);
            this.btn_downloadUpdate.TabIndex = 2;
            this.btn_downloadUpdate.Text = "Download Update";
            this.btn_downloadUpdate.UseVisualStyleBackColor = true;
            this.btn_downloadUpdate.Click += new System.EventHandler(this.btn_downloadUpdate_Click);
            // 
            // progress_download
            // 
            this.progress_download.Cursor = System.Windows.Forms.Cursors.Default;
            this.progress_download.Location = new System.Drawing.Point(8, 120);
            this.progress_download.Name = "progress_download";
            this.progress_download.Size = new System.Drawing.Size(144, 23);
            this.progress_download.TabIndex = 3;
            // 
            // gui_tabs
            // 
            this.gui_tabs.Controls.Add(this.tab_main);
            this.gui_tabs.Controls.Add(this.tab_settings);
            this.gui_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gui_tabs.Location = new System.Drawing.Point(10, 10);
            this.gui_tabs.Name = "gui_tabs";
            this.gui_tabs.SelectedIndex = 0;
            this.gui_tabs.Size = new System.Drawing.Size(202, 310);
            this.gui_tabs.TabIndex = 4;
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.group_update);
            this.tab_main.Controls.Add(this.lbl_lastDownloadedText);
            this.tab_main.Controls.Add(this.lbl_lastDownloaded);
            this.tab_main.Controls.Add(this.lbl_latestBuildText);
            this.tab_main.Controls.Add(this.lbl_latestBuild);
            this.tab_main.Controls.Add(this.btn_checkUpdate);
            this.tab_main.Location = new System.Drawing.Point(4, 22);
            this.tab_main.Name = "tab_main";
            this.tab_main.Padding = new System.Windows.Forms.Padding(3);
            this.tab_main.Size = new System.Drawing.Size(194, 284);
            this.tab_main.TabIndex = 0;
            this.tab_main.Text = "Main";
            this.tab_main.UseVisualStyleBackColor = true;
            // 
            // group_update
            // 
            this.group_update.Controls.Add(this.btn_cancelDownload);
            this.group_update.Controls.Add(this.lbl_downloadProgress);
            this.group_update.Controls.Add(this.btn_downloadUpdate);
            this.group_update.Controls.Add(this.btn_viewChangelog);
            this.group_update.Controls.Add(this.progress_download);
            this.group_update.Location = new System.Drawing.Point(16, 96);
            this.group_update.Name = "group_update";
            this.group_update.Size = new System.Drawing.Size(160, 176);
            this.group_update.TabIndex = 4;
            this.group_update.TabStop = false;
            // 
            // btn_cancelDownload
            // 
            this.btn_cancelDownload.Location = new System.Drawing.Point(8, 16);
            this.btn_cancelDownload.Name = "btn_cancelDownload";
            this.btn_cancelDownload.Size = new System.Drawing.Size(144, 48);
            this.btn_cancelDownload.TabIndex = 5;
            this.btn_cancelDownload.Text = "Cancel";
            this.btn_cancelDownload.UseVisualStyleBackColor = true;
            this.btn_cancelDownload.Visible = false;
            this.btn_cancelDownload.Click += new System.EventHandler(this.btn_cancelDownload_Click);
            // 
            // lbl_downloadProgress
            // 
            this.lbl_downloadProgress.Location = new System.Drawing.Point(16, 152);
            this.lbl_downloadProgress.Name = "lbl_downloadProgress";
            this.lbl_downloadProgress.Size = new System.Drawing.Size(128, 13);
            this.lbl_downloadProgress.TabIndex = 4;
            this.lbl_downloadProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.lbl_title);
            this.tab_settings.Location = new System.Drawing.Point(4, 22);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(194, 284);
            this.tab_settings.TabIndex = 1;
            this.tab_settings.Text = "Settings";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(3, 3);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(188, 46);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Chrome\r\nNightly Updater+";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 330);
            this.Controls.Add(this.gui_tabs);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CNU 2.0";
            this.gui_tabs.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.group_update.ResumeLayout(false);
            this.tab_settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_lastDownloadedText;
        private System.Windows.Forms.Label lbl_latestBuildText;
        private System.Windows.Forms.Label lbl_lastDownloaded;
        private System.Windows.Forms.Label lbl_latestBuild;
        private System.Windows.Forms.Button btn_checkUpdate;
        private System.Windows.Forms.Button btn_viewChangelog;
        private System.Windows.Forms.Button btn_downloadUpdate;
        private System.Windows.Forms.ProgressBar progress_download;
        private System.Windows.Forms.TabControl gui_tabs;
        private System.Windows.Forms.TabPage tab_main;
        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.GroupBox group_update;
        private System.Windows.Forms.Label lbl_downloadProgress;
        private System.Windows.Forms.Button btn_cancelDownload;
        private System.Windows.Forms.Label lbl_title;

    }
}

