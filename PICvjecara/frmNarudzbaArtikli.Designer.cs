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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.dgvVrstaArtikla = new System.Windows.Forms.DataGridView();
            this.dgvOdabraniArtikli = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOdaberiArtikl = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaArtikla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniArtikli)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(332, 3);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(479, 239);
            this.dgvArtikli.TabIndex = 0;
            // 
            // dgvVrstaArtikla
            // 
            this.dgvVrstaArtikla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVrstaArtikla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstaArtikla.Location = new System.Drawing.Point(3, 3);
            this.dgvVrstaArtikla.Name = "dgvVrstaArtikla";
            this.dgvVrstaArtikla.Size = new System.Drawing.Size(323, 239);
            this.dgvVrstaArtikla.TabIndex = 0;
            this.dgvVrstaArtikla.SelectionChanged += new System.EventHandler(this.dgvVrstaArtikla_SelectionChanged);
            // 
            // dgvOdabraniArtikli
            // 
            this.dgvOdabraniArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdabraniArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabraniArtikli.Location = new System.Drawing.Point(3, 3);
            this.dgvOdabraniArtikli.Name = "dgvOdabraniArtikli";
            this.dgvOdabraniArtikli.Size = new System.Drawing.Size(808, 199);
            this.dgvOdabraniArtikli.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgvOdabraniArtikli);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 358);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(832, 214);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dgvVrstaArtikla);
            this.flowLayoutPanel2.Controls.Add(this.dgvArtikli);
            this.flowLayoutPanel2.Controls.Add(this.btnOdaberiArtikl);
            this.flowLayoutPanel2.Controls.Add(this.btnPovratak);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(833, 297);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // btnOdaberiArtikl
            // 
            this.btnOdaberiArtikl.Location = new System.Drawing.Point(3, 248);
            this.btnOdaberiArtikl.Name = "btnOdaberiArtikl";
            this.btnOdaberiArtikl.Size = new System.Drawing.Size(93, 35);
            this.btnOdaberiArtikl.TabIndex = 12;
            this.btnOdaberiArtikl.Text = "OdaberiArtikl";
            this.btnOdaberiArtikl.UseVisualStyleBackColor = true;
            this.btnOdaberiArtikl.Click += new System.EventHandler(this.btnOdaberiArtikl_Click_1);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(102, 248);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(93, 35);
            this.btnPovratak.TabIndex = 13;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Količina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(65, 322);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 17;
            // 
            // frmNarudzbaArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(832, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmNarudzbaArtikli";
            this.Text = "frmNarudzbaArtikli";
            this.Load += new System.EventHandler(this.frmNarudzbaArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaArtikla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniArtikli)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.DataGridView dgvVrstaArtikla;
        private System.Windows.Forms.DataGridView dgvOdabraniArtikli;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnOdaberiArtikl;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKolicina;
    }
}