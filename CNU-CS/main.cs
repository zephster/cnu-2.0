using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net;
using System.Threading;

/*
 * ideas:
 *      option to auto-check on startup
 *      keep x number of past copies
 *      auto-unzip
 *      update checker/downloader/updater
 */


namespace CNU_CS
{
    public partial class main : Form
    {

        private static WebClient client = new WebClient();
        //change to proper int type later!
        public string latest_build;
        public string last_downloaded;

        public main()
        {
            InitializeComponent();
            lbl_lastDownloaded.Text = Properties.Settings.Default.last_downloaded;
            client.Headers.Add("UserAgent", "cnup2!");
        }

        //threaded functions
        private delegate void threadDelegate_update(string message);
        private delegate void threadDelegate_download(object sender, DownloadProgressChangedEventArgs e);
        private void thread_doneUpdating(string message)
        {
            if (this.lbl_latestBuild.InvokeRequired)
            {
                threadDelegate_update d = new threadDelegate_update(thread_doneUpdating);
                this.lbl_latestBuild.Invoke(d, message);
                this.btn_checkUpdate.Invoke(d, message);
                this.group_update.Invoke(d, message);
            }
            else
            {
                this.lbl_latestBuild.Text = message;
                this.btn_checkUpdate.Text = "Check for Update";
                this.btn_checkUpdate.Enabled = true;
                this.group_update.Visible = true;
                this.latest_build = message;
            }
        }

        private void thread_downloadProgressUpdate(object sender, DownloadProgressChangedEventArgs e)
        {
            if (this.progress_download.InvokeRequired)
            {
                threadDelegate_download d = new threadDelegate_download(thread_downloadProgressUpdate);
                this.progress_download.Invoke(d, sender);
                this.lbl_downloadProgress.Invoke(d, sender);
            }
            else
            {
                long bytes = e.BytesReceived / 1024;
                long totalBytes = e.TotalBytesToReceive / 1024;

                this.progress_download.Value = e.ProgressPercentage;
                this.lbl_downloadProgress.Text = bytes + "kb / " + totalBytes + "kb";
            }
        }

        private void thread_downloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            this.btn_downloadUpdate.Text = "Re-Download";
            this.btn_downloadUpdate.Enabled = true;
            saveLastDownloaded(this.latest_build);
        }





        //callbacks        
        void checkUpdateCallback(object sender, DownloadStringCompletedEventArgs e)
        {
            string latest_version = e.Result;
            thread_doneUpdating(e.Result);
        }

        private void saveLastDownloaded(string version)
        {
            Properties.Settings.Default.last_downloaded = version;
            Properties.Settings.Default.Save();
        }



        //functions
        private void checkForUpdate()
        {
            try
            {
                //make this a changeable setting, in case google changes the url again.
                Uri latest_url = new Uri("http://74.125.248.71/f/chromium/snapshots/chromium-rel-xp/LATEST");
                client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(checkUpdateCallback);
                client.DownloadStringAsync(latest_url);
            }
            catch (Exception err)
            {
                throw new Exception("Error checking for latest vesion, oh no!\n" + err.Message, err);
            }
        }

        /// <summary>
        /// 	System.Xml.XmlDocument doc = new XmlDocument() ;
	    ///     doc.Load("http://www.eggheadcafe.com/rss.xml");
	    ///     Console.WriteLine(doc.OuterXml );
	    ///     Console.ReadLine();
        /// </summary>
        private void viewChangelog()
        {
            //retreives XML for the changelog from current version in LATEST
        }

        private void downloadUpdate()
        {
            //actually download the update, and show progress bar and speed if possible
            //http://74.125.248.71/buildbot/snapshots/chromium-rel-xp/" & lblLatest & "/chrome-win32.zip
            try
            {
                string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                Uri latest_build = new Uri("http://74.125.248.71/buildbot/snapshots/chromium-rel-xp/"
                    //+ this.latest_build
                    + "85361"
                    + "/chrome-win32.zip");

                client.DownloadFileCompleted += new AsyncCompletedEventHandler(thread_downloadComplete);
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(thread_downloadProgressUpdate);
                client.DownloadFileAsync(latest_build, appPath + @"\chrome-win32-" + this.latest_build + ".zip");
                //client.DownloadFileAsync(new Uri("http://friedwalrus.com/files/DSC00741.JPG"), appPath + @"\chrome-win32.zip");
            }
            catch (Exception err)
            {
                throw new Exception("Error downloading update, oh my!\n" + err.Message, err);
            }
            
        }



        //form buttons
        private void btn_checkUpdate_Click(object sender, EventArgs e)
        {
            btn_checkUpdate.Text = "Checking...";
            btn_checkUpdate.Enabled = false;

            //new thread
            Thread update = new Thread(checkForUpdate);
            update.Name = "Update Check Thread";
            update.Start();
        }

        private void btn_downloadUpdate_Click(object sender, EventArgs e)
        {
            btn_downloadUpdate.Text = "Downloading...";
            btn_downloadUpdate.Enabled = false;
            btn_cancelDownload.Visible = true;

            downloadUpdate();

            //Thread download = new Thread(downloadUpdate);
            //download.Name = "Download Update Thread";
            //download.Start();
        }

        private void btn_cancelDownload_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
            progress_download.Value = 0;
            btn_cancelDownload.Visible = false;
        }

    }
}
