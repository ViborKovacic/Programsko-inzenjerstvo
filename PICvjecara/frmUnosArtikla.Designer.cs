namespace PICvjecara
{
    partial class frmUnosArtikla
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmboxTipArtikla = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this._16027_DBDataSet = new PICvjecara._16027_DBDataSet();
            this.vrstaartiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrsta_artiklaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip artikla:";
            // 
            // cmboxTipArtikla
            // 
            this.cmboxTipArtikla.DataSource = this.vrstaartiklaBindingSource;
            this.cmboxTipArtikla.DisplayMember = "Vrsta";
            this.cmboxTipArtikla.FormattingEnabled = true;
            this.cmboxTipArtikla.Location = new System.Drawing.Point(139, 77);
            this.cmboxTipArtikla.Name = "cmboxTipArtikla";
            this.cmboxTipArtikla.Size = new System.Drawing.Size(121, 21);
            this.cmboxTipArtikla.TabIndex = 1;
            this.cmboxTipArtikla.ValueMember = "ID_vrsta_artikla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Količina:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(139, 113);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 5;
            this.txtNaziv.Text = "Naziv artikla";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(139, 149);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(121, 20);
            this.txtCijena.TabIndex = 6;
            this.txtCijena.Text = "Unesite cijenu u kn";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(139, 185);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(121, 20);
            this.txtKolicina.TabIndex = 7;
            this.txtKolicina.Text = "Unesite količinu";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(35, 250);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(89, 53);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(199, 250);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(89, 53);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(238, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 33);
            this.btnPovratak.TabIndex = 10;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // _16027_DBDataSet
            // 
            this._16027_DBDataSet.DataSetName = "_16027_DBDataSet";
            this._16027_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vrstaartiklaBindingSource
            // 
            this.vrstaartiklaBindingSource.DataMember = "Vrsta_artikla";
            this.vrstaartiklaBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // vrsta_artiklaTableAdapter
            // 
            this.vrsta_artiklaTableAdapter.ClearBeforeFill = true;
            // 
            // frmUnosArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 341);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboxTipArtikla);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(400, 290);
            this.Name = "frmUnosArtikla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Unos artikla";
            this.Load += new System.EventHandler(this.UnosArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboxTipArtikla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPovratak;
        private _16027_DBDataSet _16027_DBDataSet;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource;
        private _16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter;
    }
}