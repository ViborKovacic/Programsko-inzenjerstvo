namespace PICvjecara
{
    partial class frmKlijenti
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
            this.dgvKlijent = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajKlijenta = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnOdabirKlijenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKlijent
            // 
            this.dgvKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijent.Location = new System.Drawing.Point(16, 58);
            this.dgvKlijent.Name = "dgvKlijent";
            this.dgvKlijent.Size = new System.Drawing.Size(689, 273);
            this.dgvKlijent.TabIndex = 0;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(718, 435);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(78, 32);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOdabirKlijenta);
            this.groupBox1.Controls.Add(this.btnTrazi);
            this.groupBox1.Controls.Add(this.txtTrazi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDodajKlijenta);
            this.groupBox1.Controls.Add(this.btnAzuriraj);
            this.groupBox1.Controls.Add(this.dgvKlijent);
            this.groupBox1.Location = new System.Drawing.Point(27, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 398);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Popis Klijenta";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(640, 19);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(76, 20);
            this.btnTrazi.TabIndex = 6;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(525, 19);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(100, 20);
            this.txtTrazi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pretrazi bazu preko OIB-a:";
            // 
            // btnDodajKlijenta
            // 
            this.btnDodajKlijenta.Location = new System.Drawing.Point(537, 358);
            this.btnDodajKlijenta.Name = "btnDodajKlijenta";
            this.btnDodajKlijenta.Size = new System.Drawing.Size(76, 34);
            this.btnDodajKlijenta.TabIndex = 3;
            this.btnDodajKlijenta.Text = "Dodaj klijenta";
            this.btnDodajKlijenta.UseVisualStyleBackColor = true;
            this.btnDodajKlijenta.Click += new System.EventHandler(this.btnDodajKlijenta_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(629, 358);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(76, 34);
            this.btnAzuriraj.TabIndex = 2;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnOdabirKlijenta
            // 
            this.btnOdabirKlijenta.Location = new System.Drawing.Point(16, 358);
            this.btnOdabirKlijenta.Name = "btnOdabirKlijenta";
            this.btnOdabirKlijenta.Size = new System.Drawing.Size(76, 34);
            this.btnOdabirKlijenta.TabIndex = 7;
            this.btnOdabirKlijenta.Text = "Odabir klijenta";
            this.btnOdabirKlijenta.UseVisualStyleBackColor = true;
            this.btnOdabirKlijenta.Click += new System.EventHandler(this.btnOdabirKlijenta_Click);
            // 
            // frmKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(808, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPovratak);
            this.Name = "frmKlijenti";
            this.Text = "Popis klijenata";
            this.Load += new System.EventHandler(this.frmKlijenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKlijent;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodajKlijenta;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdabirKlijenta;
    }
}