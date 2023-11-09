using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;
using System.Threading;

namespace Server_RC
{
    public partial class RemoteDesktop : Form
    {

        private readonly TcpClient client = new TcpClient();
        private NetworkStream mainStream;
        private int portNumber;

        private static Image grabDesktop()
        {
            Rectangle bound = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bound.Width, bound.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(screenshot);
            graphics.CopyFromScreen(bound.X, bound.Y, 0, 0, bound.Size, CopyPixelOperation.SourceCopy);
            return screenshot;
        }

        private void SendDesktopImage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            mainStream = client.GetStream();
            binFormatter.Serialize(mainStream, grabDesktop());
        }
        public RemoteDesktop()
        {

            InitializeComponent();
        }



        private void RemoteDesktop_Load(object sender, EventArgs e)
        {


        }

        private void btn_cnt_Click(object sender, EventArgs e)
        {
            portNumber = int.Parse(port_ins.Text);
            try
            {
                client.Connect(ip_ins.Text, portNumber);
                MessageBox.Show("Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ip_ins_TextChanged(object sender, EventArgs e)
        {

        }

        private void port_ins_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            new screenServer(int.Parse(port_ins.Text)).Show();
        }

        private void btn_share_Click(object sender, EventArgs e)
        {
            if (btn_share.Text == "Share")
            {
                timer1.Start();
                btn_share.Text = "Stop";
            }
            else if (btn_share.Text == "Stop")
            {
                timer1.Stop();
                btn_share.Text = "Share";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDesktopImage();
        }
    }
}

