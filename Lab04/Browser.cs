using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Lab04
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser.Navigate(urlBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void fetchData(string url, string filePath)
        {
            WebClient myclient = new WebClient();
            myclient.DownloadFile(url, filePath);
        }

        public void downloadWebsite(string basePath, string htmlPath, string destination)
        {
            string url = urlBox.Text.Remove(urlBox.Text.Length - 1, 1);
            string[] position = new string[100];
            int index = 0;

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.OptionReadEncoding = true;

            StreamReader streamReader = new StreamReader(basePath, Encoding.UTF8, true);
            document.Load(streamReader.BaseStream, Encoding.UTF8);

            foreach (HtmlNode link in document.DocumentNode.SelectNodes("//img"))
            {
                index++;
                string data = link.GetAttributeValue("src", "") + "\n";

                if (!data.StartsWith("http") || !data.StartsWith("https"))
                    data = url + data;
                position[index] = string.Empty;

                if (data.Contains(".png"))
                    position[index] = destination + "\\img\\" + index.ToString() + ".png";

                else if (data.Contains(".jpg"))
                    position[index] = destination + "\\img\\" + index.ToString() + ".jpg";

                else if (data.Contains(".gif"))
                    position[index] = destination + "\\img\\" + index.ToString() + ".gif";

                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(new Uri(data), position[index]);
                    }
                } 
                catch (Exception) 
                {
                       
                }
                
            }

            index = 0;

            foreach (HtmlNode node in document.DocumentNode.SelectNodes("//img[@src]"))
            {
                index++;
                node.SetAttributeValue("src", position[index]);
            }
            document.Save(htmlPath, Encoding.UTF8);
            
        }
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                fetchData(urlBox.Text, pathBox.Text + "\\base.html");

                downloadWebsite(
                    pathBox.Text + "\\base.html",
                    pathBox.Text + "\\index.html",
                    pathBox.Text);

                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
