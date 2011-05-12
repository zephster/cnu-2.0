﻿using System;
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
        public main()
        {
            InitializeComponent();
        }

        private void checkForUpdate()
        {
            //retreives LATEST file. normal binary file. just get value.
            //set var with LATEST version
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

        public void updateCallback(object sender, DownloadStringCompletedEventArgs e)
        {
            string latest_version = e.Result;
            lbl_lastDownloaded.Text = latest_version;
            btn_checkUpdate.Enabled = true;
            btn_checkUpdate.Text = "Check for Update";
        }

        private void btn_checkUpdate_Click(object sender, EventArgs e)
        {
            //make this a changeable setting, in case google changes the url again.
            Uri latest_url = new Uri("http://build.chromium.org/f/chromium/snapshots/chromium-rel-xp/LATEST");
            WebClient client = new WebClient();

            btn_checkUpdate.Text = "Checking...";
            btn_checkUpdate.Enabled = false;

            try
            {
                client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(updateCallback);
                client.DownloadStringAsync(latest_url);
            } catch (Exception err){
                throw new Exception("Error checking for latest vesion, oh no!\n" + err.Message, err);
            }
        }
    }
}
