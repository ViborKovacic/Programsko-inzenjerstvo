namespace PICvjecara
{
    partial class frmProdaja
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvPopisArtikla = new System.Windows.Forms.DataGridView();
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvrstaartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vrstaartiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet1 = new PICvjecara._16027_DBDataSet();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet = new PICvjecara._16027_DBDataSet();
            this.txtBrojArtikla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.stavkeracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.artikliTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.ArtikliTableAdapter();
            this.stavke_racunaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.Stavke_racunaTableAdapter();
            this.vrsta_artiklaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisniciTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.KorisniciTableAdapter();
            this.iDstavkeracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDnalogzaprodajuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDartikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeracunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 555);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dgvPopisArtikla
            // 
            this.dgvPopisArtikla.AllowUserToAddRows = false;
            this.dgvPopisArtikla.AutoGenerateColumns = false;
            this.dgvPopisArtikla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPopisArtikla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPopisArtikla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPopisArtikla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.iDvrstaartiklaDataGridViewTextBoxColumn});
            this.dgvPopisArtikla.DataSource = this.artikliBindingSource;
            this.dgvPopisArtikla.Location = new System.Drawing.Point(14, 13);
            this.dgvPopisArtikla.Name = "dgvPopisArtikla";
            this.dgvPopisArtikla.ReadOnly = true;
            this.dgvPopisArtikla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisArtikla.Size = new System.Drawing.Size(383, 321);
            this.dgvPopisArtikla.TabIndex = 1;
            // 
            // iDartiklaDataGridViewTextBoxColumn
            // 
            this.iDartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_artikla";
            this.iDartiklaDataGridViewTextBoxColumn.HeaderText = "Broj Artikla";
            this.iDartiklaDataGridViewTextBoxColumn.Name = "iDartiklaDataGridViewTextBoxColumn";
            this.iDartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDartiklaDataGridViewTextBoxColumn.Width = 82;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 59;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaDataGridViewTextBoxColumn.Width = 61;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 69;
            // 
            // iDvrstaartiklaDataGridViewTextBoxColumn
            // 
            this.iDvrstaartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.DataSource = this.vrstaartiklaBindingSource;
            this.iDvrstaartiklaDataGridViewTextBoxColumn.DisplayMember = "Vrsta";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDvrstaartiklaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.Name = "iDvrstaartiklaDataGridViewTextBoxColumn";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDvrstaartiklaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDvrstaartiklaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDvrstaartiklaDataGridViewTextBoxColumn.ValueMember = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.Width = 56;
            // 
            // vrstaartiklaBindingSource
            // 
            this.vrstaartiklaBindingSource.DataMember = "Vrsta_artikla";
            this.vrstaartiklaBindingSource.DataSource = this._16027_DBDataSet1;
            // 
            // _16027_DBDataSet1
            // 
            this._16027_DBDataSet1.DataSetName = "_16027_DBDataSet";
            this._16027_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // _16027_DBDataSet
            // 
            this._16027_DBDataSet.DataSetName = "_16027_DBDataSet";
            this._16027_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBrojArtikla
            // 
            this.txtBrojArtikla.Location = new System.Drawing.Point(90, 13);
            this.txtBrojArtikla.Name = "txtBrojArtikla";
            this.txtBrojArtikla.Size = new System.Drawing.Size(100, 20);
            this.txtBrojArtikla.TabIndex = 2;
            this.txtBrojArtikla.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj artikla:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(13, 48);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 4;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.Location = new System.Drawing.Point(90, 45);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(100, 20);
            this.txtNazivArtikla.TabIndex = 5;
            this.txtNazivArtikla.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgvPopisArtikla);
            this.panel4.Location = new System.Drawing.Point(746, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 349);
            this.panel4.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txtBrojArtikla);
            this.panel6.Controls.Add(this.txtNazivArtikla);
            this.panel6.Controls.Add(this.lblNaziv);
            this.panel6.Location = new System.Drawing.Point(499, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 79);
            this.panel6.TabIndex = 7;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(595, 302);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(115, 51);
            this.btnBrisi.TabIndex = 9;
            this.btnBrisi.Text = "Obrisi";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(443, 302);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(115, 51);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.AutoGenerateColumns = false;
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstavkeracunaDataGridViewTextBoxColumn,
            this.iDnalogzaprodajuDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.datumDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn,
            this.iDartikliDataGridViewTextBoxColumn,
            this.iDkorisnikaDataGridViewTextBoxColumn});
            this.dgvStavkeRacuna.DataSource = this.stavkeracunaBindingSource;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(404, 373);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.ReadOnly = true;
            this.dgvStavkeRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(752, 194);
            this.dgvStavkeRacuna.TabIndex = 11;
            // 
            // stavkeracunaBindingSource
            // 
            this.stavkeracunaBindingSource.DataMember = "Stavke_racuna";
            this.stavkeracunaBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // stavke_racunaTableAdapter
            // 
            this.stavke_racunaTableAdapter.ClearBeforeFill = true;
            // 
            // vrsta_artiklaTableAdapter
            // 
            this.vrsta_artiklaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataMember = "Korisnici";
            this.korisniciBindingSource.DataSource = this._16027_DBDataSet1;
            // 
            // korisniciTableAdapter
            // 
            this.korisniciTableAdapter.ClearBeforeFill = true;
            // 
            // iDstavkeracunaDataGridViewTextBoxColumn
            // 
            this.iDstavkeracunaDataGridViewTextBoxColumn.DataPropertyName = "ID_stavke_racuna";
            this.iDstavkeracunaDataGridViewTextBoxColumn.HeaderText = "ID_stavke_racuna";
            this.iDstavkeracunaDataGridViewTextBoxColumn.Name = "iDstavkeracunaDataGridViewTextBoxColumn";
            this.iDstavkeracunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDnalogzaprodajuDataGridViewTextBoxColumn
            // 
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.DataPropertyName = "ID_nalog_za_prodaju";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.HeaderText = "ID_nalog_za_prodaju";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.Name = "iDnalogzaprodajuDataGridViewTextBoxColumn";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            this.kolicinaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "Iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "Iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            this.iznosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDartikliDataGridViewTextBoxColumn
            // 
            this.iDartikliDataGridViewTextBoxColumn.DataPropertyName = "ID_artikli";
            this.iDartikliDataGridViewTextBoxColumn.HeaderText = "Broj artikla";
            this.iDartikliDataGridViewTextBoxColumn.Name = "iDartikliDataGridViewTextBoxColumn";
            this.iDartikliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDkorisnikaDataGridViewTextBoxColumn
            // 
            this.iDkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "ID_korisnika";
            this.iDkorisnikaDataGridViewTextBoxColumn.DataSource = this.korisniciBindingSource;
            this.iDkorisnikaDataGridViewTextBoxColumn.DisplayMember = "ime";
            this.iDkorisnikaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDkorisnikaDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.iDkorisnikaDataGridViewTextBoxColumn.Name = "iDkorisnikaDataGridViewTextBoxColumn";
            this.iDkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDkorisnikaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDkorisnikaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDkorisnikaDataGridViewTextBoxColumn.ValueMember = "ID_korisnik";
            // 
            // frmProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 657);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmProdaja";
            this.Text = "frmProdaja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProdaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeracunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvPopisArtikla;
        private System.Windows.Forms.TextBox txtBrojArtikla;
        private System.Windows.Forms.Label label1;
        private _16027_DBDataSet _16027_DBDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private _16027_DBDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.BindingSource stavkeracunaBindingSource;
        private _16027_DBDataSetTableAdapters.Stavke_racunaTableAdapter stavke_racunaTableAdapter;
        private System.Windows.Forms.Button button1;
        private _16027_DBDataSet _16027_DBDataSet1;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource;
        private _16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDvrstaartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private _16027_DBDataSetTableAdapters.KorisniciTableAdapter korisniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstavkeracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnalogzaprodajuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDkorisnikaDataGridViewTextBoxColumn;
    }
}