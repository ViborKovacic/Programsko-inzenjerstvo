namespace PICvjecara
{
    partial class frmNarudzbaArtikli
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
            this.btnOdaberiArtikl = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVrstaArtikla = new System.Windows.Forms.DataGridView();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.dgvOdabraniArtikli = new System.Windows.Forms.DataGridView();
            this.grbOdabirArtikla = new System.Windows.Forms.GroupBox();
            this.Broj_artikla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaArtikla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniArtikli)).BeginInit();
            this.grbOdabirArtikla.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOdaberiArtikl
            // 
            this.btnOdaberiArtikl.Location = new System.Drawing.Point(322, 289);
            this.btnOdaberiArtikl.Name = "btnOdaberiArtikl";
            this.btnOdaberiArtikl.Size = new System.Drawing.Size(84, 30);
            this.btnOdaberiArtikl.TabIndex = 8;
            this.btnOdaberiArtikl.Text = "Odaberi artikl";
            this.btnOdaberiArtikl.UseVisualStyleBackColor = true;
            this.btnOdaberiArtikl.Click += new System.EventHandler(this.btnOdaberiArtikl_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(699, 570);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(84, 30);
            this.btnPovratak.TabIndex = 7;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOdaberiArtikl);
            this.groupBox2.Controls.Add(this.dgvArtikli);
            this.groupBox2.Location = new System.Drawing.Point(377, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 325);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artikli";
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(21, 19);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(346, 223);
            this.dgvArtikli.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVrstaArtikla);
            this.groupBox1.Location = new System.Drawing.Point(50, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 325);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrste artikla";
            // 
            // dgvVrstaArtikla
            // 
            this.dgvVrstaArtikla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstaArtikla.Location = new System.Drawing.Point(21, 28);
            this.dgvVrstaArtikla.Name = "dgvVrstaArtikla";
            this.dgvVrstaArtikla.Size = new System.Drawing.Size(263, 214);
            this.dgvVrstaArtikla.TabIndex = 0;
            this.dgvVrstaArtikla.SelectionChanged += new System.EventHandler(this.dgvVrstaArtikla_SelectionChanged);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(609, 570);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(84, 30);
            this.btnBrisi.TabIndex = 9;
            this.btnBrisi.Text = "Brisi odabir";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // dgvOdabraniArtikli
            // 
            this.dgvOdabraniArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabraniArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Broj_artikla});
            this.dgvOdabraniArtikli.Location = new System.Drawing.Point(6, 19);
            this.dgvOdabraniArtikli.Name = "dgvOdabraniArtikli";
            this.dgvOdabraniArtikli.Size = new System.Drawing.Size(688, 150);
            this.dgvOdabraniArtikli.TabIndex = 8;
            // 
            // grbOdabirArtikla
            // 
            this.grbOdabirArtikla.Controls.Add(this.dgvOdabraniArtikli);
            this.grbOdabirArtikla.Location = new System.Drawing.Point(50, 379);
            this.grbOdabirArtikla.Name = "grbOdabirArtikla";
            this.grbOdabirArtikla.Size = new System.Drawing.Size(739, 185);
            this.grbOdabirArtikla.TabIndex = 10;
            this.grbOdabirArtikla.TabStop = false;
            this.grbOdabirArtikla.Text = "Odabrani artikli";
            // 
            // Broj_artikla
            // 
            this.Broj_artikla.HeaderText = "Broj artikla";
            this.Broj_artikla.Name = "Broj_artikla";
            // 
            // frmNarudzbaArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(831, 612);
            this.Controls.Add(this.grbOdabirArtikla);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNarudzbaArtikli";
            this.Text = "frmNarudzbaArtikli";
            this.Load += new System.EventHandler(this.frmNarudzbaArtikli_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaArtikla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniArtikli)).EndInit();
            this.grbOdabirArtikla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdaberiArtikl;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVrstaArtikla;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.DataGridView dgvOdabraniArtikli;
        private System.Windows.Forms.GroupBox grbOdabirArtikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj_artikla;
    }
}