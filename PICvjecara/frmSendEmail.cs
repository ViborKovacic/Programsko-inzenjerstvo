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
    public partial class frmSendEmail : Form
    {
        Korisnici korisnici = new Korisnici();      
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        string saljePutem = "";
        int  port = 0;
       

        public frmSendEmail()
        {
            
            
            
            InitializeComponent();



    }
        private void AktivirajOpcije()
        {
            
            if (comboBox1.SelectedItem.ToString() == "Gmail")
            {
                saljePutem = "smtp.gmail.com";
                port = 587;


            }
            if (comboBox1.SelectedItem.ToString() == "Yahoo")
            {
                saljePutem = "smtp.mail.yahoo.com";
                port = 587;
            }
            if (comboBox1.SelectedItem.ToString() == "Live")
            {
                saljePutem = "smtp.live.com";
                port = 25;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string korisnik = korisnici.Email.ToString();
            string ime = korisnici.Ime.ToString();

            AktivirajOpcije();



            login = new NetworkCredential(txtUsername.Text, txtPassword.Text);
            client = new SmtpClient(saljePutem.ToString());
            client.Port = port;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(korisnik, ime, Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtTo.Text));
            msg.Subject = txtSub.Text;
            msg.Body = txtPoruka.Text;
            System.Net.Mail.Attachment datoteka;
            datoteka = new System.Net.Mail.Attachment(txtDatoteka.Text.ToString());
            msg.Attachments.Add(datoteka);
            msg.BodyEncoding = Encoding.UTF8;

            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendComplatedCallback);
            string userstate = "Slanje...";
            client.SendAsync(msg, userstate);

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

        private void frmSenaEmail_Load(object sender, EventArgs e)
        {
            

            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            
            txtPoruka.Text = "";
        
           



        }
        private void IspisZaSlanje(List<string> lista)
        {
           foreach (string s in lista)
            {
                txtPoruka.Text = s.ToString() + txtPoruka.Text + Environment.NewLine;
            }        
      
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDatoteka.Text = openFileDialog1.FileName;
            }
        }
    }
}
