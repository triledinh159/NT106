using System.Net;


namespace Lab04_Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
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