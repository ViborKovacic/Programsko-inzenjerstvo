namespace PICvjecara
{
    partial class frmNarudzbenica
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
            this.btnUkloniArtikl = new System.Windows.Forms.Button();
            this.btnIzaberiArtikle = new System.Windows.Forms.Button();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnUkloniDobavljaca = new System.Windows.Forms.Button();
            this.btnIzaberiDobavljaca = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIzradiNarudzbenicu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUkloniArtikl
            // 
            this.btnUkloniArtikl.Location = new System.Drawing.Point(474, 277);
            this.btnUkloniArtikl.Name = "btnUkloniArtikl";
            this.btnUkloniArtikl.Size = new System.Drawing.Size(115, 26);
            this.btnUkloniArtikl.TabIndex = 3;
            this.btnUkloniArtikl.Text = "Ukloni odabrano";
            this.btnUkloniArtikl.UseVisualStyleBackColor = true;
            this.btnUkloniArtikl.Click += new System.EventHandler(this.btnUkloniArtikl_Click);
            // 
            // btnIzaberiArtikle
            // 
            this.btnIzaberiArtikle.Location = new System.Drawing.Point(353, 277);
            this.btnIzaberiArtikle.Name = "btnIzaberiArtikle";
            this.btnIzaberiArtikle.Size = new System.Drawing.Size(115, 26);
            this.btnIzaberiArtikle.TabIndex = 3;
            this.btnIzaberiArtikle.Text = "Izaberi artikle";
            this.btnIzaberiArtikle.UseVisualStyleBackColor = true;
            this.btnIzaberiArtikle.Click += new System.EventHandler(this.btnIzaberiArtikle_Click);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(0, 3);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(589, 268);
            this.dgvArtikli.TabIndex = 0;
            // 
            // btnUkloniDobavljaca
            // 
            this.btnUkloniDobavljaca.Location = new System.Drawing.Point(353, 78);
            this.btnUkloniDobavljaca.Name = "btnUkloniDobavljaca";
            this.btnUkloniDobavljaca.Size = new System.Drawing.Size(115, 26);
            this.btnUkloniDobavljaca.TabIndex = 2;
            this.btnUkloniDobavljaca.Text = "Ukloni odabrano";
            this.btnUkloniDobavljaca.UseVisualStyleBackColor = true;
            this.btnUkloniDobavljaca.Click += new System.EventHandler(this.btnUkloniDobavljaca_Click);
            // 
            // btnIzaberiDobavljaca
            // 
            this.btnIzaberiDobavljaca.Location = new System.Drawing.Point(474, 78);
            this.btnIzaberiDobavljaca.Name = "btnIzaberiDobavljaca";
            this.btnIzaberiDobavljaca.Size = new System.Drawing.Size(115, 26);
            this.btnIzaberiDobavljaca.TabIndex = 1;
            this.btnIzaberiDobavljaca.Text = "Izaberi Dobavljača";
            this.btnIzaberiDobavljaca.UseVisualStyleBackColor = true;
            this.btnIzaberiDobavljaca.Click += new System.EventHandler(this.btnIzaberiDobavljaca_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 69);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnIzradiNarudzbenicu
            // 
            this.btnIzradiNarudzbenicu.Location = new System.Drawing.Point(509, 676);
            this.btnIzradiNarudzbenicu.Name = "btnIzradiNarudzbenicu";
            this.btnIzradiNarudzbenicu.Size = new System.Drawing.Size(107, 34);
            this.btnIzradiNarudzbenicu.TabIndex = 5;
            this.btnIzradiNarudzbenicu.Text = "Izradi narudžbenicu";
            this.btnIzradiNarudzbenicu.UseVisualStyleBackColor = true;
            this.btnIzradiNarudzbenicu.Click += new System.EventHandler(this.btnIzradiNarudzbenicu_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgvArtikli);
            this.flowLayoutPanel1.Controls.Add(this.btnUkloniArtikl);
            this.flowLayoutPanel1.Controls.Add(this.btnIzaberiArtikle);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 193);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(592, 316);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel2.Controls.Add(this.btnIzaberiDobavljaca);
            this.flowLayoutPanel2.Controls.Add(this.btnUkloniDobavljaca);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(53, 59);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(592, 114);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // frmNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(743, 741);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnIzradiNarudzbenicu);
            this.Name = "frmNarudzbenica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNarudzbenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUkloniArtikl;
        private System.Windows.Forms.Button btnIzaberiArtikle;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnUkloniDobavljaca;
        private System.Windows.Forms.Button btnIzaberiDobavljaca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIzradiNarudzbenicu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}