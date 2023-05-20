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

namespace Lab03
{
    public partial class UDPclient : Form
    {
        public UDPclient()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            string message = richTextBox.Text;
            Byte[] sendBytes = Encoding.UTF8.GetBytes(message);
            udpClient.Send(sendBytes, sendBytes.Length, ipBox.Text, Int32.Parse(portBox.Text));
            richTextBox.Text = string.Empty;
        }
    }
}
