using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName,
            FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            showbox.Text = content;
            fs.Close();
        }

        private void showbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName,
            FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            string content = showbox.Text;
            sw.Write(content.ToLower());
            sw.Close();
            fs.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}