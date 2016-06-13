namespace PICvjecara
{
    partial class frmRezervacije
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
            this.cmbVrstaRezervacije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCijenaRezervacije = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKolicinaRezervacije = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpravljanjeRezer = new System.Windows.Forms.Button();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.txtOpisRezervacije = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta rezervacije:";
            // 
            // cmbVrstaRezervacije
            // 
            this.cmbVrstaRezervacije.FormattingEnabled = true;
            this.cmbVrstaRezervacije.Location = new System.Drawing.Point(110, 30);
            this.cmbVrstaRezervacije.Name = "cmbVrstaRezervacije";
            this.cmbVrstaRezervacije.Size = new System.Drawing.Size(121, 21);
            this.cmbVrstaRezervacije.TabIndex = 1;
            this.cmbVrstaRezervacije.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaRezervacije_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena:";
            // 
            // txtCijenaRezervacije
            // 
            this.txtCijenaRezervacije.Location = new System.Drawing.Point(110, 70);
            this.txtCijenaRezervacije.Name = "txtCijenaRezervacije";
            this.txtCijenaRezervacije.ReadOnly = true;
            this.txtCijenaRezervacije.Size = new System.Drawing.Size(49, 20);
            this.txtCijenaRezervacije.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Količina:";
            // 
            // txtKolicinaRezervacije
            // 
            this.txtKolicinaRezervacije.Location = new System.Drawing.Point(110, 107);
            this.txtKolicinaRezervacije.Name = "txtKolicinaRezervacije";
            this.txtKolicinaRezervacije.Size = new System.Drawing.Size(49, 20);
            this.txtKolicinaRezervacije.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnUpravljanjeRezer);
            this.groupBox1.Controls.Add(this.btnRezerviraj);
            this.groupBox1.Controls.Add(this.txtOpisRezervacije);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKolicinaRezervacije);
            this.groupBox1.Controls.Add(this.cmbVrstaRezervacije);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCijenaRezervacije);
            this.groupBox1.Location = new System.Drawing.Point(25, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 372);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o rezervaciji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "HRK";
            // 
            // btnUpravljanjeRezer
            // 
            this.btnUpravljanjeRezer.Location = new System.Drawing.Point(166, 317);
            this.btnUpravljanjeRezer.Name = "btnUpravljanjeRezer";
            this.btnUpravljanjeRezer.Size = new System.Drawing.Size(133, 49);
            this.btnUpravljanjeRezer.TabIndex = 9;
            this.btnUpravljanjeRezer.Text = "Upravljanje rezervacijama";
            this.btnUpravljanjeRezer.UseVisualStyleBackColor = true;
            this.btnUpravljanjeRezer.Click += new System.EventHandler(this.btnUpravljanjeRezer_Click);
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(19, 317);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(91, 49);
            this.btnRezerviraj.TabIndex = 8;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // txtOpisRezervacije
            // 
            this.txtOpisRezervacije.Location = new System.Drawing.Point(426, 58);
            this.txtOpisRezervacije.Multiline = true;
            this.txtOpisRezervacije.Name = "txtOpisRezervacije";
            this.txtOpisRezervacije.Size = new System.Drawing.Size(401, 308);
            this.txtOpisRezervacije.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opis ponude";
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(767, 421);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(91, 49);
            this.btnPovratak.TabIndex = 10;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(886, 482);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRezervacije";
            this.Text = "frmRezervacije";
            this.Load += new System.EventHandler(this.frmRezervacije_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVrstaRezervacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCijenaRezervacije;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKolicinaRezervacije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpravljanjeRezer;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.TextBox txtOpisRezervacije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label label5;
    }
}