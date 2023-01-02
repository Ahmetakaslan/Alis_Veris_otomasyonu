namespace Otomasyon1
{
    partial class ŞifreDeğiştir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ŞifreDeğiştir));
            this.tbxYeniSifre = new System.Windows.Forms.TextBox();
            this.tbxYEniSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnSifreKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTamam = new System.Windows.Forms.PictureBox();
            this.pictureBoxBekle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTamam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBekle)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxYeniSifre
            // 
            this.tbxYeniSifre.Location = new System.Drawing.Point(524, 176);
            this.tbxYeniSifre.Name = "tbxYeniSifre";
            this.tbxYeniSifre.Size = new System.Drawing.Size(211, 30);
            this.tbxYeniSifre.TabIndex = 0;
            // 
            // tbxYEniSifreTekrar
            // 
            this.tbxYEniSifreTekrar.Location = new System.Drawing.Point(524, 240);
            this.tbxYEniSifreTekrar.Name = "tbxYEniSifreTekrar";
            this.tbxYEniSifreTekrar.Size = new System.Drawing.Size(211, 30);
            this.tbxYEniSifreTekrar.TabIndex = 1;
            // 
            // btnSifreKaydet
            // 
            this.btnSifreKaydet.Location = new System.Drawing.Point(568, 376);
            this.btnSifreKaydet.Name = "btnSifreKaydet";
            this.btnSifreKaydet.Size = new System.Drawing.Size(114, 39);
            this.btnSifreKaydet.TabIndex = 2;
            this.btnSifreKaydet.Text = "Kaydet";
            this.btnSifreKaydet.UseVisualStyleBackColor = true;
            this.btnSifreKaydet.Click += new System.EventHandler(this.button1_Click);
            this.btnSifreKaydet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSifreKaydet_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifreyi tekrar  giriniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yeni bir şifre giriniz :";
            // 
            // pictureBoxTamam
            // 
            this.pictureBoxTamam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTamam.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTamam.Image")));
            this.pictureBoxTamam.Location = new System.Drawing.Point(500, 12);
            this.pictureBoxTamam.Name = "pictureBoxTamam";
            this.pictureBoxTamam.Size = new System.Drawing.Size(261, 151);
            this.pictureBoxTamam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTamam.TabIndex = 7;
            this.pictureBoxTamam.TabStop = false;
            // 
            // pictureBoxBekle
            // 
            this.pictureBoxBekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBekle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBekle.Image")));
            this.pictureBoxBekle.Location = new System.Drawing.Point(500, 12);
            this.pictureBoxBekle.Name = "pictureBoxBekle";
            this.pictureBoxBekle.Size = new System.Drawing.Size(261, 151);
            this.pictureBoxBekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBekle.TabIndex = 8;
            this.pictureBoxBekle.TabStop = false;
            // 
            // ŞifreDeğiştir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.pictureBoxBekle);
            this.Controls.Add(this.pictureBoxTamam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSifreKaydet);
            this.Controls.Add(this.tbxYEniSifreTekrar);
            this.Controls.Add(this.tbxYeniSifre);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ŞifreDeğiştir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞifreDeğiştir";
            this.Load += new System.EventHandler(this.ŞifreDeğiştir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTamam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBekle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxYeniSifre;
        private System.Windows.Forms.TextBox tbxYEniSifreTekrar;
        private System.Windows.Forms.Button btnSifreKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxTamam;
        private System.Windows.Forms.PictureBox pictureBoxBekle;
    }
}