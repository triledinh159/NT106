using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Imap;
using MailKit.Security;
using MimeKit;
using System.Windows.Forms;
using MailKit;
using MailKit.Search;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05
{
    public partial class MailExchange : Form
    {
        public MailExchange()
        {
            InitializeComponent();
        }

        void receive_mail(string email, string password, string server)
        {
            using (ImapClient client = new ImapClient())
            {
                try
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect(server, 143, SecureSocketOptions.Auto);
                    client.Authenticate(email, password);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    var uids = client.Inbox.Search(SearchQuery.All);

                    foreach (var uid in uids)
                    {
                        var message = inbox.GetMessage(uid);
                        // Process the received message
                        string subject = message.Subject;
                        string from = message.From.ToString();
                        string body = message.HtmlBody;
                        string time = message.Date.DateTime.ToString();

                        // Display or store the received information as need
                        ListViewItem name = new ListViewItem(subject);
                        // From
                        ListViewItem.ListViewSubItem fromView = new ListViewItem.ListViewSubItem(name, from);
                        name.SubItems.Add(fromView);
                        // Message
                        ListViewItem.ListViewSubItem content = new ListViewItem.ListViewSubItem(name, body);
                        name.SubItems.Add(content);
                        // Date
                        ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, time);
                        name.SubItems.Add(date);
                        listView1.Items.Add(name);
                    }

                    client.Disconnect(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                Program.address = addressBox.Text;
                Program.password = passwordBox.Text;
                listView1.Columns.Add("Email", 200);
                listView1.Columns.Add("From", 300);
                listView1.Columns.Add("Content", 400);
                listView1.Columns.Add("Time", 200);
                listView1.View = View.Details;
                receive_mail(Program.address, Program.password, "127.0.0.1");
                buttonSend.Enabled = true;
                buttonLogin.Text = "Reload";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var sendForm = new SendMail();
            sendForm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
