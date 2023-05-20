using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class TCPclient : Form
    {
        public TCPclient()
        {
            InitializeComponent();
        }

        private const int BUFFER_SIZE = 1024;
        static ASCIIEncoding encoding = new ASCIIEncoding();
        public TcpClient client;
        public Stream stream;
        public void ConnectServer()
        {
            try
            {
                client = new TcpClient();
                int PORT_NUMBER = Int32.Parse(portBox.Text);
                client.Connect(ipBox.Text, PORT_NUMBER);
                stream = client.GetStream();
                richTextBox.Text = string.Empty;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectServer();
            buttonConnect.Enabled = false;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            byte[] data = encoding.GetBytes(richTextBox.Text);
            stream.Write(data, 0, data.Length);
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Enabled)
            {
                buttonDisconnect.Enabled = false;
            }
            else
            {
                buttonConnect.Enabled = true;
                stream.Close();
                client.Close();
                buttonDisconnect.Enabled = false;
            }
        }
    }
}
