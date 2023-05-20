using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class UDPserver : Form
    {
        string currentString = string.Empty;
        public UDPserver()
        {
            InitializeComponent();
        }

        public void ServerThread()
        {
            UdpClient udpClient = new UdpClient(Int32.Parse(portBox.Text));
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string message = RemoteIpEndPoint.Address.ToString() + ": " + returnData.ToString() + "\n";
                currentString += message;
                richTextBox.Text = currentString;
            }
        }
        private void buttonListen_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "Server is listening ... \n";
            currentString = string.Empty;
            CheckForIllegalCrossThreadCalls = false;
            Thread UDPServerThread = new Thread(new ThreadStart(ServerThread));
            UDPServerThread.Start();
        }
    }
}
