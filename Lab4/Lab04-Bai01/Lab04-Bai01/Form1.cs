using System.Net;

namespace Lab04_Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}