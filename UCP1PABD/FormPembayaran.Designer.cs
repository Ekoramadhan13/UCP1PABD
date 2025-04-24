namespace UCP1PABD
{
    partial class FormPembayaran
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.cbStatusBayar = new System.Windows.Forms.ComboBox();
            this.cbPemesanan = new System.Windows.Forms.ComboBox();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 323);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1483, 323);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(598, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 52);
            this.label3.TabIndex = 19;
            this.label3.Text = "Form Pembayaran";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Status Bayar";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pemesanan";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEdit.Location = new System.Drawing.Point(927, 206);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(190, 72);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTambah.Location = new System.Drawing.Point(712, 206);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(190, 72);
            this.btnTambah.TabIndex = 15;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpTanggal.Location = new System.Drawing.Point(38, 277);
            this.dtpTanggal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(543, 26);
            this.dtpTanggal.TabIndex = 14;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.Location = new System.Drawing.Point(38, 206);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(543, 35);
            this.txtJumlah.TabIndex = 13;
            // 
            // cbStatusBayar
            // 
            this.cbStatusBayar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbStatusBayar.FormattingEnabled = true;
            this.cbStatusBayar.Location = new System.Drawing.Point(328, 138);
            this.cbStatusBayar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatusBayar.Name = "cbStatusBayar";
            this.cbStatusBayar.Size = new System.Drawing.Size(253, 28);
            this.cbStatusBayar.TabIndex = 12;
            this.cbStatusBayar.SelectedIndexChanged += new System.EventHandler(this.cbStatusBayar_SelectedIndexChanged);
            // 
            // cbPemesanan
            // 
            this.cbPemesanan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPemesanan.FormattingEnabled = true;
            this.cbPemesanan.Location = new System.Drawing.Point(38, 138);
            this.cbPemesanan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPemesanan.Name = "cbPemesanan";
            this.cbPemesanan.Size = new System.Drawing.Size(253, 28);
            this.cbPemesanan.TabIndex = 11;
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHapus.Location = new System.Drawing.Point(703, 115);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(403, 72);
            this.btnHapus.TabIndex = 21;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 660);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.cbStatusBayar);
            this.Controls.Add(this.cbPemesanan);
            this.Name = "FormPembayaran";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.ComboBox cbStatusBayar;
        private System.Windows.Forms.ComboBox cbPemesanan;
        private System.Windows.Forms.Button btnHapus;
    }
}