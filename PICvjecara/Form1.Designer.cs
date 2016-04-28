namespace PICvjecara
{
    partial class frmCvjecarna
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnEvidencija = new System.Windows.Forms.Button();
            this.btnNarudzba = new System.Windows.Forms.Button();
            this.btnArtikli = new System.Windows.Forms.Button();
            this.btnProdaja = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnSwitchUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKraj = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStatistika);
            this.groupBox1.Controls.Add(this.btnEvidencija);
            this.groupBox1.Controls.Add(this.btnNarudzba);
            this.groupBox1.Controls.Add(this.btnArtikli);
            this.groupBox1.Controls.Add(this.btnProdaja);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Location = new System.Drawing.Point(22, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije";
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(6, 244);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(249, 29);
            this.btnStatistika.TabIndex = 5;
            this.btnStatistika.Text = "Statistika poslvanja";
            this.btnStatistika.UseVisualStyleBackColor = true;
            // 
            // btnEvidencija
            // 
            this.btnEvidencija.Location = new System.Drawing.Point(6, 209);
            this.btnEvidencija.Name = "btnEvidencija";
            this.btnEvidencija.Size = new System.Drawing.Size(249, 29);
            this.btnEvidencija.TabIndex = 4;
            this.btnEvidencija.Text = "Evidencija zaposlenika";
            this.btnEvidencija.UseVisualStyleBackColor = true;
            // 
            // btnNarudzba
            // 
            this.btnNarudzba.Location = new System.Drawing.Point(6, 174);
            this.btnNarudzba.Name = "btnNarudzba";
            this.btnNarudzba.Size = new System.Drawing.Size(249, 29);
            this.btnNarudzba.TabIndex = 3;
            this.btnNarudzba.Text = "Narudžba";
            this.btnNarudzba.UseVisualStyleBackColor = true;
            // 
            // btnArtikli
            // 
            this.btnArtikli.Location = new System.Drawing.Point(6, 139);
            this.btnArtikli.Name = "btnArtikli";
            this.btnArtikli.Size = new System.Drawing.Size(249, 29);
            this.btnArtikli.TabIndex = 2;
            this.btnArtikli.Text = "Artikli";
            this.btnArtikli.UseVisualStyleBackColor = true;
            this.btnArtikli.Click += new System.EventHandler(this.btnArtikli_Click);
            // 
            // btnProdaja
            // 
            this.btnProdaja.Location = new System.Drawing.Point(6, 104);
            this.btnProdaja.Name = "btnProdaja";
            this.btnProdaja.Size = new System.Drawing.Size(249, 29);
            this.btnProdaja.TabIndex = 1;
            this.btnProdaja.Text = "Prodaja";
            this.btnProdaja.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(6, 19);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(249, 43);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNaslov.Location = new System.Drawing.Point(500, 22);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(194, 27);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "Cvjećarna Mak";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSwitchUser
            // 
            this.btnSwitchUser.Location = new System.Drawing.Point(843, 63);
            this.btnSwitchUser.Name = "btnSwitchUser";
            this.btnSwitchUser.Size = new System.Drawing.Size(102, 24);
            this.btnSwitchUser.TabIndex = 3;
            this.btnSwitchUser.Text = "Switch User";
            this.btnSwitchUser.UseVisualStyleBackColor = true;
            this.btnSwitchUser.Click += new System.EventHandler(this.btnSwitchUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(840, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korisnik:";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(893, 22);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(165, 13);
            this.lblKorisnik.TabIndex = 5;
            this.lblKorisnik.Text = "\"Ovdje ide trenutno aktivan user\"";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(320, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 425);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "\"Prikaz dodatnih gumbova il prometa nekog\"";
            // 
            // btnKraj
            // 
            this.btnKraj.Location = new System.Drawing.Point(998, 552);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(90, 35);
            this.btnKraj.TabIndex = 7;
            this.btnKraj.Text = "Kraj";
            this.btnKraj.UseVisualStyleBackColor = true;
            this.btnKraj.Click += new System.EventHandler(this.btnKraj_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::PICvjecara.Properties.Resources.logo;
            this.pbLogo.InitialImage = global::PICvjecara.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(977, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(123, 124);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // frmCvjecarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1100, 599);
            this.Controls.Add(this.btnKraj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSwitchUser);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCvjecarna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cvjećarna";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnSwitchUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnEvidencija;
        private System.Windows.Forms.Button btnNarudzba;
        private System.Windows.Forms.Button btnArtikli;
        private System.Windows.Forms.Button btnProdaja;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnKraj;
    }
}

