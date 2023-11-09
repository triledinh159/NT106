using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        void send_mail()
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailFrom = Program.address;
                string mailTo = addressBox.Text.ToString().Trim();
                string password = Program.password;
                var basicCredential = new NetworkCredential(mailFrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailFrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = subjectBox.Text.ToString().Trim();
                    message.IsBodyHtml = true;
                    message.Body = richTextBox.Text.ToString();
                    message.To.Add(mailTo);
                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            send_mail();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
