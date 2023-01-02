namespace Otomasyon1
{
    partial class KayıtOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayıtOl));
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxklcİsminiz = new System.Windows.Forms.TextBox();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxklnŞİfre = new System.Windows.Forms.TextBox();
            this.kullanıcınınismi = new System.Windows.Forms.Label();
            this.tbxklnKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Şifre Belirleyin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "E posta";
            // 
            // tbxklcİsminiz
            // 
            this.tbxklcİsminiz.Location = new System.Drawing.Point(438, 186);
            this.tbxklcİsminiz.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tbxklcİsminiz.Name = "tbxklcİsminiz";
            this.tbxklcİsminiz.Size = new System.Drawing.Size(205, 29);
            this.tbxklcİsminiz.TabIndex = 2;
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.Location = new System.Drawing.Point(437, 478);
            this.btnKayıtOl.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(206, 45);
            this.btnKayıtOl.TabIndex = 1;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = true;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            this.btnKayıtOl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnKayıtOl_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 6;
            // 
            // tbxklnŞİfre
            // 
            this.tbxklnŞİfre.Location = new System.Drawing.Point(438, 388);
            this.tbxklnŞİfre.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tbxklnŞİfre.Name = "tbxklnŞİfre";
            this.tbxklnŞİfre.Size = new System.Drawing.Size(205, 29);
            this.tbxklnŞİfre.TabIndex = 3;
            // 
            // kullanıcınınismi
            // 
            this.kullanıcınınismi.AutoSize = true;
            this.kullanıcınınismi.Location = new System.Drawing.Point(268, 193);
            this.kullanıcınınismi.Name = "kullanıcınınismi";
            this.kullanıcınınismi.Size = new System.Drawing.Size(67, 22);
            this.kullanıcınınismi.TabIndex = 5;
            this.kullanıcınınismi.Text = "isminiz ";
            // 
            // tbxklnKullanıcıAdı
            // 
            this.tbxklnKullanıcıAdı.Location = new System.Drawing.Point(438, 296);
            this.tbxklnKullanıcıAdı.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tbxklnKullanıcıAdı.Name = "tbxklnKullanıcıAdı";
            this.tbxklnKullanıcıAdı.Size = new System.Drawing.Size(205, 29);
            this.tbxklnKullanıcıAdı.TabIndex = 4;
            // 
            // KayıtOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxklcİsminiz);
            this.Controls.Add(this.tbxklnKullanıcıAdı);
            this.Controls.Add(this.kullanıcınınismi);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.tbxklnŞİfre);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KayıtOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxklnŞİfre;
        private System.Windows.Forms.Label kullanıcınınismi;
        private System.Windows.Forms.TextBox tbxklnKullanıcıAdı;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxklcİsminiz;
    }
}