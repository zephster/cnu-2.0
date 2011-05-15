/*
 * Chrome Nightly Updater+ 2.0, ©2010 Brandon Sachs <antizeph@gmail.com>
 * 
This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see <http://www.gnu.org/licenses/>.
*/

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
 * todo:
 *      changelog - DONE!
 *      settings tab
 *      option to auto-check on startup
 *      keep x number of past copies
 *      auto-unzip
 *      update checker/downloader/updater for cnu
 *      custom download file naming (the zip file)
 */


namespace CNU_CS
{
    public partial class main : Form
    {

        private static WebClient client = new WebClient();
        //public int latets_build;
        //public int last_downloaded;
        public string latest_build = "00000";
        public string last_downloaded;
        public const string latest_url = "http://74.125.248.71/f/chromium/snapshots/chromium-rel-xp/LATEST";

        public main()
        {
            InitializeComponent();
            lbl_lastDownloaded.Text = Properties.Settings.Default.last_downloaded;
            client.Headers.Add("UserAgent", "cnup2!");

            object v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            string version_info = v.ToString();
            lbl_CNUversion.Text = version_info;
            lbl_latestBuild.Text = latest_build;
        }


        //thread delegates
        private delegate void threadDelegate_update(string message);
        private delegate void threadDelegate_downloadProgress(object sender, DownloadProgressChangedEventArgs e);
        private delegate void threadDelegate_download(object sender, AsyncCompletedEventArgs e);
        private delegate void threadDelegate_changelog(string changelog);

        //threaded functions
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
                threadDelegate_downloadProgress d = new threadDelegate_downloadProgress(thread_downloadProgressUpdate);
                this.progress_download.Invoke(d, sender, e);
                this.lbl_downloadProgress.Invoke(d, sender, e);
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
            if (this.btn_downloadUpdate.InvokeRequired)
            {
                threadDelegate_download d = new threadDelegate_download(thread_downloadComplete);
                this.btn_downloadUpdate.Invoke(d, sender, e);
                this.lbl_downloadProgress.Invoke(d, sender, e);
                this.progress_download.Invoke(d, sender, e);
                this.btn_cancelDownload.Invoke(d, sender, e);

            }
            else
            {
                this.btn_downloadUpdate.Text = "Re-Download";
                this.btn_downloadUpdate.Enabled = true;
                this.lbl_downloadProgress.Text = "";
                this.btn_cancelDownload.Visible = false;
                this.progress_download.Value = 0;
                saveLastDownloaded(this.latest_build);
            }
        }
        private void thread_changelogComplete(string changelog)
        {
            if (this.txt_changelog.InvokeRequired)
            {
                threadDelegate_changelog d = new threadDelegate_changelog(thread_changelogComplete);
                this.txt_changelog.Invoke(d, changelog);
            }
            else
            {
                this.txt_changelog.Text = changelog;
            }
        }





        //callbacks        
        void checkUpdateCallback(object sender, DownloadStringCompletedEventArgs e)
        {
            thread_doneUpdating(e.Result);
        }
        private void changelogCallback(object sender, DownloadStringCompletedEventArgs e)
        {
            StringBuilder changelog = new StringBuilder();
            string xml = e.Result;

            using (XmlReader parser = XmlReader.Create(new StringReader(xml)))
            {
                parser.ReadToFollowing("author");
                string xml_author = parser.ReadElementContentAsString();

                parser.ReadToFollowing("date");
                string xml_date = parser.ReadElementContentAsString();

                parser.ReadToFollowing("msg");
                string xml_msg = parser.ReadElementContentAsString();

                //gaps in new lines
                xml_msg = xml_msg.Replace("\n\n", "\n");
                xml_msg = xml_msg.Replace("\n\n\n", "\n");
                xml_msg = xml_msg.Replace("\n\n\n\n", "\n");

                string changelog_complete = "author:\n" + xml_author
                    + "\n\ndate:\n" + xml_date
                    + "\n\nmessage:\n" + xml_msg;

                //Console.WriteLine(changelog_complete);
                thread_changelogComplete(changelog_complete);
            }
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
                client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(checkUpdateCallback);
                client.DownloadStringAsync(new Uri(latest_url));
            }
            catch (Exception err)
            {
                throw new Exception("Error checking for latest vesion, oh no!\n" + err.Message, err);
            }
        }


        private void viewChangelog()
        {
            try{
                Uri changelog_url = new Uri("http://74.125.248.71/f/chromium/snapshots/chromium-rel-xp/"
                        + latest_build +
                        "/changelog.xml");
                client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(changelogCallback);
                client.DownloadStringAsync(changelog_url);
                
            } catch (Exception err){
                throw new Exception("Error finding changelog, oh my!\n" + err.Message, err);
            }
        }

        private void downloadUpdate()
        {
            try
            {
                string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                Uri latest_build = new Uri("http://74.125.248.71/buildbot/snapshots/chromium-rel-xp/"
                    + this.latest_build
                    //+ "85361" //random for testing
                    + "/chrome-win32.zip");

                client.DownloadFileCompleted += new AsyncCompletedEventHandler(thread_downloadComplete);
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(thread_downloadProgressUpdate);
                client.DownloadFileAsync(latest_build, appPath + @"\chrome-win32-" + this.latest_build + ".zip");
                
                //test smaller file
                //client.DownloadFileAsync(new Uri("http://friedwalrus.com/files/DSC00741.JPG"), appPath + @"\smaller-test-file.jpg");
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

            //downloadUpdate();

            Thread download = new Thread(downloadUpdate);
            download.Name = "Download Update Thread";
            download.Start();
        }

        private void btn_cancelDownload_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
            progress_download.Value = 0;
            btn_cancelDownload.Visible = false;
        }

        private void btn_viewChangelog_Click(object sender, EventArgs e)
        {
            gui_tabs.SelectedTab = tab_changelog;
            txt_changelog.Text = "Loading...";

            //viewChangelog();

            Thread changelog = new Thread(viewChangelog);
            changelog.Name = "View Changelog Thread";
            changelog.Start();
        }

    }
}
