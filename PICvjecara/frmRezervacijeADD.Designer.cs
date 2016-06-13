namespace PICvjecara
{
    partial class frmRezervacijeADD
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
            this.grbNove = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovaVrsta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnIzradi = new System.Windows.Forms.Button();
            this.grbNove.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNove
            // 
            this.grbNove.Controls.Add(this.btnIzradi);
            this.grbNove.Controls.Add(this.txtOpis);
            this.grbNove.Controls.Add(this.label3);
            this.grbNove.Controls.Add(this.txtCijena);
            this.grbNove.Controls.Add(this.label2);
            this.grbNove.Controls.Add(this.txtNovaVrsta);
            this.grbNove.Controls.Add(this.label1);
            this.grbNove.Location = new System.Drawing.Point(12, 12);
            this.grbNove.Name = "grbNove";
            this.grbNove.Size = new System.Drawing.Size(571, 379);
            this.grbNove.TabIndex = 0;
            this.grbNove.TabStop = false;
            this.grbNove.Text = "Dodaj novu rezervaciju";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta rezervacije:";
            // 
            // txtNovaVrsta
            // 
            this.txtNovaVrsta.Location = new System.Drawing.Point(113, 31);
            this.txtNovaVrsta.Name = "txtNovaVrsta";
            this.txtNovaVrsta.Size = new System.Drawing.Size(100, 20);
            this.txtNovaVrsta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(113, 66);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opišite ponudu:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(29, 131);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(389, 228);
            this.txtOpis.TabIndex = 5;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(480, 424);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(103, 30);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnIzradi
            // 
            this.btnIzradi.Location = new System.Drawing.Point(468, 343);
            this.btnIzradi.Name = "btnIzradi";
            this.btnIzradi.Size = new System.Drawing.Size(103, 30);
            this.btnIzradi.TabIndex = 2;
            this.btnIzradi.Text = "Izradi ";
            this.btnIzradi.UseVisualStyleBackColor = true;
            this.btnIzradi.Click += new System.EventHandler(this.btnIzradi_Click);
            // 
            // frmRezervacijeADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 467);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.grbNove);
            this.Name = "frmRezervacijeADD";
            this.Text = "frmRezervacijeADD";
            this.Load += new System.EventHandler(this.frmRezervacijeADD_Load);
            this.grbNove.ResumeLayout(false);
            this.grbNove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNove;
        private System.Windows.Forms.TextBox txtNovaVrsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnIzradi;
    }
}