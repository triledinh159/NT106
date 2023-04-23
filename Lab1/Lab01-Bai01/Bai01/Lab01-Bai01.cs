namespace Bai01
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void valuein1_TextChanged(object sender, EventArgs e)
        {

        }

        private void valuein2_TextChanged(object sender, EventArgs e)
        {

        }

        private void valuein3_TextChanged(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;
            //nếu valuein1 valuein2 valuein3 rỗng thì báo lỗi
            if (valuein1.Text == "" || valuein2.Text == "" || valuein3.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ 3 số");
            }
            //nếu valuein1 valuein2 valuein3 không phải số thì báo lỗi
            else if (!int.TryParse(valuein1.Text, out int n) || !int.TryParse(valuein2.Text, out int m) || !int.TryParse(valuein3.Text, out int l))
            {
                MessageBox.Show("Bạn phải nhập số nguyên");
            }
            //nếu valuein1 valuein2 valuein3 không phải số nguyên thì báo lỗi
            else if (int.Parse(valuein1.Text) % 1 != 0 || int.Parse(valuein2.Text) % 1 != 0 || int.Parse(valuein3.Text) % 1 != 0)
            {
                MessageBox.Show("Bạn phải nhập số nguyên");
            }
            else
            {
                val1 = int.Parse(valuein1.Text);
                val2 = int.Parse(valuein2.Text);
                val3 = int.Parse(valuein3.Text);
                int max = val1;
                int min = val1;
                if (val2 > max)
                {
                    max = val2;
                }
                if (val3 > max)
                {
                    max = val3;
                }
                if (val2 < min)
                {
                    min = val2;
                }
                if (val3 < min)
                {
                    min = val3;
                }
                maxprint.Text = max.ToString();
                minprint.Text = min.ToString();

            }


        }


        private void value1_Click(object sender, EventArgs e)
        {

        }

        private void value3_Click(object sender, EventArgs e)
        {

        }

        private void value2_Click(object sender, EventArgs e)
        {

        }
        private void maxprint_TextChanged(object sender, EventArgs e)
        {

        }

        private void minprint_TextChanged(object sender, EventArgs e)
        {

        }

        private void erase_Click(object sender, EventArgs e)
        {
            //xóa valuein1 valuein2, valuein3
            valuein1.Text = "";
            valuein2.Text = "";
            valuein3.Text = "";
            //xóa maxprint, minprint
            maxprint.Text = "";
            minprint.Text = "";

        }

        private void exit_Click(object sender, EventArgs e)
        {
            //thoát chương trình
            Application.Exit();
        }
    }
}