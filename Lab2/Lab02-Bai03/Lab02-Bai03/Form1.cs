using System.Text.RegularExpressions;
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
        static string Convert(string input)
        {
            string pattern = @"\s*([\+\-\*/])\s*";
            string output = Regex.Replace(input, pattern, " $1 ");

            return output;
        }
        private void btn_write_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName,
            FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            string content = showbox.Text;
            string[] statements = content.Split('\n');
            foreach (string statement in statements)
            {
                string tmp = statement;
                tmp = Convert(statement);
                string[] ch = tmp.Split(' ');
                if (ch.Length == 3)
                {
                    if (int.TryParse(ch[0], out int num1) && (int.TryParse(ch[2], out int num2)))
                    {
                        int result = 0;
                        string sym = ch[1];
                        if (sym == "–")
                        {
                            sym = "-";
                        }
                        switch (sym)
                        {
                            case "+":
                                result = num1 + num2;
                                break;
                            case "-":
                                result = num1 - num2;
                                break;
                            case "*":
                                result = num1 * num2;
                                break;
                            case "/":
                                result = num1 / num2;
                                break;
                            default:
                                sw.WriteLine("Invalid operator {sym}");
                                continue;
                        }
                        sw.WriteLine($"{num1} {sym} {num2} = {result}");
                    }
                    else
                    {
                        sw.WriteLine("Invalid statement {statement}");
                    }
                }
                else if (ch.Length == 2)
                {
                    sw.WriteLine("Invalid statement {statement}");
                }
            }


            //sw.Write(content.ToLower());
            sw.Close();
            fs.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}