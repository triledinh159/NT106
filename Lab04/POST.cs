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
    public partial class POST : Form
    {
        public POST()
        {
            InitializeComponent();
        }

        private string postHTML(string url)
        {
            try
            {
                string postData = dataBox.Text;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                Uri target = new Uri(url);
                WebRequest request = WebRequest.Create(target);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;

                using (var dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    return content;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private void buttonPost_Click(object sender, EventArgs e)
        {
            richTextBox.Text = postHTML(urlBox.Text);
        }
    }
}
