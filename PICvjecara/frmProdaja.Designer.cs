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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdaja));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCvijece = new System.Windows.Forms.Label();
            this.picCvijece = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBuketi = new System.Windows.Forms.Label();
            this.picBuketi = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAranzmani = new System.Windows.Forms.Label();
            this.picAranzmani = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSadnice = new System.Windows.Forms.Label();
            this.picSadnica = new System.Windows.Forms.PictureBox();
            this.dgvPopisArtikla = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvrstaartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vrstaartiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet = new PICvjecara._16027_DBDataSet();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.ArtikliTableAdapter();
            this.vrsta_artiklaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.stavkeracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_racunaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.Stavke_racunaTableAdapter();
            this.iDstavkeracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDartikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDnalogzaprodajuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCvijece)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuketi)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAranzmani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSadnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikla)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeracunaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 555);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCvijece);
            this.panel1.Controls.Add(this.picCvijece);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 189);
            this.panel1.TabIndex = 3;
            // 
            // lblCvijece
            // 
            this.lblCvijece.AutoSize = true;
            this.lblCvijece.Location = new System.Drawing.Point(38, 160);
            this.lblCvijece.Name = "lblCvijece";
            this.lblCvijece.Size = new System.Drawing.Size(42, 13);
            this.lblCvijece.TabIndex = 2;
            this.lblCvijece.Text = "Cvijeće";
            // 
            // picCvijece
            // 
            this.picCvijece.Image = global::PICvjecara.Properties.Resources.cvijece;
            this.picCvijece.Location = new System.Drawing.Point(3, 3);
            this.picCvijece.Name = "picCvijece";
            this.picCvijece.Size = new System.Drawing.Size(114, 139);
            this.picCvijece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCvijece.TabIndex = 1;
            this.picCvijece.TabStop = false;
            this.picCvijece.Click += new System.EventHandler(this.picCvijece_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBuketi);
            this.panel2.Controls.Add(this.picBuketi);
            this.panel2.Location = new System.Drawing.Point(131, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 189);
            this.panel2.TabIndex = 4;
            // 
            // lblBuketi
            // 
            this.lblBuketi.AutoSize = true;
            this.lblBuketi.Location = new System.Drawing.Point(41, 160);
            this.lblBuketi.Name = "lblBuketi";
            this.lblBuketi.Size = new System.Drawing.Size(37, 13);
            this.lblBuketi.TabIndex = 3;
            this.lblBuketi.Text = "Buketi";
            // 
            // picBuketi
            // 
            this.picBuketi.Image = global::PICvjecara.Properties.Resources.buketi;
            this.picBuketi.Location = new System.Drawing.Point(3, 3);
            this.picBuketi.Name = "picBuketi";
            this.picBuketi.Size = new System.Drawing.Size(114, 139);
            this.picBuketi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBuketi.TabIndex = 2;
            this.picBuketi.TabStop = false;
            this.picBuketi.Click += new System.EventHandler(this.picBuketi_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblAranzmani);
            this.panel3.Controls.Add(this.picAranzmani);
            this.panel3.Location = new System.Drawing.Point(259, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 189);
            this.panel3.TabIndex = 5;
            // 
            // lblAranzmani
            // 
            this.lblAranzmani.AutoSize = true;
            this.lblAranzmani.Location = new System.Drawing.Point(32, 160);
            this.lblAranzmani.Name = "lblAranzmani";
            this.lblAranzmani.Size = new System.Drawing.Size(56, 13);
            this.lblAranzmani.TabIndex = 4;
            this.lblAranzmani.Text = "Aranžmani";
            // 
            // picAranzmani
            // 
            this.picAranzmani.Image = global::PICvjecara.Properties.Resources.aranzmani;
            this.picAranzmani.Location = new System.Drawing.Point(3, 3);
            this.picAranzmani.Name = "picAranzmani";
            this.picAranzmani.Size = new System.Drawing.Size(114, 139);
            this.picAranzmani.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAranzmani.TabIndex = 2;
            this.picAranzmani.TabStop = false;
            this.picAranzmani.Click += new System.EventHandler(this.picAranzmani_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 0);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblSadnice);
            this.panel5.Controls.Add(this.picSadnica);
            this.panel5.Location = new System.Drawing.Point(3, 198);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(122, 189);
            this.panel5.TabIndex = 6;
            // 
            // lblSadnice
            // 
            this.lblSadnice.AutoSize = true;
            this.lblSadnice.Location = new System.Drawing.Point(38, 161);
            this.lblSadnice.Name = "lblSadnice";
            this.lblSadnice.Size = new System.Drawing.Size(46, 13);
            this.lblSadnice.TabIndex = 5;
            this.lblSadnice.Text = "Sadnice";
            // 
            // picSadnica
            // 
            this.picSadnica.Image = global::PICvjecara.Properties.Resources.sadnice;
            this.picSadnica.Location = new System.Drawing.Point(3, 3);
            this.picSadnica.Name = "picSadnica";
            this.picSadnica.Size = new System.Drawing.Size(116, 139);
            this.picSadnica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSadnica.TabIndex = 1;
            this.picSadnica.TabStop = false;
            this.picSadnica.Click += new System.EventHandler(this.picSadnica_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.textBox2);
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
            this.vrstaartiklaBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // _16027_DBDataSet
            // 
            this._16027_DBDataSet.DataSetName = "_16027_DBDataSet";
            this._16027_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // vrsta_artiklaTableAdapter
            // 
            this.vrsta_artiklaTableAdapter.ClearBeforeFill = true;
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.AutoGenerateColumns = false;
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstavkeracunaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.iznosDataGridViewTextBoxColumn,
            this.iDartikliDataGridViewTextBoxColumn,
            this.iDnalogzaprodajuDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn1,
            this.datumDataGridViewTextBoxColumn,
            this.iDkorisnikaDataGridViewTextBoxColumn});
            this.dgvStavkeRacuna.DataSource = this.stavkeracunaBindingSource;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(404, 373);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(752, 194);
            this.dgvStavkeRacuna.TabIndex = 11;
            // 
            // stavkeracunaBindingSource
            // 
            this.stavkeracunaBindingSource.DataMember = "Stavke_racuna";
            this.stavkeracunaBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // stavke_racunaTableAdapter
            // 
            this.stavke_racunaTableAdapter.ClearBeforeFill = true;
            // 
            // iDstavkeracunaDataGridViewTextBoxColumn
            // 
            this.iDstavkeracunaDataGridViewTextBoxColumn.DataPropertyName = "ID_stavke_racuna";
            this.iDstavkeracunaDataGridViewTextBoxColumn.HeaderText = "ID_stavke_racuna";
            this.iDstavkeracunaDataGridViewTextBoxColumn.Name = "iDstavkeracunaDataGridViewTextBoxColumn";
            this.iDstavkeracunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "Iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "Iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            // 
            // iDartikliDataGridViewTextBoxColumn
            // 
            this.iDartikliDataGridViewTextBoxColumn.DataPropertyName = "ID_artikli";
            this.iDartikliDataGridViewTextBoxColumn.HeaderText = "ID_artikli";
            this.iDartikliDataGridViewTextBoxColumn.Name = "iDartikliDataGridViewTextBoxColumn";
            // 
            // iDnalogzaprodajuDataGridViewTextBoxColumn
            // 
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.DataPropertyName = "ID_nalog_za_prodaju";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.HeaderText = "ID_nalog_za_prodaju";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.Name = "iDnalogzaprodajuDataGridViewTextBoxColumn";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // iDkorisnikaDataGridViewTextBoxColumn
            // 
            this.iDkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "ID_korisnika";
            this.iDkorisnikaDataGridViewTextBoxColumn.HeaderText = "ID_korisnika";
            this.iDkorisnikaDataGridViewTextBoxColumn.Name = "iDkorisnikaDataGridViewTextBoxColumn";
            // 
            // frmProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 657);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCvijece)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuketi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAranzmani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSadnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikla)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeracunaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCvijece;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBuketi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picAranzmani;
        private System.Windows.Forms.PictureBox picSadnica;
        private System.Windows.Forms.Label lblCvijece;
        private System.Windows.Forms.Label lblBuketi;
        private System.Windows.Forms.Label lblAranzmani;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblSadnice;
        private System.Windows.Forms.DataGridView dgvPopisArtikla;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private _16027_DBDataSet _16027_DBDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private _16027_DBDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource;
        private _16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDvrstaartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.BindingSource stavkeracunaBindingSource;
        private _16027_DBDataSetTableAdapters.Stavke_racunaTableAdapter stavke_racunaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstavkeracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnalogzaprodajuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkorisnikaDataGridViewTextBoxColumn;
    }
}