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

//http://www.csharp-examples.net/download-files/
//http://www.developerfusion.com/article/4637/retrieving-http-content-in-net/2/
//http://www.csharp-examples.net/xml-nodes-by-name/
//http://support.microsoft.com/kb/307643

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

        public main()
        {
            InitializeComponent();
        }

        //threaded functions
        private delegate void ThreadSafeMethodCallDelegate(string message);
        private void thread_setLatestVersion(string message)
        {
            if (this.lbl_lastDownloaded.InvokeRequired)
            {
                ThreadSafeMethodCallDelegate d = new ThreadSafeMethodCallDelegate(thread_setLatestVersion);
                this.lbl_lastDownloaded.Invoke(d, message);
                this.btn_checkUpdate.Invoke(d, message);
            }
            else
            {
                this.lbl_lastDownloaded.Text = message;
                this.btn_checkUpdate.Text = "Check for Update";
                this.btn_checkUpdate.Enabled = true;
            }
        }



        //callbacks        
        void updateCallback(object sender, DownloadStringCompletedEventArgs e)
        {
            string latest_version = e.Result;
            thread_setLatestVersion(e.Result);
        }




        //functions - thread 'update'
        private void checkForUpdate()
        {
            try
            {
                //make this a changeable setting, in case google changes the url again.
                Uri latest_url = new Uri("http://74.125.248.71/f/chromium/snapshots/chromium-rel-xp/LATEST");

                client.Headers.Add("UserAgent", "cnup2");
                client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(updateCallback);
                client.DownloadStringAsync(latest_url);
                //client.DownloadFileAsync(latest_url, @"C:\Users\brandon\Desktop\grinders\latest");
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
        }



        //form buttons
        private void btn_checkUpdate_Click(object sender, EventArgs e)
        {
            btn_checkUpdate.Text = "Checking...";
            btn_checkUpdate.Enabled = false;

            //new thread
            Thread update = new Thread(checkForUpdate);
            update.Start();
        }
    }
}
