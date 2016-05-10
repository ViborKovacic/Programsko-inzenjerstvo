using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace PICvjecara
{
    public partial class frmSenaEmail : Form
    {
        //DBClass.Dobavljaci dobavljac;
        //public string korisnik = Korisnici.Email.ToString();
        //public string ime = Korisnici.Ime.ToString();
        //NetworkCredential login;
        //SmtpClient client;
        //MailMessage msg;
        //public string saljePutem="";
        //int port = 0;

        public frmSenaEmail()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';

            
            //btnSend.Enabled = false;
            
        }
        /*private void AktivirajOpcije()
        {
            if (txtPassword.Text != null && txtUsername.Text != null && comboBox1.SelectedIndex >-1)
            {
                btnSend.Enabled = true;
            }
            if (comboBox1.SelectedText == "Gmail")
            {
                saljePutem = "smtp.gmail.com";
                port = 587;
            }
            if (comboBox1.SelectedText == "Foi")
            {
                saljePutem = "mail.ht.hr";
                port = 25;
            }
        }*/

        private void btnSend_Click(object sender, EventArgs e)
        {
           // AktivirajOpcije();
            //text1.Text = saljePutem;
            //text2.Text = port.ToString();
            
            //login = new NetworkCredential(txtUsername.Text, txtPassword.Text);
            //client = new SmtpClient("mail.ht.hr");
            //client.Port = 25;
            //client.EnableSsl = true;
            //client.Credentials = login;
            //msg = new MailMessage { From = new MailAddress(korisnik, ime, Encoding.UTF8) };
            //msg.To.Add(new MailAddress(txtTo.Text));
            //msg.Subject = txtSub.Text;
            //msg.Body = textBox1.Text;
            //msg.BodyEncoding = Encoding.UTF8;
            //msg.IsBodyHtml = true;
            //msg.Priority = MailPriority.Normal;
            //msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            //client.SendCompleted += new SendCompletedEventHandler(SendComplatedCallback);
            //string userstate = "Slanje...";
            //client.SendAsync(msg, userstate);
            
        }
        private static void SendComplatedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
             {
                MessageBox.Show(string.Format("{0} Slanje prekinuto.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Poruka je uspješno poslana", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
