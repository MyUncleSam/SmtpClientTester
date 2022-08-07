using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmtpClientTester
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            cbDeliveryNotify.DataSource = Enum.GetValues(typeof(DeliveryNotificationOptions));
            cbAuthType.DataSource = Enum.GetValues(typeof(AuthTypes));
        }

        /// <summary>
        /// try to send mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                // empty some fields
                tbResult.Text = "";
                tbMessageId.Text = "";
                tbMailTesterGuid.Text = "";

                // create connection
                SmtpClient sc = new SmtpClient();
                sc.Host = tbHost.Text;
                sc.Port = Convert.ToInt32(tbPort.Value);
                sc.EnableSsl = cbSsl.Checked;
                sc.Timeout = Convert.ToInt32(tbTimeout.Value) * 1000;

                // authentication
                AuthTypes at = (AuthTypes)cbAuthType.SelectedValue;
                switch (at)
                {
                    case AuthTypes.Credentials:
                        sc.Credentials = new System.Net.NetworkCredential(tbUsername.Text, tbPassword.Text);
                        break;
                    case AuthTypes.UseDefaultCredentials:
                        sc.UseDefaultCredentials = true;
                        break;
                    case AuthTypes.Anonymouse:
                        // nothing to be done
                        break;
                }

                // set reply to address
                MailAddress replyAddress = null;
                string replyMail = tbReplyMail.Text.Trim();
                string replyDisp = tbReplyDisp.Text.Trim();
                if(replyMail.Length > 0 && replyDisp.Length > 0)
                {
                    replyAddress = new MailAddress(replyMail, replyDisp);
                }
                else if(replyMail.Length > 0 && replyDisp.Length <= 0)
                {
                    replyAddress = new MailAddress(replyMail, replyMail);
                }

                // get to, cc and bcc list
                List<string> toList = getAllAddresses(tbTo.Text.Trim());
                List<string> ccList = getAllAddresses(tbCc.Text.Trim());
                List<string> bccList = getAllAddresses(tbBcc.Text.Trim());

                // generate message object
                MailMessage msg = new MailMessage();

                MailAddress fromAddress = null;
                if (tbFrom.Text.Trim().Length > 0)
                {
                    if (tbFromDisplay.Text.Trim().Length > 0)
                    {
                        fromAddress = new MailAddress(tbFrom.Text.Trim(), tbFromDisplay.Text.Trim());
                    }
                    else
                    {
                        fromAddress = new MailAddress(tbFrom.Text.Trim(), tbFrom.Text.Trim());
                    }
                }
                if(fromAddress != null)
                {
                    msg.From = fromAddress;
                }

                if (replyAddress != null)
                {
                    msg.Sender = replyAddress;
                    msg.ReplyToList.Add(replyAddress);
                }
                msg.Subject = tbSubject.Text.Trim();
                msg.Body = tbMessage.Text.Trim();
                msg.IsBodyHtml = false;

                // add an own message id?
                if(cbOwnMessageId.Checked)
                {
                    string msgGuid = string.Format("<{0}@{1}>", Guid.NewGuid().ToString(), tbHost.Text.Trim());
                    tbMessageId.Text = msgGuid;
                    msg.Headers.Add("Message-Id", msgGuid);
                }

                // add mailtester guid
                string loboMailSenderGuid = Guid.NewGuid().ToString();
                msg.Headers.Add("MailTester", loboMailSenderGuid);
                tbMailTesterGuid.Text = loboMailSenderGuid;

                // add to, cc and bcc
                foreach (string _to in toList)
                {
                    msg.To.Add(_to);
                }
                foreach (string _cc in ccList)
                {
                    msg.CC.Add(_cc);
                }
                foreach (string _bcc in bccList)
                {
                    msg.Bcc.Add(_bcc);
                }

                msg.DeliveryNotificationOptions = (DeliveryNotificationOptions)cbDeliveryNotify.SelectedValue;
                sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                sc.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error sending this mail - see result!", "Error sending mail", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tbResult.Text = ex.ToString();
            }
            finally
            {
                this.Enabled = true;
            }
        }

        /// <summary>
        /// types of authentication methods
        /// </summary>
        enum AuthTypes
        {
            Credentials = 0,
            UseDefaultCredentials = 1,
            Anonymouse = 2
        }

        /// <summary>
        /// only enable user credentials fields if authentication mode is "Credentials"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAuthType_SelectedValueChanged(object sender, EventArgs e)
        {
            if((AuthTypes)cbAuthType.SelectedValue == AuthTypes.Credentials)
            {
                tbUsername.Enabled = true;
                tbPassword.Enabled = true;
            }
            else
            {
                tbUsername.Enabled = false;
                tbPassword.Enabled = false;
            }
        }

        /// <summary>
        /// splits a mail string by ";" and returns it as list
        /// </summary>
        /// <param name="mails"></param>
        /// <returns></returns>
        public static List<string> getAllAddresses(string mails)
        {
            List<string> ret = new List<string>();

            string[] _mails = mails.Split(';');
            foreach (string mail in _mails)
            {
                if (mail.Trim().Length > 0)
                {
                    ret.Add(mail.Trim());
                }
            }

            return ret;
        }

        private void llGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("https://github.com/MyUncleSam/SmtpClientTester");
            Process.Start(psi);
        }
    }
}
