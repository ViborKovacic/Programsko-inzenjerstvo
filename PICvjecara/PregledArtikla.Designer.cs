﻿namespace PICvjecara
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16027_DBDataSet = new PICvjecara._16027_DBDataSet();
            this.btnUnosNovogArtikla = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.artikliTableAdapter = new PICvjecara._16027_DBDataSetTableAdapters.ArtikliTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.artikliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artikliBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtBrisanjeArtikla = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 554);
            this.dataGridView1.TabIndex = 0;
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
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
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
            // txtBrisanjeArtikla
            // 
            this.txtBrisanjeArtikla.Location = new System.Drawing.Point(138, 443);
            this.txtBrisanjeArtikla.Name = "txtBrisanjeArtikla";
            this.txtBrisanjeArtikla.Size = new System.Drawing.Size(44, 20);
            this.txtBrisanjeArtikla.TabIndex = 7;
            // 
            // PregledArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 599);
            this.Controls.Add(this.txtBrisanjeArtikla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnUnosNovogArtikla);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PregledArtikla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled artikla";
            this.Load += new System.EventHandler(this.PregledArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16027_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}