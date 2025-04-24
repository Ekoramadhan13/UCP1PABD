namespace UCP1PABD
{
    partial class MainForm
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

            this.Controls.Add(this.panelMain);

        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnPelanggan = new System.Windows.Forms.Button();
            this.btnProduk = new System.Windows.Forms.Button();
            this.btnPemesanan = new System.Windows.Forms.Button();
            this.btnPembayaran = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Main Menu";
            // 
            // btnPelanggan
            // 
            this.btnPelanggan.Location = new System.Drawing.Point(22, 92);
            this.btnPelanggan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPelanggan.Name = "btnPelanggan";
            this.btnPelanggan.Size = new System.Drawing.Size(219, 72);
            this.btnPelanggan.TabIndex = 6;
            this.btnPelanggan.Text = "Pelanggan";
            this.btnPelanggan.UseVisualStyleBackColor = true;
            this.btnPelanggan.Click += new System.EventHandler(this.btnPelanggan_Click);
            // 
            // btnProduk
            // 
            this.btnProduk.Location = new System.Drawing.Point(22, 187);
            this.btnProduk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduk.Name = "btnProduk";
            this.btnProduk.Size = new System.Drawing.Size(219, 72);
            this.btnProduk.TabIndex = 7;
            this.btnProduk.Text = "Produk";
            this.btnProduk.UseVisualStyleBackColor = true;
            this.btnProduk.Click += new System.EventHandler(this.btnProduk_Click);
            // 
            // btnPemesanan
            // 
            this.btnPemesanan.Location = new System.Drawing.Point(22, 280);
            this.btnPemesanan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPemesanan.Name = "btnPemesanan";
            this.btnPemesanan.Size = new System.Drawing.Size(219, 72);
            this.btnPemesanan.TabIndex = 8;
            this.btnPemesanan.Text = "Pemesanan";
            this.btnPemesanan.UseVisualStyleBackColor = true;
            this.btnPemesanan.Click += new System.EventHandler(this.btnPemesanan_Click);
            // 
            // btnPembayaran
            // 
            this.btnPembayaran.Location = new System.Drawing.Point(22, 362);
            this.btnPembayaran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPembayaran.Name = "btnPembayaran";
            this.btnPembayaran.Size = new System.Drawing.Size(219, 72);
            this.btnPembayaran.TabIndex = 9;
            this.btnPembayaran.Text = "Pembayaran";
            this.btnPembayaran.UseVisualStyleBackColor = true;
            this.btnPembayaran.Click += new System.EventHandler(this.btnPembayaran_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(279, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1285, 716);
            this.panelMain.TabIndex = 10;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 716);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnPembayaran);
            this.Controls.Add(this.btnPemesanan);
            this.Controls.Add(this.btnProduk);
            this.Controls.Add(this.btnPelanggan);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPelanggan;
        private System.Windows.Forms.Button btnProduk;
        private System.Windows.Forms.Button btnPemesanan;
        private System.Windows.Forms.Button btnPembayaran;
        private System.Windows.Forms.Panel panelMain;
    }
}