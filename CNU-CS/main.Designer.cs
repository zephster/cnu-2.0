﻿namespace CNU_CS
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
            this.components = new System.ComponentModel.Container();
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
            this.tab_changelog = new System.Windows.Forms.TabPage();
            this.txt_changelog = new System.Windows.Forms.RichTextBox();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.table_settings = new System.Windows.Forms.TableLayoutPanel();
            this.gui_settingsTab = new System.Windows.Forms.TabControl();
            this.tab_options = new System.Windows.Forms.TabPage();
            this.group_options = new System.Windows.Forms.GroupBox();
            this.chk_autoUnzip = new System.Windows.Forms.CheckBox();
            this.group_backups = new System.Windows.Forms.GroupBox();
            this.txt_backupNumCopies = new System.Windows.Forms.TextBox();
            this.lbl_numBackupCopies = new System.Windows.Forms.Label();
            this.chk_backupEnable = new System.Windows.Forms.CheckBox();
            this.chk_autoCheck = new System.Windows.Forms.CheckBox();
            this.tab_advanced = new System.Windows.Forms.TabPage();
            this.txtLatestUrl = new System.Windows.Forms.TextBox();
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaseUrl = new System.Windows.Forms.Label();
            this.tab_about = new System.Windows.Forms.TabPage();
            this.btn_checkCNUUpdate = new System.Windows.Forms.Button();
            this.lbl_CNUversion = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.timer_downloadSpeed = new System.Windows.Forms.Timer(this.components);
            this.chk_autoDownload = new System.Windows.Forms.CheckBox();
            this.gui_tabs.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.group_update.SuspendLayout();
            this.tab_changelog.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.table_settings.SuspendLayout();
            this.gui_settingsTab.SuspendLayout();
            this.tab_options.SuspendLayout();
            this.group_options.SuspendLayout();
            this.group_backups.SuspendLayout();
            this.tab_advanced.SuspendLayout();
            this.tab_about.SuspendLayout();
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
            this.btn_viewChangelog.Click += new System.EventHandler(this.btn_viewChangelog_Click);
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
            this.gui_tabs.Controls.Add(this.tab_changelog);
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
            this.group_update.Visible = false;
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
            this.lbl_downloadProgress.Location = new System.Drawing.Point(8, 146);
            this.lbl_downloadProgress.Name = "lbl_downloadProgress";
            this.lbl_downloadProgress.Size = new System.Drawing.Size(144, 27);
            this.lbl_downloadProgress.TabIndex = 4;
            this.lbl_downloadProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_changelog
            // 
            this.tab_changelog.Controls.Add(this.txt_changelog);
            this.tab_changelog.Location = new System.Drawing.Point(4, 22);
            this.tab_changelog.Name = "tab_changelog";
            this.tab_changelog.Padding = new System.Windows.Forms.Padding(3);
            this.tab_changelog.Size = new System.Drawing.Size(194, 284);
            this.tab_changelog.TabIndex = 2;
            this.tab_changelog.Text = "Changelog";
            this.tab_changelog.UseVisualStyleBackColor = true;
            // 
            // txt_changelog
            // 
            this.txt_changelog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_changelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_changelog.Location = new System.Drawing.Point(3, 3);
            this.txt_changelog.Name = "txt_changelog";
            this.txt_changelog.ReadOnly = true;
            this.txt_changelog.Size = new System.Drawing.Size(188, 278);
            this.txt_changelog.TabIndex = 1;
            this.txt_changelog.Text = "Nothing here!\nCheck for updates first.";
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.table_settings);
            this.tab_settings.Controls.Add(this.lbl_title);
            this.tab_settings.Location = new System.Drawing.Point(4, 22);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(194, 284);
            this.tab_settings.TabIndex = 1;
            this.tab_settings.Text = "Settings";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // table_settings
            // 
            this.table_settings.ColumnCount = 1;
            this.table_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_settings.Controls.Add(this.gui_settingsTab, 0, 0);
            this.table_settings.Controls.Add(this.lbl_CNUversion, 0, 1);
            this.table_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_settings.Location = new System.Drawing.Point(3, 49);
            this.table_settings.Name = "table_settings";
            this.table_settings.RowCount = 2;
            this.table_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_settings.Size = new System.Drawing.Size(188, 232);
            this.table_settings.TabIndex = 1;
            // 
            // gui_settingsTab
            // 
            this.gui_settingsTab.Controls.Add(this.tab_options);
            this.gui_settingsTab.Controls.Add(this.tab_advanced);
            this.gui_settingsTab.Controls.Add(this.tab_about);
            this.gui_settingsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gui_settingsTab.Location = new System.Drawing.Point(3, 3);
            this.gui_settingsTab.Name = "gui_settingsTab";
            this.gui_settingsTab.SelectedIndex = 0;
            this.gui_settingsTab.Size = new System.Drawing.Size(182, 206);
            this.gui_settingsTab.TabIndex = 5;
            // 
            // tab_options
            // 
            this.tab_options.Controls.Add(this.group_options);
            this.tab_options.Location = new System.Drawing.Point(4, 22);
            this.tab_options.Name = "tab_options";
            this.tab_options.Padding = new System.Windows.Forms.Padding(3);
            this.tab_options.Size = new System.Drawing.Size(174, 180);
            this.tab_options.TabIndex = 0;
            this.tab_options.Text = "Options";
            this.tab_options.UseVisualStyleBackColor = true;
            // 
            // group_options
            // 
            this.group_options.BackColor = System.Drawing.Color.Transparent;
            this.group_options.Controls.Add(this.chk_autoDownload);
            this.group_options.Controls.Add(this.chk_autoUnzip);
            this.group_options.Controls.Add(this.group_backups);
            this.group_options.Controls.Add(this.chk_autoCheck);
            this.group_options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_options.Location = new System.Drawing.Point(3, 3);
            this.group_options.Name = "group_options";
            this.group_options.Size = new System.Drawing.Size(168, 174);
            this.group_options.TabIndex = 2;
            this.group_options.TabStop = false;
            // 
            // chk_autoUnzip
            // 
            this.chk_autoUnzip.AutoSize = true;
            this.chk_autoUnzip.Location = new System.Drawing.Point(14, 63);
            this.chk_autoUnzip.Name = "chk_autoUnzip";
            this.chk_autoUnzip.Size = new System.Drawing.Size(105, 17);
            this.chk_autoUnzip.TabIndex = 3;
            this.chk_autoUnzip.Text = "Auto-unzip - NYI";
            this.chk_autoUnzip.UseVisualStyleBackColor = true;
            this.chk_autoUnzip.CheckedChanged += new System.EventHandler(this.chk_autoUnzip_CheckedChanged);
            // 
            // group_backups
            // 
            this.group_backups.Controls.Add(this.txt_backupNumCopies);
            this.group_backups.Controls.Add(this.lbl_numBackupCopies);
            this.group_backups.Controls.Add(this.chk_backupEnable);
            this.group_backups.Location = new System.Drawing.Point(6, 100);
            this.group_backups.Name = "group_backups";
            this.group_backups.Size = new System.Drawing.Size(156, 68);
            this.group_backups.TabIndex = 2;
            this.group_backups.TabStop = false;
            this.group_backups.Text = "Backups";
            // 
            // txt_backupNumCopies
            // 
            this.txt_backupNumCopies.Enabled = false;
            this.txt_backupNumCopies.Location = new System.Drawing.Point(40, 39);
            this.txt_backupNumCopies.MaxLength = 3;
            this.txt_backupNumCopies.Name = "txt_backupNumCopies";
            this.txt_backupNumCopies.Size = new System.Drawing.Size(32, 21);
            this.txt_backupNumCopies.TabIndex = 5;
            this.txt_backupNumCopies.Text = "5";
            this.txt_backupNumCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_backupNumCopies.Click += new System.EventHandler(this.txt_backupNumCopies_Click);
            this.txt_backupNumCopies.TextChanged += new System.EventHandler(this.txt_backupNumCopies_TextChanged);
            this.txt_backupNumCopies.LostFocus += new System.EventHandler(this.txt_backupNumCopies_LostFocus);
            // 
            // lbl_numBackupCopies
            // 
            this.lbl_numBackupCopies.Location = new System.Drawing.Point(0, 40);
            this.lbl_numBackupCopies.Name = "lbl_numBackupCopies";
            this.lbl_numBackupCopies.Size = new System.Drawing.Size(168, 16);
            this.lbl_numBackupCopies.TabIndex = 4;
            this.lbl_numBackupCopies.Text = "Keep             previous copies.";
            this.lbl_numBackupCopies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_backupEnable
            // 
            this.chk_backupEnable.AutoSize = true;
            this.chk_backupEnable.Location = new System.Drawing.Point(8, 16);
            this.chk_backupEnable.Name = "chk_backupEnable";
            this.chk_backupEnable.Size = new System.Drawing.Size(150, 17);
            this.chk_backupEnable.TabIndex = 3;
            this.chk_backupEnable.Text = "Enable managed backups";
            this.chk_backupEnable.UseVisualStyleBackColor = true;
            this.chk_backupEnable.CheckedChanged += new System.EventHandler(this.chk_backupEnable_CheckedChanged);
            // 
            // chk_autoCheck
            // 
            this.chk_autoCheck.AutoSize = true;
            this.chk_autoCheck.Location = new System.Drawing.Point(14, 16);
            this.chk_autoCheck.Name = "chk_autoCheck";
            this.chk_autoCheck.Size = new System.Drawing.Size(135, 17);
            this.chk_autoCheck.TabIndex = 1;
            this.chk_autoCheck.Text = "Auto Check on Startup";
            this.chk_autoCheck.UseVisualStyleBackColor = true;
            this.chk_autoCheck.CheckedChanged += new System.EventHandler(this.chk_autoCheck_CheckedChanged);
            // 
            // tab_advanced
            // 
            this.tab_advanced.Controls.Add(this.txtLatestUrl);
            this.tab_advanced.Controls.Add(this.txtBaseUrl);
            this.tab_advanced.Controls.Add(this.label2);
            this.tab_advanced.Controls.Add(this.label1);
            this.tab_advanced.Controls.Add(this.lblBaseUrl);
            this.tab_advanced.Location = new System.Drawing.Point(4, 22);
            this.tab_advanced.Name = "tab_advanced";
            this.tab_advanced.Size = new System.Drawing.Size(174, 180);
            this.tab_advanced.TabIndex = 2;
            this.tab_advanced.Text = "Advanced";
            this.tab_advanced.UseVisualStyleBackColor = true;
            // 
            // txtLatestUrl
            // 
            this.txtLatestUrl.Location = new System.Drawing.Point(4, 91);
            this.txtLatestUrl.Name = "txtLatestUrl";
            this.txtLatestUrl.Size = new System.Drawing.Size(163, 21);
            this.txtLatestUrl.TabIndex = 1;
            this.txtLatestUrl.TextChanged += new System.EventHandler(this.txtLatestUrl_TextChanged);
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Location = new System.Drawing.Point(4, 22);
            this.txtBaseUrl.Multiline = true;
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.Size = new System.Drawing.Size(163, 47);
            this.txtBaseUrl.TabIndex = 1;
            this.txtBaseUrl.TextChanged += new System.EventHandler(this.txtBaseUrl_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Restart CNU after changing either of these values.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Changes File";
            // 
            // lblBaseUrl
            // 
            this.lblBaseUrl.AutoSize = true;
            this.lblBaseUrl.Location = new System.Drawing.Point(4, 5);
            this.lblBaseUrl.Name = "lblBaseUrl";
            this.lblBaseUrl.Size = new System.Drawing.Size(102, 13);
            this.lblBaseUrl.TabIndex = 0;
            this.lblBaseUrl.Text = "Chromium Base URL";
            // 
            // tab_about
            // 
            this.tab_about.Controls.Add(this.btn_checkCNUUpdate);
            this.tab_about.Location = new System.Drawing.Point(4, 22);
            this.tab_about.Name = "tab_about";
            this.tab_about.Padding = new System.Windows.Forms.Padding(3);
            this.tab_about.Size = new System.Drawing.Size(174, 180);
            this.tab_about.TabIndex = 1;
            this.tab_about.Text = "About";
            this.tab_about.UseVisualStyleBackColor = true;
            // 
            // btn_checkCNUUpdate
            // 
            this.btn_checkCNUUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_checkCNUUpdate.Location = new System.Drawing.Point(3, 146);
            this.btn_checkCNUUpdate.Name = "btn_checkCNUUpdate";
            this.btn_checkCNUUpdate.Size = new System.Drawing.Size(168, 31);
            this.btn_checkCNUUpdate.TabIndex = 0;
            this.btn_checkCNUUpdate.Text = "Check for CNU Updates";
            this.btn_checkCNUUpdate.UseVisualStyleBackColor = true;
            this.btn_checkCNUUpdate.Click += new System.EventHandler(this.btn_checkCNUUpdate_Click);
            // 
            // lbl_CNUversion
            // 
            this.lbl_CNUversion.AutoSize = true;
            this.lbl_CNUversion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CNUversion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CNUversion.Location = new System.Drawing.Point(3, 212);
            this.lbl_CNUversion.Name = "lbl_CNUversion";
            this.lbl_CNUversion.Size = new System.Drawing.Size(182, 20);
            this.lbl_CNUversion.TabIndex = 0;
            this.lbl_CNUversion.Text = "Version Kush 4.2.0";
            this.lbl_CNUversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // timer_downloadSpeed
            // 
            this.timer_downloadSpeed.Interval = 250;
            this.timer_downloadSpeed.Tick += new System.EventHandler(this.timer_downloadSpeed_Tick);
            // 
            // chk_autoDownload
            // 
            this.chk_autoDownload.AutoSize = true;
            this.chk_autoDownload.Location = new System.Drawing.Point(14, 40);
            this.chk_autoDownload.Name = "chk_autoDownload";
            this.chk_autoDownload.Size = new System.Drawing.Size(146, 17);
            this.chk_autoDownload.TabIndex = 4;
            this.chk_autoDownload.Text = "Auto Download on Check";
            this.chk_autoDownload.UseVisualStyleBackColor = true;
            this.chk_autoDownload.CheckedChanged += new System.EventHandler(this.chk_autoDownload_CheckedChanged);
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
            this.Load += new System.EventHandler(this.main_Load);
            this.gui_tabs.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.group_update.ResumeLayout(false);
            this.tab_changelog.ResumeLayout(false);
            this.tab_settings.ResumeLayout(false);
            this.table_settings.ResumeLayout(false);
            this.table_settings.PerformLayout();
            this.gui_settingsTab.ResumeLayout(false);
            this.tab_options.ResumeLayout(false);
            this.group_options.ResumeLayout(false);
            this.group_options.PerformLayout();
            this.group_backups.ResumeLayout(false);
            this.group_backups.PerformLayout();
            this.tab_advanced.ResumeLayout(false);
            this.tab_advanced.PerformLayout();
            this.tab_about.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel table_settings;
        private System.Windows.Forms.Label lbl_CNUversion;
        private System.Windows.Forms.TabPage tab_changelog;
        private System.Windows.Forms.RichTextBox txt_changelog;
        private System.Windows.Forms.Timer timer_downloadSpeed;
        private System.Windows.Forms.TabControl gui_settingsTab;
        private System.Windows.Forms.TabPage tab_options;
        private System.Windows.Forms.GroupBox group_options;
        private System.Windows.Forms.CheckBox chk_autoUnzip;
        private System.Windows.Forms.GroupBox group_backups;
        private System.Windows.Forms.TextBox txt_backupNumCopies;
        private System.Windows.Forms.Label lbl_numBackupCopies;
        private System.Windows.Forms.CheckBox chk_backupEnable;
        private System.Windows.Forms.CheckBox chk_autoCheck;
        private System.Windows.Forms.TabPage tab_about;
        private System.Windows.Forms.Button btn_checkCNUUpdate;
        private System.Windows.Forms.TabPage tab_advanced;
        private System.Windows.Forms.TextBox txtBaseUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaseUrl;
        private System.Windows.Forms.TextBox txtLatestUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_autoDownload;

    }
}

