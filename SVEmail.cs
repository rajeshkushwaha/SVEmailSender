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
                    OleDbCommand oleDbCommand = new OleDbCommand("select * from [Sheet2$]", dbConnection);
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
            using (EmailHelper emailHelper = new EmailHelper())
            {
                emailHelper.fromemail = tbFromEmailId.Text;
                emailHelper.password = tbPassword.Text;
                emailHelper.smtpaddress = tbSMTPAddress.Text;
                emailHelper.port = Convert.ToInt32(tbSMTPPort.Text);
                emailHelper.isssl = chkSSL.Checked;

                var val = dataGridView1.DataSource;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    emailHelper.toemail = Convert.ToString(row.Cells["To Email"].Value);
                    emailHelper.body = Convert.ToString(row.Cells["Body"].Value);
                    emailHelper.subject = Convert.ToString(row.Cells["Subject"].Value);

                    if (!string.IsNullOrWhiteSpace(emailHelper.toemail))
                    {
                        this.sendMail(emailHelper);
                    }
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
                mail.Body = emailHelper.body;
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
