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
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbl_lastDownloadedText
            // 
            this.lbl_lastDownloadedText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastDownloadedText.Location = new System.Drawing.Point(13, 10);
            this.lbl_lastDownloadedText.Name = "lbl_lastDownloadedText";
            this.lbl_lastDownloadedText.Size = new System.Drawing.Size(110, 20);
            this.lbl_lastDownloadedText.TabIndex = 0;
            this.lbl_lastDownloadedText.Text = "Last Downloaded:";
            this.lbl_lastDownloadedText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_latestBuildText
            // 
            this.lbl_latestBuildText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latestBuildText.Location = new System.Drawing.Point(13, 30);
            this.lbl_latestBuildText.Name = "lbl_latestBuildText";
            this.lbl_latestBuildText.Size = new System.Drawing.Size(110, 20);
            this.lbl_latestBuildText.TabIndex = 0;
            this.lbl_latestBuildText.Text = "Latest Build:";
            this.lbl_latestBuildText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_lastDownloaded
            // 
            this.lbl_lastDownloaded.AutoSize = true;
            this.lbl_lastDownloaded.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastDownloaded.Location = new System.Drawing.Point(119, 12);
            this.lbl_lastDownloaded.Name = "lbl_lastDownloaded";
            this.lbl_lastDownloaded.Size = new System.Drawing.Size(56, 16);
            this.lbl_lastDownloaded.TabIndex = 0;
            this.lbl_lastDownloaded.Text = "000000";
            this.lbl_lastDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_latestBuild
            // 
            this.lbl_latestBuild.AutoSize = true;
            this.lbl_latestBuild.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latestBuild.Location = new System.Drawing.Point(119, 32);
            this.lbl_latestBuild.Name = "lbl_latestBuild";
            this.lbl_latestBuild.Size = new System.Drawing.Size(56, 16);
            this.lbl_latestBuild.TabIndex = 0;
            this.lbl_latestBuild.Text = "000000";
            this.lbl_latestBuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_checkUpdate
            // 
            this.btn_checkUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_checkUpdate.Location = new System.Drawing.Point(16, 53);
            this.btn_checkUpdate.Name = "btn_checkUpdate";
            this.btn_checkUpdate.Size = new System.Drawing.Size(162, 36);
            this.btn_checkUpdate.TabIndex = 1;
            this.btn_checkUpdate.Text = "Check for Update";
            this.btn_checkUpdate.UseVisualStyleBackColor = true;
            this.btn_checkUpdate.Click += new System.EventHandler(this.btn_checkUpdate_Click);
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(48, 288);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(100, 23);
            this.progress_bar.TabIndex = 2;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 376);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.btn_checkUpdate);
            this.Controls.Add(this.lbl_latestBuild);
            this.Controls.Add(this.lbl_latestBuildText);
            this.Controls.Add(this.lbl_lastDownloaded);
            this.Controls.Add(this.lbl_lastDownloadedText);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CNU 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lastDownloadedText;
        private System.Windows.Forms.Label lbl_latestBuildText;
        private System.Windows.Forms.Label lbl_lastDownloaded;
        private System.Windows.Forms.Label lbl_latestBuild;
        private System.Windows.Forms.Button btn_checkUpdate;
        private System.Windows.Forms.ProgressBar progress_bar;

    }
}

