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
    public partial class UDPdashboard : Form
    {
        public UDPdashboard()
        {
            InitializeComponent();
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            var server = new UDPserver();
            server.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            var client = new UDPclient();
            client.Show();
        }
    }
}
