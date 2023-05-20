using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab03
{
    public partial class Telnet : Form
    {
        string currentString = string.Empty;
        public Telnet()
        {
            InitializeComponent();
        }

        public void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];

            Socket clientSocket;

            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );

            IPEndPoint ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Int32.Parse(portBox.Text));
            listenerSocket.Bind(ipServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();
            if (clientSocket.Connected)
            {
                richTextBox.Text += "New client connected \n";
                while (true)
                {
                    bytesReceived = clientSocket.Receive(recv);
                    currentString += Encoding.ASCII.GetString(recv);
                    richTextBox.Text = currentString;
                    if (!clientSocket.Connected)
                    {
                        break;
                    }
                }     
            }
            listenerSocket.Close();
        }

        private void StartListen()
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread ServerThread = new Thread(new ThreadStart(StartUnsafeThread));
            ServerThread.Start();
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            currentString = string.Empty;
            richTextBox.Text = "Server is listening ... \n";
            StartListen();
        }
    }
}
