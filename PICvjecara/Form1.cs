﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICvjecara
{
    public partial class frmCvjecarna : Form
    {
        public frmCvjecarna()
        {
            InitializeComponent();
            ControlBox = false;
            //btnPrikazNarudzbi.Visible = false;
            //btnNarudzbenica.Visible = false;

            //prikazuje koji je korisnik aktivan
            label5.Text = Korisnici.TrenutnoAktivan;
            
            

           

        }

      

        private void btnKraj_Click(object sender, EventArgs e)
        {
            DatabaseConnection.Instance.Connection.Close();
            Environment.Exit(0);
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmPregledArtikla openPregledArtikla = new frmPregledArtikla();
            openPregledArtikla.MdiParent = this;
            openPregledArtikla.Show();

            
        }
        
        private void btnSwitchUser_Click(object sender, EventArgs e)
        {
            Prijava openPrijava = new Prijava();
            openPrijava.Show();
            Visible = false;
        }

        

        private void btnNarudzbenica_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            ListClass.listaDobavljaca.Clear();
            ListClass.listaArtikla.Clear();
            frmNarudzbenica frmNarudzbe = new frmNarudzbenica();
            frmNarudzbe.Show();
            this.Close();
        }


     

                    


        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            frmKlijenti frmKlijent = new frmKlijenti();
            frmKlijent.Show();
            this.Close();
        }

        private void btnKraj_Click_1(object sender, EventArgs e)
        {
            DatabaseConnection.Instance.Connection.Close();
            Environment.Exit(0);
        }

        private void frmCvjecarna_Load(object sender, EventArgs e)
        {

        }

        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmPregledNarudzbenica frmPregledNar = new frmPregledNarudzbenica();
            frmPregledNar.MdiParent = this;
            frmPregledNar.Show();
        }

        private void btnIzradiNarudzbenicu_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmNarudzbenica frmnarudzbenica = new frmNarudzbenica();
            frmnarudzbenica.MdiParent = this;
            frmnarudzbenica.Show();

        }
    }
}
