﻿namespace PICvjecara
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provedene rezervacije";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 326);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(16, 395);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(78, 35);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(751, 395);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(78, 35);
            this.btnPovratak.TabIndex = 3;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmPregledRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(841, 442);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmPregledRezervacija";
            this.Text = "frmPregledRezervacija";
            this.Load += new System.EventHandler(this.frmPregledRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPovratak;
    }
}