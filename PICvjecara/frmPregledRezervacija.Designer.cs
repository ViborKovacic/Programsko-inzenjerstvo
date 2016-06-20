namespace PICvjecara
{
    partial class frmPregledRezervacija
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvRezervacija = new System.Windows.Forms.DataGridView();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dgvRezervacijeDetalji = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacijeDetalji)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRezervacija);
            this.groupBox1.Location = new System.Drawing.Point(38, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ime rezervacije";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRezervacijeDetalji);
            this.groupBox2.Location = new System.Drawing.Point(38, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalji rezervacije";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOpis);
            this.groupBox3.Location = new System.Drawing.Point(38, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 205);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opis usluga";
            // 
            // dgvRezervacija
            // 
            this.dgvRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacija.Location = new System.Drawing.Point(6, 19);
            this.dgvRezervacija.Name = "dgvRezervacija";
            this.dgvRezervacija.Size = new System.Drawing.Size(380, 150);
            this.dgvRezervacija.TabIndex = 0;
            this.dgvRezervacija.SelectionChanged += new System.EventHandler(this.dgvRezervacija_SelectionChanged);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(6, 19);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(479, 180);
            this.txtOpis.TabIndex = 0;
            // 
            // dgvRezervacijeDetalji
            // 
            this.dgvRezervacijeDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacijeDetalji.Location = new System.Drawing.Point(6, 17);
            this.dgvRezervacijeDetalji.Name = "dgvRezervacijeDetalji";
            this.dgvRezervacijeDetalji.Size = new System.Drawing.Size(665, 95);
            this.dgvRezervacijeDetalji.TabIndex = 0;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(767, 667);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(77, 31);
            this.btnPovratak.TabIndex = 2;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmPregledRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(856, 710);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPregledRezervacija";
            this.Text = "Pregled rezervacija";
            this.Load += new System.EventHandler(this.frmPregledRezervacija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacijeDetalji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvRezervacija;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DataGridView dgvRezervacijeDetalji;
        private System.Windows.Forms.Button btnPovratak;
    }
}