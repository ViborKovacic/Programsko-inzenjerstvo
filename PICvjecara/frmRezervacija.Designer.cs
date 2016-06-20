namespace PICvjecara
{
    partial class frmRezervacija
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
            this.dgvVrstaRezervacije = new System.Windows.Forms.DataGridView();
            this.txtNazivRezervacije = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.brnOdaberiKlijenta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKlijent = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.txtOkvirnaCijena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dTimer = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaRezervacije)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv rezervacije:";
            // 
            // dgvVrstaRezervacije
            // 
            this.dgvVrstaRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstaRezervacije.Location = new System.Drawing.Point(32, 54);
            this.dgvVrstaRezervacije.Name = "dgvVrstaRezervacije";
            this.dgvVrstaRezervacije.Size = new System.Drawing.Size(294, 128);
            this.dgvVrstaRezervacije.TabIndex = 1;
            // 
            // txtNazivRezervacije
            // 
            this.txtNazivRezervacije.Location = new System.Drawing.Point(126, 28);
            this.txtNazivRezervacije.Name = "txtNazivRezervacije";
            this.txtNazivRezervacije.Size = new System.Drawing.Size(146, 20);
            this.txtNazivRezervacije.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brnOdaberiKlijenta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvKlijent);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnRezerviraj);
            this.groupBox1.Controls.Add(this.txtOkvirnaCijena);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.dTimer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvVrstaRezervacije);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNazivRezervacije);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 674);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacija";
            // 
            // brnOdaberiKlijenta
            // 
            this.brnOdaberiKlijenta.Location = new System.Drawing.Point(424, 336);
            this.brnOdaberiKlijenta.Name = "brnOdaberiKlijenta";
            this.brnOdaberiKlijenta.Size = new System.Drawing.Size(96, 23);
            this.brnOdaberiKlijenta.TabIndex = 12;
            this.brnOdaberiKlijenta.Text = "Odaberi klijenta";
            this.brnOdaberiKlijenta.UseVisualStyleBackColor = true;
            this.brnOdaberiKlijenta.Click += new System.EventHandler(this.brnOdaberiKlijenta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Klijent:";
            // 
            // dgvKlijent
            // 
            this.dgvKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijent.Location = new System.Drawing.Point(32, 262);
            this.dgvKlijent.Name = "dgvKlijent";
            this.dgvKlijent.Size = new System.Drawing.Size(488, 68);
            this.dgvKlijent.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj novu vrstu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(458, 622);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(82, 36);
            this.btnRezerviraj.TabIndex = 5;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // txtOkvirnaCijena
            // 
            this.txtOkvirnaCijena.Location = new System.Drawing.Point(113, 604);
            this.txtOkvirnaCijena.Name = "txtOkvirnaCijena";
            this.txtOkvirnaCijena.Size = new System.Drawing.Size(109, 20);
            this.txtOkvirnaCijena.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Okvirna cijena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis usluge:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(32, 426);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(455, 172);
            this.txtOpis.TabIndex = 5;
            // 
            // dTimer
            // 
            this.dTimer.Location = new System.Drawing.Point(126, 366);
            this.dTimer.Name = "dTimer";
            this.dTimer.Size = new System.Drawing.Size(200, 20);
            this.dTimer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum održavanja:";
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(588, 714);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(82, 36);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(682, 762);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRezervacija";
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaRezervacije)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVrstaRezervacije;
        private System.Windows.Forms.TextBox txtNazivRezervacije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.TextBox txtOkvirnaCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DateTimePicker dTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button brnOdaberiKlijenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvKlijent;
    }
}