namespace PICvjecara
{
    partial class frmPregledNarudzbenica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNazivNarudzbenica = new System.Windows.Forms.DataGridView();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNazivNarudzbenica)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNazivNarudzbenica);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kreirane narudžbenice";
            // 
            // dgvNazivNarudzbenica
            // 
            this.dgvNazivNarudzbenica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNazivNarudzbenica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNazivNarudzbenica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNazivNarudzbenica.Location = new System.Drawing.Point(3, 16);
            this.dgvNazivNarudzbenica.Name = "dgvNazivNarudzbenica";
            this.dgvNazivNarudzbenica.Size = new System.Drawing.Size(606, 283);
            this.dgvNazivNarudzbenica.TabIndex = 0;
            this.dgvNazivNarudzbenica.SelectionChanged += new System.EventHandler(this.dgvNazivNarudzbenica_SelectionChanged);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(0, 72);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(87, 39);
            this.btnEmail.TabIndex = 4;
            this.btnEmail.Text = "Pošalji Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(0, 24);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(87, 42);
            this.btnPdf.TabIndex = 3;
            this.btnPdf.Text = "Detalji narudžbenice";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(0, 117);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(87, 37);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPdf);
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Controls.Add(this.btnEmail);
            this.groupBox2.Location = new System.Drawing.Point(647, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 302);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operacije";
            // 
            // frmPregledNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(973, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPregledNarudzbenica";
            this.Text = "Pregle narudžbenica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPregledNarudzbenica_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNazivNarudzbenica)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvNazivNarudzbenica;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}