namespace PICvjecara
{
    partial class frmPregledArtikla
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
            this.artikliDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vrstaartiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet1 = new PICvjecara._16027_DBDataSet();
            this.narucenakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblPutanjaSlike = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.lblSlika = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliTableAdapter1 = new PICvjecara._16027_DBDataSetTableAdapters.ArtikliTableAdapter();
            this.vrsta_artiklaTableAdapter1 = new PICvjecara._16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnosNovogArtikla
            // 
            this.btnUnosNovogArtikla.Location = new System.Drawing.Point(25, 182);
            this.btnUnosNovogArtikla.Name = "btnUnosNovogArtikla";
            this.btnUnosNovogArtikla.Size = new System.Drawing.Size(157, 73);
            this.btnUnosNovogArtikla.TabIndex = 2;
            this.btnUnosNovogArtikla.Text = "Unos novog artikla";
            this.btnUnosNovogArtikla.UseVisualStyleBackColor = true;
            this.btnUnosNovogArtikla.Click += new System.EventHandler(this.btnUnosNovogArtikla_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(25, 290);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(157, 72);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "Uredi artikle";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.FlatAppearance.BorderSize = 4;
            this.btnPovratak.Location = new System.Drawing.Point(1067, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(96, 32);
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
            this.txtBrisanjeArtikla.ReadOnly = true;
            this.txtBrisanjeArtikla.Size = new System.Drawing.Size(44, 20);
            this.txtBrisanjeArtikla.TabIndex = 7;
            // 
            // artikliDataGridView
            // 
            this.artikliDataGridView.AllowUserToAddRows = false;
            this.artikliDataGridView.AutoGenerateColumns = false;
            this.artikliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artikliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.narucenakolicinaDataGridViewTextBoxColumn});
            this.artikliDataGridView.DataSource = this.artikliBindingSource;
            this.artikliDataGridView.Location = new System.Drawing.Point(607, 226);
            this.artikliDataGridView.Name = "artikliDataGridView";
            this.artikliDataGridView.ReadOnly = true;
            this.artikliDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.artikliDataGridView.Size = new System.Drawing.Size(556, 336);
            this.artikliDataGridView.TabIndex = 7;
            this.artikliDataGridView.SelectionChanged += new System.EventHandler(this.artikliDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_artikla";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_artikla";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cijena";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cijena";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kolicina";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_vrsta_artikla";
            this.dataGridViewTextBoxColumn5.DataSource = this.vrstaartiklaBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Vrsta";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.HeaderText = "Kategorija";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "ID_vrsta_artikla";
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
            // narucenakolicinaDataGridViewTextBoxColumn
            // 
            this.narucenakolicinaDataGridViewTextBoxColumn.DataPropertyName = "Narucena_kolicina";
            this.narucenakolicinaDataGridViewTextBoxColumn.HeaderText = "Narucena_kolicina";
            this.narucenakolicinaDataGridViewTextBoxColumn.Name = "narucenakolicinaDataGridViewTextBoxColumn";
            this.narucenakolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.narucenakolicinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this._16027_DBDataSet1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnSpremi);
            this.groupBox1.Controls.Add(this.lblPutanjaSlike);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtVrsta);
            this.groupBox1.Controls.Add(this.lblSlika);
            this.groupBox1.Controls.Add(this.lblNaziv);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 137);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos kategorije";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(278, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(296, 108);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblPutanjaSlike
            // 
            this.lblPutanjaSlike.AutoSize = true;
            this.lblPutanjaSlike.Location = new System.Drawing.Point(241, 76);
            this.lblPutanjaSlike.Name = "lblPutanjaSlike";
            this.lblPutanjaSlike.Size = new System.Drawing.Size(0, 13);
            this.lblPutanjaSlike.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(128, 71);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(128, 39);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(100, 20);
            this.txtVrsta.TabIndex = 2;
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Location = new System.Drawing.Point(25, 76);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(33, 13);
            this.lblSlika.TabIndex = 1;
            this.lblSlika.Text = "Slika:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(25, 42);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(86, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv kategorije:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.vrstaartiklaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(901, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(262, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_vrsta_artikla";
            this.dataGridViewTextBoxColumn6.HeaderText = "Broj kategorije";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Vrsta";
            this.dataGridViewTextBoxColumn7.HeaderText = "Kategorija";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Url";
            this.dataGridViewTextBoxColumn8.HeaderText = "Url";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // artikliTableAdapter1
            // 
            this.artikliTableAdapter1.ClearBeforeFill = true;
            // 
            // vrsta_artiklaTableAdapter1
            // 
            this.vrsta_artiklaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPregledArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 599);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.artikliDataGridView);
            this.Controls.Add(this.txtBrisanjeArtikla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnUnosNovogArtikla);
            this.Name = "frmPregledArtikla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled artikla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PregledArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUnosNovogArtikla;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrisanjeArtikla;
        private System.Windows.Forms.DataGridView artikliDataGridView;
        private _16027_DBDataSet _16027_DBDataSet;
        private _16027_DBDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPutanjaSlike;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDvrstaartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvrstaartiklaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private _16027_DBDataSet _16027_DBDataSet1;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private _16027_DBDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter1;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource;
        private _16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn narucenakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}