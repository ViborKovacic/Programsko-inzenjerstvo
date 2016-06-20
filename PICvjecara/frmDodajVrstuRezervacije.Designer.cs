namespace PICvjecara
{
    partial class frmDodajVrstuRezervacije
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
            this.txtVrstaRezevacije = new System.Windows.Forms.TextBox();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta rezervacije:";
            // 
            // txtVrstaRezevacije
            // 
            this.txtVrstaRezevacije.Location = new System.Drawing.Point(107, 29);
            this.txtVrstaRezevacije.Name = "txtVrstaRezevacije";
            this.txtVrstaRezevacije.Size = new System.Drawing.Size(126, 20);
            this.txtVrstaRezevacije.TabIndex = 1;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(219, 92);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 2;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(138, 92);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmDodajVrstuRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 116);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.txtVrstaRezevacije);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajVrstuRezervacije";
            this.Text = "Dodaj novu vrstu rezervacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVrstaRezevacije;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnDodaj;
    }
}