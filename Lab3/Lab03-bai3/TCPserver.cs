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

namespace Lab03
{
    public partial class TCPserver : Form
    {
        public TCPserver()
        {
            InitializeComponent();
        }

        private const int BUFFER_SIZE = 1024;
        static ASCIIEncoding encoding = new ASCIIEncoding();
        public void ServerThread()
        {   
            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1");
                int PORT_NUMBER = Int32.Parse(portBox.Text);

                TcpListener listener = new TcpListener(address, PORT_NUMBER);

                listener.Start();

                richTextBox.Text = string.Empty;
                richTextBox.Text += "Server started on " + listener.LocalEndpoint + "\n";
                richTextBox.Text += "Waiting for a connection... \n";

                Socket socket = listener.AcceptSocket();
                richTextBox.Text += "Connection received from " + socket.RemoteEndPoint + "\n";

                byte[] data = new byte[BUFFER_SIZE];
                socket.Receive(data);

                string messsage = socket.RemoteEndPoint + ": " + encoding.GetString(data) + "\n";
                richTextBox.Text += messsage;

                socket.Close();
                listener.Stop();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "Server is listening ... \n";
            CheckForIllegalCrossThreadCalls = false;
            Thread TCPServerThread = new Thread(new ThreadStart(ServerThread));
            TCPServerThread.Start();
        }
    }
}
