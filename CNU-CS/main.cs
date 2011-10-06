/*
 * Chrome Nightly Updater+ 2.0, ©2010 Brandon <antizeph@gmail.com>
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
using System.Security.Cryptography;

/*
 * todo:
 *      auto-unzip
 *      update checker/downloader/updater for cnu - in progress
 *      custom download file naming (the zip file) - use .replace('find', 'replace');
 *      
 * notes to future self
 *      adv. options: URIs for chrome LATEST, changelog, and binary
 *      adv. options: mybe a manual override for "latest downloaded" version
 *      
 * known bugs:
 *      clicking view changelog multiple times re-runs the callback function +1
 */


namespace CNU_CS
{
    public partial class main : Form
    {
        private static WebClient client_checkForChromeUpdate = new WebClient();
        private static WebClient client_download = new WebClient();
        private static WebClient client_downloadProgressUpdate = new WebClient();

        public static DateTime date = DateTime.Now;
        public string timestamp = date.ToString("yyyyMMdd");

        public string latest_build = "00000"; //can use 84202 to test
        public string last_downloaded = Properties.Settings.Default.last_downloaded;

        public string base_url = Properties.Settings.Default.base_url;
        public string url_latest = Properties.Settings.Default.latest_url;

        public string appPath = Path.GetDirectoryName(Application.ExecutablePath);

        public bool backup_enabled = Properties.Settings.Default.backup_enabled;
        public int backup_copies = Properties.Settings.Default.backup_copies;
        public int backup_copies_default = 5;

        public bool auto_checkUpdate = Properties.Settings.Default.auto_check;
        public bool auto_download = Properties.Settings.Default.auto_download;
        public bool auto_unzip = Properties.Settings.Default.auto_unzip;

        public long download_bytesReceived_old = 0;
        public long download_bytesReceived_new = 0;
        public long download_bytesTotal = 0;
        public long download_kbps = 0;

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            lbl_lastDownloaded.Text = last_downloaded;
            chk_autoCheck.Checked = auto_checkUpdate;
            chk_autoDownload.Checked = auto_download;
            chk_autoUnzip.Checked = auto_unzip;
            chk_backupEnable.Checked = backup_enabled;
            txt_backupNumCopies.Text = backup_copies.ToString();
            txtBaseUrl.Text = base_url;
            txtLatestUrl.Text = url_latest;

            object v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            string version_info = v.ToString();
            lbl_CNUversion.Text = "version " + version_info;

            if (latest_build != "00000")
                Console.WriteLine("Change latest_build back to 00000 for build\nAnd hide the download group");

            if (auto_checkUpdate)
            {
                //Console.WriteLine("auto-checking for chrome updates");
                btn_checkUpdate.PerformClick();
            }

            if (auto_unzip)
            {
                Console.WriteLine("auto-unzip enabled");
            }

            //Console.WriteLine(getFileMD5(appPath + "/cnu2.exe"));
        }


        //thread delegates
        private delegate void threadDelegate_update(string message);
        private delegate void threadDelegate_downloadProgress(object sender, DownloadProgressChangedEventArgs e);
        private delegate void threadDelegate_download(object sender, AsyncCompletedEventArgs e);
        private delegate void threadDelegate_changelog(string changelog);
        private delegate void threadDelegate_updateCNU(string message);

        //threaded functions
        private void thread_doneUpdating(string message)
        {
            if (this.lbl_latestBuild.InvokeRequired)
            {
                threadDelegate_update d = new threadDelegate_update(thread_doneUpdating);
                this.Invoke(d, message);
            }
            else
            {
                this.lbl_latestBuild.Text = message;
                this.btn_checkUpdate.Text = "Check for Update";
                this.btn_checkUpdate.Enabled = true;
                this.group_update.Visible = true;
                this.latest_build = message;
                Console.WriteLine("done updating");
                checkChangelog();
            }
        }

