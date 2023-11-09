using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Download : Form
    {
        public Download()
        {
            InitializeComponent();
        }

        private string downloadHTML(string url)
        {
            try
            {
                string path = pathBox.Text;
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        client.DownloadFile(new Uri(url), @path);
                    }
                    catch (Exception ex)
                    {
                        while (ex != null)
                        {
                            pathBox.Text = ex.Message;
                            ex = ex.InnerException;
                        }
                    }
                }
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();

                sr.Close();
                fs.Close();
                return content;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            richTextBox.Text = downloadHTML(urlBox.Text);
        }
    }
}
