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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vrstaartiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet1 = new PICvjecara._16027_DBDataSet();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet = new PICvjecara._16027_DBDataSet();
            this.txtBrojArtikla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.iDstavkeracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDnalogzaprodajuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDartikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkeracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGotovo = new System.Windows.Forms.Button();
            this.artikliTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.ArtikliTableAdapter();
            this.stavke_racunaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.Stavke_racunaTableAdapter();
            this.vrsta_artiklaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter();
            this.korisniciTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.KorisniciTableAdapter();
            this.OcistiRacun = new System.Windows.Forms.Button();
            this.dgvPopisArtikla = new System.Windows.Forms.DataGridView();
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvrstaartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblKn = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrRacuna = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeracunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikla)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txtBrojArtikla);
            this.panel6.Controls.Add(this.txtNazivArtikla);
            this.panel6.Controls.Add(this.lblNaziv);
            this.panel6.Location = new System.Drawing.Point(12, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 79);
            this.panel6.TabIndex = 7;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(57, 312);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(115, 51);
            this.btnBrisi.TabIndex = 9;
            this.btnBrisi.Text = "Obriši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(57, 226);
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
            this.dgvStavkeRacuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeRacuna.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStavkeRacuna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstavkeracunaDataGridViewTextBoxColumn,
            this.iDnalogzaprodajuDataGridViewTextBoxColumn,
            this.iDartikliDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.datumDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn,
            this.iDkorisnikaDataGridViewTextBoxColumn});
            this.dgvStavkeRacuna.DataSource = this.stavkeracunaBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStavkeRacuna.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(12, 15);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.ReadOnly = true;
            this.dgvStavkeRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(845, 255);
            this.dgvStavkeRacuna.TabIndex = 11;
            // 
            // iDstavkeracunaDataGridViewTextBoxColumn
            // 
            this.iDstavkeracunaDataGridViewTextBoxColumn.DataPropertyName = "ID_stavke_racuna";
            this.iDstavkeracunaDataGridViewTextBoxColumn.HeaderText = "Broj stavke";
            this.iDstavkeracunaDataGridViewTextBoxColumn.Name = "iDstavkeracunaDataGridViewTextBoxColumn";
            this.iDstavkeracunaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDstavkeracunaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDnalogzaprodajuDataGridViewTextBoxColumn
            // 
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.DataPropertyName = "ID_nalog_za_prodaju";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.HeaderText = "ID_nalog_za_prodaju";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.Name = "iDnalogzaprodajuDataGridViewTextBoxColumn";
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDnalogzaprodajuDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDartikliDataGridViewTextBoxColumn
            // 
            this.iDartikliDataGridViewTextBoxColumn.DataPropertyName = "ID_artikli";
            this.iDartikliDataGridViewTextBoxColumn.HeaderText = "Broj artikla";
            this.iDartikliDataGridViewTextBoxColumn.Name = "iDartikliDataGridViewTextBoxColumn";
            this.iDartikliDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.iznosDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            this.iznosDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.iDkorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataMember = "Korisnici";
            this.korisniciBindingSource.DataSource = this._16027_DBDataSet1;
            // 
            // stavkeracunaBindingSource
            // 
            this.stavkeracunaBindingSource.DataMember = "Stavke_racuna";
            this.stavkeracunaBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // btnGotovo
            // 
            this.btnGotovo.Location = new System.Drawing.Point(977, 550);
            this.btnGotovo.Name = "btnGotovo";
            this.btnGotovo.Size = new System.Drawing.Size(115, 57);
            this.btnGotovo.TabIndex = 12;
            this.btnGotovo.Text = "Naplati";
            this.btnGotovo.Click += new System.EventHandler(this.btnGotovo_Click_1);
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
            // korisniciTableAdapter
            // 
            this.korisniciTableAdapter.ClearBeforeFill = true;
            // 
            // OcistiRacun
            // 
            this.OcistiRacun.Location = new System.Drawing.Point(57, 393);
            this.OcistiRacun.Name = "OcistiRacun";
            this.OcistiRacun.Size = new System.Drawing.Size(115, 51);
            this.OcistiRacun.TabIndex = 13;
            this.OcistiRacun.Text = "Očisti račun";
            this.OcistiRacun.UseVisualStyleBackColor = true;
            this.OcistiRacun.Click += new System.EventHandler(this.OcistiRacun_Click_1);
            // 
            // dgvPopisArtikla
            // 
            this.dgvPopisArtikla.AllowUserToAddRows = false;
            this.dgvPopisArtikla.AutoGenerateColumns = false;
            this.dgvPopisArtikla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisArtikla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPopisArtikla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPopisArtikla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPopisArtikla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.iDvrstaartiklaDataGridViewTextBoxColumn});
            this.dgvPopisArtikla.DataSource = this.artikliBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPopisArtikla.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPopisArtikla.Location = new System.Drawing.Point(11, 16);
            this.dgvPopisArtikla.Name = "dgvPopisArtikla";
            this.dgvPopisArtikla.ReadOnly = true;
            this.dgvPopisArtikla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisArtikla.Size = new System.Drawing.Size(845, 210);
            this.dgvPopisArtikla.TabIndex = 1;
            // 
            // iDartiklaDataGridViewTextBoxColumn
            // 
            this.iDartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_artikla";
            this.iDartiklaDataGridViewTextBoxColumn.HeaderText = "Broj Artikla";
            this.iDartiklaDataGridViewTextBoxColumn.Name = "iDartiklaDataGridViewTextBoxColumn";
            this.iDartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgvPopisArtikla);
            this.panel4.Location = new System.Drawing.Point(234, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(870, 241);
            this.panel4.TabIndex = 6;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIznos.Location = new System.Drawing.Point(783, 570);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(84, 37);
            this.lblIznos.TabIndex = 14;
            this.lblIznos.Text = "0,00";
            // 
            // lblKn
            // 
            this.lblKn.AutoSize = true;
            this.lblKn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKn.Location = new System.Drawing.Point(873, 569);
            this.lblKn.Name = "lblKn";
            this.lblKn.Size = new System.Drawing.Size(53, 37);
            this.lblKn.TabIndex = 15;
            this.lblKn.Text = "kn";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupno.Location = new System.Drawing.Point(584, 569);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(144, 37);
            this.lblUkupno.TabIndex = 16;
            this.lblUkupno.Text = "Ukupno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Broj računa: ";
            // 
            // lblBrRacuna
            // 
            this.lblBrRacuna.AutoSize = true;
            this.lblBrRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrRacuna.Location = new System.Drawing.Point(172, 29);
            this.lblBrRacuna.Name = "lblBrRacuna";
            this.lblBrRacuna.Size = new System.Drawing.Size(0, 24);
            this.lblBrRacuna.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvStavkeRacuna);
            this.panel1.Location = new System.Drawing.Point(234, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 285);
            this.panel1.TabIndex = 19;
            // 
            // frmProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBrRacuna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.lblKn);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.OcistiRacun);
            this.Controls.Add(this.btnGotovo);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Name = "frmProdaja";
            this.Text = "frmProdaja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProdaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeracunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikla)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBrojArtikla;
        private System.Windows.Forms.Label label1;
        private _16027_DBDataSet _16027_DBDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private _16027_DBDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.BindingSource stavkeracunaBindingSource;
        private _16027_DBDataSetTableAdapters.Stavke_racunaTableAdapter stavke_racunaTableAdapter;
        private System.Windows.Forms.Button btnGotovo;
        private _16027_DBDataSet _16027_DBDataSet1;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource;
        private _16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private _16027_DBDataSetTableAdapters.KorisniciTableAdapter korisniciTableAdapter;
        private System.Windows.Forms.Button OcistiRacun;
        private System.Windows.Forms.DataGridView dgvPopisArtikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDvrstaartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstavkeracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnalogzaprodajuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblKn;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrRacuna;
        private System.Windows.Forms.Panel panel1;
    }
}