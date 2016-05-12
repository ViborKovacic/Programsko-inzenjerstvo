namespace PICvjecara
{
    partial class PregledArtikla
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
            this.btnUnosNovogArtikla = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrisanjeArtikla = new System.Windows.Forms.TextBox();
            this.fKArtikliVrstaartiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaartiklaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet = new PICvjecara._16027_DBDataSet();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.ArtikliTableAdapter();
            this.artikliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artikliBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new PICvjecara._16027_DBDataSetTableAdapters.TableAdapterManager();
            this.vrsta_artiklaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter();
            this.vrstaartiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet1 = new PICvjecara._16027_DBDataSet();
            this.artikliDataGridView = new System.Windows.Forms.DataGridView();
            this.artikliBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.artikliBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ID_artikla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fKArtikliVrstaartiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnosNovogArtikla
            // 
            this.btnUnosNovogArtikla.Location = new System.Drawing.Point(25, 70);
            this.btnUnosNovogArtikla.Name = "btnUnosNovogArtikla";
            this.btnUnosNovogArtikla.Size = new System.Drawing.Size(157, 73);
            this.btnUnosNovogArtikla.TabIndex = 2;
            this.btnUnosNovogArtikla.Text = "Unos novog artikla";
            this.btnUnosNovogArtikla.UseVisualStyleBackColor = true;
            this.btnUnosNovogArtikla.Click += new System.EventHandler(this.btnUnosNovogArtikla_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(25, 178);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(157, 72);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.FlatAppearance.BorderSize = 4;
            this.btnPovratak.Location = new System.Drawing.Point(888, 530);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(96, 45);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(25, 490);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(157, 72);
            this.btnBrisi.TabIndex = 5;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Broj artikla za brisanje";
            // 
            // txtBrisanjeArtikla
            // 
            this.txtBrisanjeArtikla.Location = new System.Drawing.Point(138, 443);
            this.txtBrisanjeArtikla.Name = "txtBrisanjeArtikla";
            this.txtBrisanjeArtikla.Size = new System.Drawing.Size(44, 20);
            this.txtBrisanjeArtikla.TabIndex = 7;
            // 
            // fKArtikliVrstaartiklaBindingSource
            // 
            this.fKArtikliVrstaartiklaBindingSource.DataMember = "FK_Artikli_Vrsta_artikla";
            this.fKArtikliVrstaartiklaBindingSource.DataSource = this.vrstaartiklaBindingSource;
            // 
            // vrstaartiklaBindingSource1
            // 
            this.vrstaartiklaBindingSource1.DataMember = "Vrsta_artikla";
            this.vrstaartiklaBindingSource1.DataSource = this._16027_DBDataSet;
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
            // artikliBindingSource1
            // 
            this.artikliBindingSource1.DataMember = "Artikli";
            this.artikliBindingSource1.DataSource = this._16027_DBDataSet;
            // 
            // artikliBindingSource2
            // 
            this.artikliBindingSource2.DataMember = "Artikli";
            this.artikliBindingSource2.DataSource = this._16027_DBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = this.artikliTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DobavljaciTableAdapter = null;
            this.tableAdapterManager.KorisniciTableAdapter = null;
            this.tableAdapterManager.KupciTableAdapter = null;
            this.tableAdapterManager.Nalog_za_prodajuTableAdapter = null;
            this.tableAdapterManager.NarudzbenicaTableAdapter = null;
            this.tableAdapterManager.RezervacijaTableAdapter = null;
            this.tableAdapterManager.Statistika_radaTableAdapter = null;
            this.tableAdapterManager.Stavke_narudzbeniceTableAdapter = null;
            this.tableAdapterManager.Stavke_racunaTableAdapter = null;
            this.tableAdapterManager.Stavke_rezervacijeTableAdapter = null;
            this.tableAdapterManager.Tip_korisnikaTableAdapter = null;
            this.tableAdapterManager.Tip_rezervacijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PICvjecara._16027_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vrsta_artiklaTableAdapter = this.vrsta_artiklaTableAdapter;
            // 
            // vrsta_artiklaTableAdapter
            // 
            this.vrsta_artiklaTableAdapter.ClearBeforeFill = true;
            // 
            // vrstaartiklaBindingSource
            // 
            this.vrstaartiklaBindingSource.DataMember = "Vrsta_artikla";
            this.vrstaartiklaBindingSource.DataSource = this._16027_DBDataSet;
            // 
            // _16027_DBDataSet1
            // 
            this._16027_DBDataSet1.DataSetName = "_16027_DBDataSet";
            this._16027_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliDataGridView
            // 
            this.artikliDataGridView.AllowUserToAddRows = false;
            this.artikliDataGridView.AutoGenerateColumns = false;
            this.artikliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artikliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_artikla,
            this.Naziv,
            this.Cijena,
            this.Kolicina,
            this.dataGridViewTextBoxColumn5});
            this.artikliDataGridView.DataSource = this.artikliBindingSource4;
            this.artikliDataGridView.Location = new System.Drawing.Point(239, 70);
            this.artikliDataGridView.Name = "artikliDataGridView";
            this.artikliDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.artikliDataGridView.Size = new System.Drawing.Size(544, 430);
            this.artikliDataGridView.TabIndex = 7;
            // 
            // artikliBindingSource3
            // 
            this.artikliBindingSource3.DataMember = "Artikli";
            this.artikliBindingSource3.DataSource = this._16027_DBDataSet1;
            // 
            // artikliBindingSource4
            // 
            this.artikliBindingSource4.DataMember = "Artikli";
            this.artikliBindingSource4.DataSource = this._16027_DBDataSet1;
            // 
            // ID_artikla
            // 
            this.ID_artikla.DataPropertyName = "ID_artikla";
            this.ID_artikla.HeaderText = "Broj artikla";
            this.ID_artikla.Name = "ID_artikla";
            this.ID_artikla.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_vrsta_artikla";
            this.dataGridViewTextBoxColumn5.DataSource = this.vrstaartiklaBindingSource1;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Vrsta";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.HeaderText = "Vrsta artikla";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "ID_vrsta_artikla";
            // 
            // PregledArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 599);
            this.Controls.Add(this.artikliDataGridView);
            this.Controls.Add(this.txtBrisanjeArtikla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnUnosNovogArtikla);
            this.Name = "PregledArtikla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled artikla";
            this.Load += new System.EventHandler(this.PregledArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKArtikliVrstaartiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUnosNovogArtikla;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnBrisi;
        private _16027_DBDataSet _16027_DBDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private _16027_DBDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource artikliBindingSource2;
        private System.Windows.Forms.BindingSource artikliBindingSource1;
        private System.Windows.Forms.TextBox txtBrisanjeArtikla;
        private _16027_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource1;
        private System.Windows.Forms.BindingSource fKArtikliVrstaartiklaBindingSource;
        private _16027_DBDataSet _16027_DBDataSet1;
        private System.Windows.Forms.DataGridView artikliDataGridView;
        private System.Windows.Forms.BindingSource artikliBindingSource3;
        private System.Windows.Forms.BindingSource artikliBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_artikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
    }
}