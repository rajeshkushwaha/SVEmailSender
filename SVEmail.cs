using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace SVEmailSender
{
    public partial class SVEmail : Form
    {
        public SVEmail()
        {
            InitializeComponent();
        }

        private void btnFileSelector_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() {ValidateNames=true })
            {
                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    this.tbFilePath.Text = openFileDialog.FileName;
                    string ConStr = "PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0; HDR=yes'";
                    OleDbConnection dbConnection = new OleDbConnection(ConStr);
                    OleDbCommand oleDbCommand = new OleDbCommand("select * from [Sheet1$]", dbConnection);
                    dbConnection.Open();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(oleDbCommand.ExecuteReader());
                    dataGridView1.DataSource = dataTable;
                }
            }           
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            string email = string.Empty;
            string body = string.Empty;

            if (string.IsNullOrWhiteSpace(tbFromEmailId.Text))
            {
                ErrorMessageShow("E-mail required.", "SVEmail");
                tbFromEmailId.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                ErrorMessageShow("Password required.", "SVEmail");
                tbPassword.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(tbSMTPAddress.Text))
            {
                ErrorMessageShow("SMTP Address required.", "SVEmail");
                tbSMTPAddress.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(tbSMTPPort.Text))
            {
                ErrorMessageShow("SMTP Port required.", "SVEmail");
                tbSMTPPort.Focus();
                return;
            }

            using (EmailHelper emailHelper = new EmailHelper())
            {
                emailHelper.fromemail = tbFromEmailId.Text;
                emailHelper.password = tbPassword.Text;
                emailHelper.smtpaddress = tbSMTPAddress.Text;
                emailHelper.port = Convert.ToInt32(tbSMTPPort.Text);
                emailHelper.isssl = chkSSL.Checked;

                var val = dataGridView1.DataSource;

                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        try
                        {
                            emailHelper.toemail = Convert.ToString(row.Cells["To"].Value);
                            emailHelper.body = Convert.ToString(row.Cells["Body"].Value);
                            emailHelper.subject = Convert.ToString(row.Cells["Subject"].Value);
                            emailHelper.cc = Convert.ToString(row.Cells["CC"].Value);
                            emailHelper.bcc = Convert.ToString(row.Cells["BCC"].Value);
                            emailHelper.signature = Convert.ToString(row.Cells["Signature"].Value);
                            emailHelper.attachment = Convert.ToString(row.Cells["FilePath"].Value);

                            if (!string.IsNullOrWhiteSpace(emailHelper.toemail))
                            {
                                this.sendMail(emailHelper);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "SVEmail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    ErrorMessageShow("No Record found", "SVEmail");
                    return;
                }
            }
        }

        private void sendMail(EmailHelper emailHelper)
        {
            try
            {
                MailMessage mail = new MailMessage(emailHelper.fromemail, emailHelper.toemail);
                SmtpClient client = new SmtpClient(emailHelper.smtpaddress, emailHelper.port)
                {
                    Credentials = new NetworkCredential(emailHelper.fromemail, emailHelper.password),
                    EnableSsl = emailHelper.isssl
                };
                mail.Subject = emailHelper.subject;
                //mail.Bcc = emailHelper.bcc;
                //mail.CC = emailHelper.cc;
                mail.Body = emailHelper.body + "\r\n\r\n" + emailHelper.signature;
                mail.Attachments.Add(new Attachment(emailHelper.attachment));
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SVEmail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tbSMTPPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbFromEmailId_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;

            if (tbFromEmailId.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!mRegxExpression.IsMatch(tbFromEmailId.Text.Trim()))
                {
                    ErrorMessageShow("E-mail address format is not correct.", "SVEmail");
                    tbFromEmailId.Focus();
                }
            }
        }

        private void tbFromEmailId_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFromEmailId.Text))
            {
                ErrorMessageShow("Email required", "SVEmail");
                tbFromEmailId.Focus();
            }            
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                ErrorMessageShow("Password required", "SVEmail");
                tbPassword.Focus();
            }
        }

        private void tbSMTPAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSMTPAddress.Text))
            {
                ErrorMessageShow("SMTP Address required", "SVEmail");
                tbSMTPAddress.Focus();
            }
        }

        private void tbSMTPPort_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSMTPPort.Text))
            {
                ErrorMessageShow("SMTP Port required", "SVEmail");
                tbSMTPPort.Focus();
            }
        }

        private void ErrorMessageShow(string errorMessage, string caption)
        {
            MessageBox.Show(errorMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
