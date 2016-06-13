namespace PICvjecara
{
    partial class frmRezerviranjeKorisnici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.grbKupci = new System.Windows.Forms.GroupBox();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.grbKupac = new System.Windows.Forms.GroupBox();
            this.btnKupacPromjene = new System.Windows.Forms.Button();
            this.btnUnesiKupca = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.grbKupci.SuspendLayout();
            this.grbKupac.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi OIB Kupca:";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(114, 29);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(131, 20);
            this.txtOIB.TabIndex = 1;
            // 
            // grbKupci
            // 
            this.grbKupci.Controls.Add(this.btnRezerviraj);
            this.grbKupci.Controls.Add(this.grbKupac);
            this.grbKupci.Controls.Add(this.btnPretrazi);
            this.grbKupci.Controls.Add(this.label1);
            this.grbKupci.Controls.Add(this.txtOIB);
            this.grbKupci.Location = new System.Drawing.Point(12, 12);
            this.grbKupci.Name = "grbKupci";
            this.grbKupci.Size = new System.Drawing.Size(364, 374);
            this.grbKupci.TabIndex = 2;
            this.grbKupci.TabStop = false;
            this.grbKupci.Text = "Podaci o Kupcu";
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(234, 317);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(106, 43);
            this.btnRezerviraj.TabIndex = 4;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // grbKupac
            // 
            this.grbKupac.Controls.Add(this.btnKupacPromjene);
            this.grbKupac.Controls.Add(this.btnUnesiKupca);
            this.grbKupac.Controls.Add(this.txtTelefon);
            this.grbKupac.Controls.Add(this.txtEmail);
            this.grbKupac.Controls.Add(this.txtAdresa);
            this.grbKupac.Controls.Add(this.txtPrezime);
            this.grbKupac.Controls.Add(this.txtIme);
            this.grbKupac.Controls.Add(this.label6);
            this.grbKupac.Controls.Add(this.label5);
            this.grbKupac.Controls.Add(this.label4);
            this.grbKupac.Controls.Add(this.label3);
            this.grbKupac.Controls.Add(this.label2);
            this.grbKupac.Location = new System.Drawing.Point(19, 78);
            this.grbKupac.Name = "grbKupac";
            this.grbKupac.Size = new System.Drawing.Size(232, 209);
            this.grbKupac.TabIndex = 3;
            this.grbKupac.TabStop = false;
            this.grbKupac.Text = "Kupac";
            // 
            // btnKupacPromjene
            // 
            this.btnKupacPromjene.Location = new System.Drawing.Point(6, 180);
            this.btnKupacPromjene.Name = "btnKupacPromjene";
            this.btnKupacPromjene.Size = new System.Drawing.Size(102, 23);
            this.btnKupacPromjene.TabIndex = 11;
            this.btnKupacPromjene.Text = "Unesi Promjene";
            this.btnKupacPromjene.UseVisualStyleBackColor = true;
            this.btnKupacPromjene.Click += new System.EventHandler(this.btnKupacPromjene_Click);
            // 
            // btnUnesiKupca
            // 
            this.btnUnesiKupca.Location = new System.Drawing.Point(124, 180);
            this.btnUnesiKupca.Name = "btnUnesiKupca";
            this.btnUnesiKupca.Size = new System.Drawing.Size(102, 23);
            this.btnUnesiKupca.TabIndex = 10;
            this.btnUnesiKupca.Text = "Unesi Klijenta";
            this.btnUnesiKupca.UseVisualStyleBackColor = true;
            this.btnUnesiKupca.Click += new System.EventHandler(this.btnUnesiKupca_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(68, 131);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(68, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(68, 76);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 7;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(68, 50);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 6;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(68, 23);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ime:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(265, 27);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretraži!";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(296, 442);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(80, 32);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmRezerviranjeKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(393, 486);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.grbKupci);
            this.Name = "frmRezerviranjeKorisnici";
            this.Text = "frmRezerviranjeKorisnici";
            this.Load += new System.EventHandler(this.frmRezerviranjeKorisnici_Load);
            this.grbKupci.ResumeLayout(false);
            this.grbKupci.PerformLayout();
            this.grbKupac.ResumeLayout(false);
            this.grbKupac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.GroupBox grbKupci;
        private System.Windows.Forms.GroupBox grbKupac;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnUnesiKupca;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Button btnKupacPromjene;
    }
}