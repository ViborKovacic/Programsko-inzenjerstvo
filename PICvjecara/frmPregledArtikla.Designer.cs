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
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvrstaartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vrstaartiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet1 = new PICvjecara._16027_DBDataSet();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet = new PICvjecara._16027_DBDataSet();
            this.artikliTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.ArtikliTableAdapter();
            this.vrsta_artiklaTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).BeginInit();
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
            this.iDartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.iDvrstaartiklaDataGridViewTextBoxColumn});
            this.artikliDataGridView.DataSource = this.artikliBindingSource;
            this.artikliDataGridView.Location = new System.Drawing.Point(239, 70);
            this.artikliDataGridView.Name = "artikliDataGridView";
            this.artikliDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.artikliDataGridView.Size = new System.Drawing.Size(544, 430);
            this.artikliDataGridView.TabIndex = 7;
            this.artikliDataGridView.SelectionChanged += new System.EventHandler(this.artikliDataGridView_SelectionChanged);
            // 
            // iDartiklaDataGridViewTextBoxColumn
            // 
            this.iDartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_artikla";
            this.iDartiklaDataGridViewTextBoxColumn.HeaderText = "Broj artikla";
            this.iDartiklaDataGridViewTextBoxColumn.Name = "iDartiklaDataGridViewTextBoxColumn";
            this.iDartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // iDvrstaartiklaDataGridViewTextBoxColumn
            // 
            this.iDvrstaartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.DataSource = this.vrstaartiklaBindingSource;
            this.iDvrstaartiklaDataGridViewTextBoxColumn.DisplayMember = "Vrsta";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDvrstaartiklaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.Name = "iDvrstaartiklaDataGridViewTextBoxColumn";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDvrstaartiklaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDvrstaartiklaDataGridViewTextBoxColumn.ValueMember = "ID_vrsta_artikla";
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
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // vrsta_artiklaTableAdapter
            // 
            this.vrsta_artiklaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledArtikla
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
            this.Name = "frmPregledArtikla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled artikla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PregledArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private _16027_DBDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private _16027_DBDataSet _16027_DBDataSet1;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource;
        private _16027_DBDataSetTableAdapters.Vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDvrstaartiklaDataGridViewTextBoxColumn;
    }
}