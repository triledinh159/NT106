namespace WinFormsApp1
{
    public partial class Lab02Bai02 : Form
    {
        public Lab02Bai02()
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
            read_box.Text = content;
            name.Text = ofd.SafeFileName.ToString();
            url.Text = fs.Name.ToString();
            ctletter.Text = content.Length.ToString();
            //content = content.Replace("\r\n", "\r");
            ctline.Text = read_box.Lines.Count().ToString();
            content = content.Replace("\r\n", "\r");
            content = content.Replace('\r', ' ');
            string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';',
':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            ctword.Text = source.Count().ToString();
            fs.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab02Bai02_Load(object sender, EventArgs e)
        {

        }
    }
}