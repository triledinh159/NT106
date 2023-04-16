namespace Lab01_Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nhap09_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            //lưu từng chữ số của số đã nhập vào mảng
            int[] a = new int[10];
            int n = int.Parse(kqnhap09.Text);
            int i = 0;
            while (n > 0)
            {
                a[i] = n % 10;
                n = n / 10;
                i++;
            }
        }

        private void kqnhap09_TextChanged(object sender, EventArgs e)
        {

        }


        private void read_Click(object sender, EventArgs e)
        {
            if (kqnhap09.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số");
            }
            
            else if (!int.TryParse(kqnhap09.Text, out int n))
            {
                MessageBox.Show("Bạn phải nhập số nguyên");
            }
            
            else if (int.Parse(kqnhap09.Text) % 1 != 0)
            {
                MessageBox.Show("Bạn phải nhập số nguyên");
            }
            else
            {
                string[] hangdonvi = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string[] hangdonvi2 = { "", "mốt", "hai", "ba", "tư", "lăm", "sáu", "bảy", "tám", "chín" };
                string[] hangchuc = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
                string[] hangnghin = { "", "nghìn", "triệu", "tỷ" };
                string result = "";
                long number = long.Parse(kqnhap09.Text);
                if (number == 0)
                {
                    result += "không";
                }

                int count = 0;
                long altnumber = number;
                int tramcount = 0;
                while (altnumber > 0)
                {
                    int baso = (int)(altnumber % 1000);
                    altnumber /= 1000;
                    int donvi = baso % 10;
                    int chuc = (baso % 100) / 10;
                    int tram = baso / 100;
                    tramcount++;
                }
                while (number > 0)
                {
                    tramcount--;
                    int baso = (int)(number % 1000);
                    number /= 1000;
                    int donvi = baso % 10;
                    int chuc = (baso % 100) / 10;
                    int tram = baso / 100;

                    string basoText = "";

                    if (tram > 0)
                    {
                        basoText += hangdonvi[tram] + " trăm ";
                    }
                    if (chuc == 0 && donvi > 0 && tram > 0)
                    {
                        basoText += "linh ";
                    }
                    if (chuc == 0 && donvi > 0 && tram == 0 && tramcount > 0)
                    {
                        basoText += "không trăm linh ";
                    }
                    if (chuc > 0 && donvi >= 0 && tram == 0 && tramcount > 0)
                    {
                        basoText += "không trăm ";
                    }


                    if (chuc > 1)
                    {
                        basoText += hangchuc[chuc] + " ";
                        if (donvi > 0)
                        {
                            basoText += hangdonvi2[donvi] + " ";
                        }
                    }
                    else if (chuc == 1)
                    {
                        basoText += "mười ";
                        if (donvi > 0)
                        {
                            basoText += hangdonvi[donvi] + " ";
                        }
                    }
                    else
                    {
                        if (donvi > 0)
                        {
                            basoText += hangdonvi[donvi] + " ";
                        }
                    }

                    if (baso > 0)
                    {
                        basoText += hangnghin[count] + " ";
                    }

                    result = basoText + result;

                    count++;
                }
                kqresult.Text = result;
            }
        }
        private void kqresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void erase_Click(object sender, EventArgs e)
        {
            kqnhap09.Text = string.Empty;
            kqresult.Text = string.Empty;
        }

        private void quit_Click(object sender, EventArgs e)
        {
            //thoát chương trình
            Application.Exit();
        }
    }
}