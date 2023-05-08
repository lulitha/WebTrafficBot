using SetProxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Win32;
using System.Net;
using HtmlAgilityPack;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddUrls_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                listUrls.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listUrls.Items.Add(line);

                    }
                }
            }
        }

        private void btnAddProxy_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                listProxy.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listProxy.Items.Add(line);

                    }
                }
            }
        }

        private void btnAddUA_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                listUA.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listUA.Items.Add(line);

                    }
                }
            }
        }

        string _url;
        string _proxy;
       // string _Ua;

        private void btnStart_Click(object sender, EventArgs e)
        {


            int progress = 0;


            for (int i = 0; i < listProxy.Items.Count; i++)
            {
                List<string> items = new List<string>();
                Random rnd = new Random();
                
                items.Add(listUrls.Items[rnd.Next(listUrls.Items.Count)].ToString());
                items.Add(listProxy.Items[rnd.Next(listProxy.Items.Count)].ToString());
               // items.Add(listUA.Items[rnd.Next(listUA.Items.Count)].ToString());

                
                _url = items[0];
                _proxy = items[1];                
                SetProxyConnection(_proxy.Replace("\t", ""));// set proxy to the connection
               // _Ua = items[2];
                StartView(_url);// start first view

                lblProxy.Text = _proxy;
                lblUrl.Text = _url;
               // lblUA.Text = _Ua;
                frmCounter fmc = new frmCounter();
                fmc.ShowDialog();

                if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
                {
                   
                }

                progress++;
                progressBar1.Value = progress;
                // Stop any ongoing navigation and display a blank page
                webBrowser1.Stop();
                webBrowser1.Url = new Uri("about:blank");


            }

        }

        private void SetProxyConnection(string proxy)
        {

            try
            {
                WinInetInterop.SetConnectionProxy(proxy.Trim());
            }
            catch (Exception)
            {

                MessageBox.Show("Cannot Assign The Connection..!");
            }
           
        }

        private void StartView(string url) {
             webBrowser1.Navigate("about:blank");
           
            if (listUA.Items.Count==0)
            {
               // webBrowser1.Navigate(url, null, null, "User-Agent: " + ua);
                webBrowser1.Navigate(url);
            }
            else
            {
               // webBrowser1.Navigate(url, null, null, "User-Agent: " + ua);
            }
            
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmCounter fmcounter = new frmCounter();
            fmcounter.Close();
            // Set FEATURE_BROWSER_EMULATION registry key to use EdgeHTML rendering engine
            string appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
                              appName, 11001, RegistryValueKind.DWord);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string html = client.DownloadString("https://www.us-proxy.org/");

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                var rows = doc.DocumentNode.Descendants("tr").Skip(1);

                foreach (var row in rows)
                {
                    var cols = row.Descendants("td").ToList();

                    string ip = cols[0].InnerText.Trim();
                    string port = cols[1].InnerText.Trim();

                    // Add the IP address and port number to the ListBox control
                    listProxy.Items.Add(ip + ":" + port);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
