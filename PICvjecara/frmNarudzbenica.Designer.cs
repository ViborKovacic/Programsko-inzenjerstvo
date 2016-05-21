namespace PICvjecara
{
    partial class frmNarudzbenica
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
            this.components = new System.ComponentModel.Container();
            this.grpBoxNovi = new System.Windows.Forms.GroupBox();
            this.btnIzradiNalogNovi = new System.Windows.Forms.Button();
            this.txtKolicinaNovog = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProizvod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVrstaArtikla = new System.Windows.Forms.TextBox();
            this.txtDobavljac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.grpBoxPostojeci = new System.Windows.Forms.GroupBox();
            this.btnIzradinalogPostojeci = new System.Windows.Forms.Button();
            this.txtKolicinaPostojeci = new System.Windows.Forms.TextBox();
            this.cmbNazivArtikla = new System.Windows.Forms.ComboBox();
            this.cmbVrstaArtikla = new System.Windows.Forms.ComboBox();
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dobavljaciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPostojeciArtikl = new System.Windows.Forms.Button();
            this.btnNoviArtikli = new System.Windows.Forms.Button();
            this.txtNaruceniArtikli = new System.Windows.Forms.TextBox();
            this.grpBoxZavrseno = new System.Windows.Forms.GroupBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.fKNarudzbenicaDobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.NarudzbenicaTableAdapter();
            this.vrstaartiklaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblcontrol = new System.Windows.Forms.Label();
            this.grpBoxNovi.SuspendLayout();
            this.grpBoxPostojeci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource1)).BeginInit();
            this.grpBoxZavrseno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKNarudzbenicaDobavljaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxNovi
            // 
            this.grpBoxNovi.Controls.Add(this.btnIzradiNalogNovi);
            this.grpBoxNovi.Controls.Add(this.txtKolicinaNovog);
            this.grpBoxNovi.Controls.Add(this.label7);
            this.grpBoxNovi.Controls.Add(this.txtTelefon);
            this.grpBoxNovi.Controls.Add(this.txtOIB);
            this.grpBoxNovi.Controls.Add(this.txtAdresa);
            this.grpBoxNovi.Controls.Add(this.label6);
            this.grpBoxNovi.Controls.Add(this.label5);
            this.grpBoxNovi.Controls.Add(this.label4);
            this.grpBoxNovi.Controls.Add(this.txtProizvod);
            this.grpBoxNovi.Controls.Add(this.label3);
            this.grpBoxNovi.Controls.Add(this.txtVrstaArtikla);
            this.grpBoxNovi.Controls.Add(this.txtDobavljac);
            this.grpBoxNovi.Controls.Add(this.label2);
            this.grpBoxNovi.Controls.Add(this.label1);
            this.grpBoxNovi.Location = new System.Drawing.Point(681, 79);
            this.grpBoxNovi.Name = "grpBoxNovi";
            this.grpBoxNovi.Size = new System.Drawing.Size(317, 362);
            this.grpBoxNovi.TabIndex = 0;
            this.grpBoxNovi.TabStop = false;
            this.grpBoxNovi.Text = "Novi Proizvodi";
            // 
            // btnIzradiNalogNovi
            // 
            this.btnIzradiNalogNovi.Location = new System.Drawing.Point(178, 296);
            this.btnIzradiNalogNovi.Name = "btnIzradiNalogNovi";
            this.btnIzradiNalogNovi.Size = new System.Drawing.Size(123, 51);
            this.btnIzradiNalogNovi.TabIndex = 21;
            this.btnIzradiNalogNovi.Text = "Izradi narudžbenicu";
            this.btnIzradiNalogNovi.UseVisualStyleBackColor = true;
            // 
            // txtKolicinaNovog
            // 
            this.txtKolicinaNovog.Location = new System.Drawing.Point(98, 245);
            this.txtKolicinaNovog.Name = "txtKolicinaNovog";
            this.txtKolicinaNovog.Size = new System.Drawing.Size(51, 20);
            this.txtKolicinaNovog.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Količina:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(98, 127);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(165, 20);
            this.txtTelefon.TabIndex = 12;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(99, 98);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(165, 20);
            this.txtOIB.TabIndex = 11;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(99, 69);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(165, 20);
            this.txtAdresa.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "OIB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresa:";
            // 
            // txtProizvod
            // 
            this.txtProizvod.Location = new System.Drawing.Point(98, 212);
            this.txtProizvod.Name = "txtProizvod";
            this.txtProizvod.Size = new System.Drawing.Size(165, 20);
            this.txtProizvod.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Naziv Proizvoda:";
            // 
            // txtVrstaArtikla
            // 
            this.txtVrstaArtikla.Location = new System.Drawing.Point(99, 178);
            this.txtVrstaArtikla.Name = "txtVrstaArtikla";
            this.txtVrstaArtikla.Size = new System.Drawing.Size(165, 20);
            this.txtVrstaArtikla.TabIndex = 4;
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Location = new System.Drawing.Point(99, 41);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(165, 20);
            this.txtDobavljac.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta Artikla:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobavljač:";
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(920, 574);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(104, 38);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // grpBoxPostojeci
            // 
            this.grpBoxPostojeci.Controls.Add(this.btnIzradinalogPostojeci);
            this.grpBoxPostojeci.Controls.Add(this.txtKolicinaPostojeci);
            this.grpBoxPostojeci.Controls.Add(this.cmbNazivArtikla);
            this.grpBoxPostojeci.Controls.Add(this.cmbVrstaArtikla);
            this.grpBoxPostojeci.Controls.Add(this.cmbDobavljac);
            this.grpBoxPostojeci.Controls.Add(this.label11);
            this.grpBoxPostojeci.Controls.Add(this.label10);
            this.grpBoxPostojeci.Controls.Add(this.label9);
            this.grpBoxPostojeci.Controls.Add(this.label8);
            this.grpBoxPostojeci.Location = new System.Drawing.Point(35, 79);
            this.grpBoxPostojeci.Name = "grpBoxPostojeci";
            this.grpBoxPostojeci.Size = new System.Drawing.Size(282, 246);
            this.grpBoxPostojeci.TabIndex = 2;
            this.grpBoxPostojeci.TabStop = false;
            this.grpBoxPostojeci.Text = "Postojeći proizvodi";
            // 
            // btnIzradinalogPostojeci
            // 
            this.btnIzradinalogPostojeci.Location = new System.Drawing.Point(144, 181);
            this.btnIzradinalogPostojeci.Name = "btnIzradinalogPostojeci";
            this.btnIzradinalogPostojeci.Size = new System.Drawing.Size(123, 51);
            this.btnIzradinalogPostojeci.TabIndex = 20;
            this.btnIzradinalogPostojeci.Text = "Izradi narudžbenicu";
            this.btnIzradinalogPostojeci.UseVisualStyleBackColor = true;
            this.btnIzradinalogPostojeci.Click += new System.EventHandler(this.btnIzradinalogPostojeci_Click);
            // 
            // txtKolicinaPostojeci
            // 
            this.txtKolicinaPostojeci.Location = new System.Drawing.Point(99, 117);
            this.txtKolicinaPostojeci.Name = "txtKolicinaPostojeci";
            this.txtKolicinaPostojeci.Size = new System.Drawing.Size(52, 20);
            this.txtKolicinaPostojeci.TabIndex = 19;
            // 
            // cmbNazivArtikla
            // 
            this.cmbNazivArtikla.FormattingEnabled = true;
            this.cmbNazivArtikla.Location = new System.Drawing.Point(99, 88);
            this.cmbNazivArtikla.Name = "cmbNazivArtikla";
            this.cmbNazivArtikla.Size = new System.Drawing.Size(156, 21);
            this.cmbNazivArtikla.TabIndex = 18;
            this.cmbNazivArtikla.SelectedIndexChanged += new System.EventHandler(this.cmbNazivArtikla_SelectedIndexChanged);
            // 
            // cmbVrstaArtikla
            // 
            this.cmbVrstaArtikla.FormattingEnabled = true;
            this.cmbVrstaArtikla.Location = new System.Drawing.Point(99, 59);
            this.cmbVrstaArtikla.Name = "cmbVrstaArtikla";
            this.cmbVrstaArtikla.Size = new System.Drawing.Size(156, 21);
            this.cmbVrstaArtikla.TabIndex = 17;
            this.cmbVrstaArtikla.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaArtikla_SelectedIndexChanged);
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Location = new System.Drawing.Point(99, 27);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(156, 21);
            this.cmbDobavljac.TabIndex = 16;
            this.cmbDobavljac.SelectedIndexChanged += new System.EventHandler(this.cmbDobavljac_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Količina:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Naziv Proizvoda:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Vrsta Artikla:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dobavljač:";
            // 
            // btnPostojeciArtikl
            // 
            this.btnPostojeciArtikl.Location = new System.Drawing.Point(35, 24);
            this.btnPostojeciArtikl.Name = "btnPostojeciArtikl";
            this.btnPostojeciArtikl.Size = new System.Drawing.Size(114, 36);
            this.btnPostojeciArtikl.TabIndex = 3;
            this.btnPostojeciArtikl.Text = "Postojeći artikli";
            this.btnPostojeciArtikl.UseVisualStyleBackColor = true;
            this.btnPostojeciArtikl.Click += new System.EventHandler(this.btnPostojeciArtikl_Click);
            // 
            // btnNoviArtikli
            // 
            this.btnNoviArtikli.Location = new System.Drawing.Point(179, 24);
            this.btnNoviArtikli.Name = "btnNoviArtikli";
            this.btnNoviArtikli.Size = new System.Drawing.Size(111, 36);
            this.btnNoviArtikli.TabIndex = 4;
            this.btnNoviArtikli.Text = "Novi artikli";
            this.btnNoviArtikli.UseVisualStyleBackColor = true;
            this.btnNoviArtikli.Click += new System.EventHandler(this.btnNoviArtikli_Click);
            // 
            // txtNaruceniArtikli
            // 
            this.txtNaruceniArtikli.Location = new System.Drawing.Point(0, 19);
            this.txtNaruceniArtikli.Multiline = true;
            this.txtNaruceniArtikli.Name = "txtNaruceniArtikli";
            this.txtNaruceniArtikli.Size = new System.Drawing.Size(319, 235);
            this.txtNaruceniArtikli.TabIndex = 5;
            // 
            // grpBoxZavrseno
            // 
            this.grpBoxZavrseno.Controls.Add(this.btnPDF);
            this.grpBoxZavrseno.Controls.Add(this.btnEmail);
            this.grpBoxZavrseno.Controls.Add(this.txtNaruceniArtikli);
            this.grpBoxZavrseno.Location = new System.Drawing.Point(333, 79);
            this.grpBoxZavrseno.Name = "grpBoxZavrseno";
            this.grpBoxZavrseno.Size = new System.Drawing.Size(319, 373);
            this.grpBoxZavrseno.TabIndex = 6;
            this.grpBoxZavrseno.TabStop = false;
            this.grpBoxZavrseno.Text = "Popis naručenih artikla";
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(39, 287);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(99, 51);
            this.btnPDF.TabIndex = 7;
            this.btnPDF.Text = "Kreiraj PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(195, 287);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(99, 51);
            this.btnEmail.TabIndex = 6;
            this.btnEmail.Text = "Posalji Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // narudzbenicaTableAdapter
            // 
            this.narudzbenicaTableAdapter.ClearBeforeFill = true;
            // 
            // lblcontrol
            // 
            this.lblcontrol.AutoSize = true;
            this.lblcontrol.Location = new System.Drawing.Point(84, 366);
            this.lblcontrol.Name = "lblcontrol";
            this.lblcontrol.Size = new System.Drawing.Size(50, 13);
            this.lblcontrol.TabIndex = 7;
            this.lblcontrol.Text = "lblControl";
            // 
            // frmNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1036, 624);
            this.Controls.Add(this.lblcontrol);
            this.Controls.Add(this.grpBoxZavrseno);
            this.Controls.Add(this.btnNoviArtikli);
            this.Controls.Add(this.btnPostojeciArtikl);
            this.Controls.Add(this.grpBoxPostojeci);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.grpBoxNovi);
            this.Name = "frmNarudzbenica";
            this.Text = "Izrada Narudžbenice";
            this.Load += new System.EventHandler(this.frmNarudzbenica_Load);
            this.grpBoxNovi.ResumeLayout(false);
            this.grpBoxNovi.PerformLayout();
            this.grpBoxPostojeci.ResumeLayout(false);
            this.grpBoxPostojeci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource1)).EndInit();
            this.grpBoxZavrseno.ResumeLayout(false);
            this.grpBoxZavrseno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKNarudzbenicaDobavljaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxNovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProizvod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVrstaArtikla;
        private System.Windows.Forms.TextBox txtDobavljac;
        private System.Windows.Forms.TextBox txtKolicinaNovog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBoxPostojeci;
        private System.Windows.Forms.TextBox txtKolicinaPostojeci;
        private System.Windows.Forms.ComboBox cmbNazivArtikla;
        private System.Windows.Forms.ComboBox cmbVrstaArtikla;
        private System.Windows.Forms.ComboBox cmbDobavljac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPostojeciArtikl;
        private System.Windows.Forms.Button btnNoviArtikli;
        private System.Windows.Forms.Button btnIzradiNalogNovi;
        private System.Windows.Forms.Button btnIzradinalogPostojeci;
        private System.Windows.Forms.TextBox txtNaruceniArtikli;
        private System.Windows.Forms.GroupBox grpBoxZavrseno;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.BindingSource fKNarudzbenicaDobavljaciBindingSource;
        private _16027_DBDataSetTableAdapters.NarudzbenicaTableAdapter narudzbenicaTableAdapter;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource1;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource1;
        private System.Windows.Forms.Label lblcontrol;
    }
}