using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [Serializable]
        public class HocVien
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string DienThoai { get; set; }
            public float DiemToan { get; set; }

            public float DiemVan { get; set; }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                using (FileStream fileStream = new FileStream(filename, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    HocVien hocvien = (HocVien)binaryFormatter.Deserialize(fileStream);
                    string[] lines = { hocvien.MSSV, hocvien.HoTen, hocvien.DienThoai, hocvien.DiemToan.ToString(), hocvien.DiemVan.ToString() };
                    showbox.Lines = lines;
                    /*                    sr.WriteLine(lines[1]);
                                        sr.WriteLine(lines[2]);
                                        sr.WriteLine(diem[0]);
                    */

                }

            }
        }



        private void btn_write_Click(object sender, EventArgs e)
        {
            string[] lines = showbox.Lines;
            if (lines.Length < 5)
            {
                MessageBox.Show("Input 5 Lines");
            }
            else
            {
                HocVien hocvien = new HocVien();
                hocvien.MSSV = lines[0];
                hocvien.HoTen = lines[1];
                hocvien.DienThoai = lines[2];
                hocvien.DiemVan = Convert.ToSingle(lines[3]);
                hocvien.DiemToan = Convert.ToSingle(lines[4]);
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filename = sfd.FileName;
                    using (FileStream fileStream = new FileStream(filename, FileMode.Create))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        binaryFormatter.Serialize(fileStream, hocvien);
                    }

                }
            }
            showbox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_dtb_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                using (FileStream fileStream = new FileStream(filename, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    HocVien hocvien = (HocVien)binaryFormatter.Deserialize(fileStream);
                    string[] lines = { hocvien.MSSV, hocvien.HoTen, hocvien.DienThoai };
                    float[] diem = { hocvien.DiemToan, hocvien.DiemVan, (hocvien.DiemToan + hocvien.DiemVan) / 2 };
                    StreamWriter sr = new StreamWriter("output.txt");
                    sr.WriteLine(lines[0]);
                    sr.WriteLine(lines[1]);
                    sr.WriteLine(lines[2]);
                    sr.WriteLine(diem[0]);
                    sr.WriteLine(diem[1]);
                    sr.WriteLine(diem[2]);
                    sr.Close();
                }
            }
        }

        private void btn_readdtb_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output.txt",
            FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            showbox.Text = content;
            fs.Close();

        }
    }
}
