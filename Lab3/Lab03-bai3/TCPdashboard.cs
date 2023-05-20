using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class TCPdashboard : Form
    {
        public TCPdashboard()
        {
            InitializeComponent();
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            var server = new TCPserver();
            server.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            var client = new TCPclient();
            client.Show();
        }
    }
}