        private void thread_downloadProgressUpdate(object sender, DownloadProgressChangedEventArgs e)
        {
            
            if (this.progress_download.InvokeRequired)
            {
                threadDelegate_downloadProgress d = new threadDelegate_downloadProgress(thread_downloadProgressUpdate);
                this.Invoke(d, sender, e);
            }
            else
            {
                download_bytesReceived_new = e.BytesReceived / 1024;
                download_bytesTotal = e.TotalBytesToReceive / 1024;

                double mb_down = Math.Round(download_bytesReceived_new * 0.0009765625, 2);
                double mb_total = Math.Round(download_bytesTotal * 0.0009765625, 2);

                int percent = e.ProgressPercentage;
                this.progress_download.Value = percent;
                this.lbl_downloadProgress.Text = mb_down + "MB / " + mb_total + "MB\n" + percent + "% (" + download_kbps + " kb/s)";
                this.timer_downloadSpeed.Enabled = true;
            }
        }

        private void thread_downloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            if (this.btn_downloadUpdate.InvokeRequired)
            {
                threadDelegate_download d = new threadDelegate_download(thread_downloadComplete);
                this.Invoke(d, sender, e);
            }
            else
            {
                this.btn_downloadUpdate.Text = "Re-Download";
                this.btn_downloadUpdate.Enabled = true;
                this.lbl_downloadProgress.Text = "";
                this.btn_cancelDownload.Visible = false;
                this.progress_download.Value = 0;
                this.timer_downloadSpeed.Enabled = false;

                if (e.Cancelled)
                    System.IO.File.Delete(appPath + @"\chrome-win32-" + this.latest_build + "-" + this.timestamp + ".zip");
                else
                {
                    this.lbl_lastDownloaded.Text = this.latest_build;
                    saveLastDownloaded(this.latest_build);

                    if (backup_enabled)
                    {
                        string[] files = Directory.GetFiles(appPath, "*.zip");
                        int deleteUpTo = files.Length - backup_copies;

                        for (int x = 0; x < deleteUpTo; x++)
                        {
                            System.IO.File.Delete(files[x]);
                            Console.WriteLine("deleting file: " + files[x]);
                        }
                    }
                }
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
                if (auto_download)
                {
                    btn_downloadUpdate.PerformClick();
                }
            }
        }





        //callbacks        
        private void checkUpdateCallback(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                thread_doneUpdating(e.Result);
            }
            catch (Exception)
            {
                thread_doneUpdating("ERROR");
            }
        }

        private void changelogCallback(object sender, DownloadStringCompletedEventArgs e)
        {
            Console.WriteLine("changelogCallback - before parsing the changelog xml");
            string xml = e.Result;
            try
            {
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

                    Console.WriteLine("changelog xml parsed, results:\n" + changelog_complete);
                    thread_changelogComplete(changelog_complete);
                }
            } catch (Exception){
                //throw new Exception("Uh oh! " + err.Message);
                string changelog_complete = "No changelong for this build found.";
                thread_changelogComplete(changelog_complete);
            }
        }




        //functions
        private void checkForUpdate()
        {
            try
            {
                client_checkForChromeUpdate.DownloadStringCompleted += new DownloadStringCompletedEventHandler(checkUpdateCallback);
                client_checkForChromeUpdate.DownloadStringAsync(new Uri(base_url + url_latest));
            }
            catch (Exception err)
            {
                throw new Exception("Error checking for latest vesion, oh no!\n" + err.Message, err);
            }
        }

        private void viewChangelog()
        {
            try{
                Uri changelog_url = new Uri(base_url
                        + this.latest_build +
                        "/changelog.xml");
                //debug
                client_download.DownloadStringCompleted += new DownloadStringCompletedEventHandler(changelogCallback);
                client_download.DownloadStringAsync(changelog_url);
            } catch (Exception err){
                throw new Exception("Error finding changelog, oh my!\n" + err.Message, err);
            }
        }

        private void downloadUpdate()
        {
            try
            {
                Uri latest_build = new Uri(base_url
                    + this.latest_build
                    //+ "85361" //random for testing
                    + "/chrome-win32.zip");

                client_downloadProgressUpdate.DownloadFileCompleted += new AsyncCompletedEventHandler(thread_downloadComplete);
                client_downloadProgressUpdate.DownloadProgressChanged += new DownloadProgressChangedEventHandler(thread_downloadProgressUpdate);
                client_downloadProgressUpdate.DownloadFileAsync(latest_build,
                    appPath + @"\chrome-win32-" + this.latest_build + "-" + this.timestamp + ".zip");
                
                //test smaller file
                //client_download.DownloadFileAsync(new Uri("http://friedwalrus.com/files/DSC00741.JPG"), appPath + @"\smaller-test-file.jpg");
            }
            catch (Exception err)
            {
                throw new Exception("Error downloading update, oh my!\n" + err.Message, err);
            }            
        }

        public string getFileMD5(string file)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            StringBuilder byteStringArray = new StringBuilder();
            
            md5.ComputeHash(stream);
            stream.Close();

            byte[] hash = md5.Hash;
            foreach (byte b in hash)
                byteStringArray.Append(string.Format("{0:x2}", b)); //convert to hex

            return byteStringArray.ToString();
        }

        public void checkChangelog()
        {
            Thread changelog_thread = new Thread(viewChangelog);
            changelog_thread.Name = "View Changelog Thread";
            changelog_thread.Start();
        }

        public void downloadChromeUpdate()
        {
            Thread download = new Thread(downloadUpdate);
            download.Name = "Download Update Thread";
            download.Start();
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

            downloadChromeUpdate();
        }

        private void btn_cancelDownload_Click(object sender, EventArgs e)
        {
            client_downloadProgressUpdate.CancelAsync();
            progress_download.Value = 0;
            btn_cancelDownload.Visible = false;
        }

        private void btn_viewChangelog_Click(object sender, EventArgs e)
        {
            gui_tabs.SelectedTab = tab_changelog;
        }


        private void btn_checkCNUUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nyi");
        }

        private void chk_backupEnable_CheckedChanged(object sender, EventArgs e)
        {
            txt_backupNumCopies.Enabled = (chk_backupEnable.Checked) ? true : false;
            backup_enabled = (chk_backupEnable.Checked) ? true : false;

            Properties.Settings.Default.backup_enabled = chk_backupEnable.Checked;
            Properties.Settings.Default.Save();
        }

        private void txt_backupNumCopies_TextChanged(object sender, EventArgs e)
        {
            if (backup_enabled)
            {
                try
                {
                    backup_copies = Convert.ToInt32(txt_backupNumCopies.Text);
                    backup_copies = int.Parse(txt_backupNumCopies.Text);
                    
                    //Console.WriteLine(backup_copies);

                    Properties.Settings.Default.backup_copies = backup_copies;
                    Properties.Settings.Default.Save();
                }
                catch (Exception)
                {
                    int length = txt_backupNumCopies.TextLength;
                    if (length == 0)
                        return;
                    else
                        txt_backupNumCopies.Text = txt_backupNumCopies.Text.Substring(0, txt_backupNumCopies.TextLength - 1);
                }                
            }
        }
        private void txt_backupNumCopies_Click(object sender, EventArgs e)
        {
            txt_backupNumCopies.SelectionStart = 0;
            txt_backupNumCopies.SelectionLength = txt_backupNumCopies.TextLength;
        }
        private void txt_backupNumCopies_LostFocus(object sender, EventArgs e)
        {
            int length = txt_backupNumCopies.TextLength;
            if (length == 0)
                txt_backupNumCopies.Text = backup_copies_default.ToString();
        }

        private void timer_downloadSpeed_Tick(object sender, EventArgs e)
        {
            download_kbps = download_bytesReceived_new - download_bytesReceived_old;
            download_bytesReceived_old = download_bytesReceived_new;
            Console.WriteLine("kbps: " + download_kbps);
        }



        /*
         * SETTINGS
         */
        private void saveLastDownloaded(string version)
        {
            Properties.Settings.Default.last_downloaded = version;
            Properties.Settings.Default.Save();
        }

        private void chk_autoCheck_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.auto_check = chk_autoCheck.Checked;
            Properties.Settings.Default.Save();
        }

        private void chk_autoUnzip_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.auto_unzip = chk_autoUnzip.Checked;
            Properties.Settings.Default.Save();
        }

        private void txtBaseUrl_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.base_url = txtBaseUrl.Text;
            Properties.Settings.Default.Save();
        }

        private void txtLatestUrl_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.latest_url = txtLatestUrl.Text;
            Properties.Settings.Default.Save();
        }

        private void chk_autoDownload_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.auto_download = chk_autoDownload.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
