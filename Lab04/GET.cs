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
    public partial class GET : Form
    {
        public GET()
        {
            InitializeComponent();
        }

        private string getHTML(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return content;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private void buttonGet_Click(object sender, EventArgs e)
        {
            richTextBox.Text = getHTML(urlBox.Text);
        }
    }
}
