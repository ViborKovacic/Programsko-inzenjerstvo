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
            this.grbArtikli = new System.Windows.Forms.GroupBox();
            this.btnUkloniArtikl = new System.Windows.Forms.Button();
            this.btnIzaberiArtikle = new System.Windows.Forms.Button();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.grbDobavljaci = new System.Windows.Forms.GroupBox();
            this.btnUkloniDobavljaca = new System.Windows.Forms.Button();
            this.btnIzaberiDobavljaca = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIzradiNarudzbenicu = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivNarudzbenice = new System.Windows.Forms.TextBox();
            this.grbArtikli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.grbDobavljaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbArtikli
            // 
            this.grbArtikli.Controls.Add(this.btnUkloniArtikl);
            this.grbArtikli.Controls.Add(this.btnIzaberiArtikle);
            this.grbArtikli.Controls.Add(this.dgvArtikli);
            this.grbArtikli.Location = new System.Drawing.Point(53, 315);
            this.grbArtikli.Name = "grbArtikli";
            this.grbArtikli.Size = new System.Drawing.Size(592, 349);
            this.grbArtikli.TabIndex = 4;
            this.grbArtikli.TabStop = false;
            this.grbArtikli.Text = "Artikli";
            // 
            // btnUkloniArtikl
            // 
            this.btnUkloniArtikl.Location = new System.Drawing.Point(323, 308);
            this.btnUkloniArtikl.Name = "btnUkloniArtikl";
            this.btnUkloniArtikl.Size = new System.Drawing.Size(115, 26);
            this.btnUkloniArtikl.TabIndex = 3;
            this.btnUkloniArtikl.Text = "Ukloni odabrano";
            this.btnUkloniArtikl.UseVisualStyleBackColor = true;
            this.btnUkloniArtikl.Click += new System.EventHandler(this.btnUkloniArtikl_Click);
            // 
            // btnIzaberiArtikle
            // 
            this.btnIzaberiArtikle.Location = new System.Drawing.Point(456, 308);
            this.btnIzaberiArtikle.Name = "btnIzaberiArtikle";
            this.btnIzaberiArtikle.Size = new System.Drawing.Size(115, 26);
            this.btnIzaberiArtikle.TabIndex = 3;
            this.btnIzaberiArtikle.Text = "Izaberi artikle";
            this.btnIzaberiArtikle.UseVisualStyleBackColor = true;
            this.btnIzaberiArtikle.Click += new System.EventHandler(this.btnIzaberiArtikle_Click);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(15, 19);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(556, 268);
            this.dgvArtikli.TabIndex = 0;
            // 
            // grbDobavljaci
            // 
            this.grbDobavljaci.Controls.Add(this.btnUkloniDobavljaca);
            this.grbDobavljaci.Controls.Add(this.btnIzaberiDobavljaca);
            this.grbDobavljaci.Controls.Add(this.dataGridView1);
            this.grbDobavljaci.Location = new System.Drawing.Point(53, 117);
            this.grbDobavljaci.Name = "grbDobavljaci";
            this.grbDobavljaci.Size = new System.Drawing.Size(592, 157);
            this.grbDobavljaci.TabIndex = 3;
            this.grbDobavljaci.TabStop = false;
            this.grbDobavljaci.Text = "Podaci o dobavljaču";
            // 
            // btnUkloniDobavljaca
            // 
            this.btnUkloniDobavljaca.Location = new System.Drawing.Point(323, 111);
            this.btnUkloniDobavljaca.Name = "btnUkloniDobavljaca";
            this.btnUkloniDobavljaca.Size = new System.Drawing.Size(115, 26);
            this.btnUkloniDobavljaca.TabIndex = 2;
            this.btnUkloniDobavljaca.Text = "Ukloni odabrano";
            this.btnUkloniDobavljaca.UseVisualStyleBackColor = true;
            this.btnUkloniDobavljaca.Click += new System.EventHandler(this.btnUkloniDobavljaca_Click);
            // 
            // btnIzaberiDobavljaca
            // 
            this.btnIzaberiDobavljaca.Location = new System.Drawing.Point(456, 111);
            this.btnIzaberiDobavljaca.Name = "btnIzaberiDobavljaca";
            this.btnIzaberiDobavljaca.Size = new System.Drawing.Size(115, 26);
            this.btnIzaberiDobavljaca.TabIndex = 1;
            this.btnIzaberiDobavljaca.Text = "Izaberi Dobavljača";
            this.btnIzaberiDobavljaca.UseVisualStyleBackColor = true;
            this.btnIzaberiDobavljaca.Click += new System.EventHandler(this.btnIzaberiDobavljaca_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 69);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnIzradiNarudzbenicu
            // 
            this.btnIzradiNarudzbenicu.Location = new System.Drawing.Point(517, 718);
            this.btnIzradiNarudzbenicu.Name = "btnIzradiNarudzbenicu";
            this.btnIzradiNarudzbenicu.Size = new System.Drawing.Size(107, 34);
            this.btnIzradiNarudzbenicu.TabIndex = 5;
            this.btnIzradiNarudzbenicu.Text = "Izradi narudžbenicu";
            this.btnIzradiNarudzbenicu.UseVisualStyleBackColor = true;
            this.btnIzradiNarudzbenicu.Click += new System.EventHandler(this.btnIzradiNarudzbenicu_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(642, 718);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(78, 34);
            this.btnPovratak.TabIndex = 6;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unesite naziv narudžbenice: ";
            // 
            // txtNazivNarudzbenice
            // 
            this.txtNazivNarudzbenice.Location = new System.Drawing.Point(206, 69);
            this.txtNazivNarudzbenice.Name = "txtNazivNarudzbenice";
            this.txtNazivNarudzbenice.Size = new System.Drawing.Size(138, 20);
            this.txtNazivNarudzbenice.TabIndex = 8;
            // 
            // frmNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(743, 764);
            this.Controls.Add(this.txtNazivNarudzbenice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnIzradiNarudzbenicu);
            this.Controls.Add(this.grbArtikli);
            this.Controls.Add(this.grbDobavljaci);
            this.Name = "frmNarudzbenica";
            this.Load += new System.EventHandler(this.frmNarudzbenica_Load);
            this.grbArtikli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.grbDobavljaci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbArtikli;
        private System.Windows.Forms.Button btnUkloniArtikl;
        private System.Windows.Forms.Button btnIzaberiArtikle;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.GroupBox grbDobavljaci;
        private System.Windows.Forms.Button btnUkloniDobavljaca;
        private System.Windows.Forms.Button btnIzaberiDobavljaca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIzradiNarudzbenicu;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivNarudzbenice;
    }
}