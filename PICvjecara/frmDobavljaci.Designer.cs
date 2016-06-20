namespace PICvjecara
{
    partial class frmDobavljaci
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
            this.btnPovarakta = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovarakta
            // 
            this.btnPovarakta.Location = new System.Drawing.Point(589, 513);
            this.btnPovarakta.Name = "btnPovarakta";
            this.btnPovarakta.Size = new System.Drawing.Size(75, 27);
            this.btnPovarakta.TabIndex = 11;
            this.btnPovarakta.Text = "Povratak";
            this.btnPovarakta.UseVisualStyleBackColor = true;
            this.btnPovarakta.Click += new System.EventHandler(this.btnPovarakta_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(27, 424);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 40);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj dobavljača";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(495, 424);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(137, 40);
            this.btnOdaberi.TabIndex = 9;
            this.btnOdaberi.Text = "Odaberi dobavljaca";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 360);
            this.dataGridView1.TabIndex = 8;
            // 
            // frmDobavljaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(676, 552);
            this.Controls.Add(this.btnPovarakta);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDobavljaci";
            this.Text = "frmDobavljaci";
            this.Load += new System.EventHandler(this.frmDobavljaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPovarakta;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}