namespace Otomasyon1
{
    partial class FormGirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGirisYap));
            this.roundedPanel1 = new Otomasyon1.RoundedPanel();
            this.tbxKullanıcıadı = new System.Windows.Forms.TextBox();
            this.admin = new Otomasyon1.MyButton();
            this.tbxŞifre = new System.Windows.Forms.TextBox();
            this.btnKayıtOl = new Otomasyon1.MyButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGirisYap = new Otomasyon1.MyButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGözKapa = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnGozAc = new System.Windows.Forms.PictureBox();
            this.labeltick = new System.Windows.Forms.Label();
            this.labelGoz = new System.Windows.Forms.Label();
            this.lblSifreTick = new System.Windows.Forms.Label();
            this.lblPostaTick = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGözKapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGozAc)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Silver;
            this.roundedPanel1.BorderColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.tbxKullanıcıadı);
            this.roundedPanel1.Controls.Add(this.admin);
            this.roundedPanel1.Controls.Add(this.tbxŞifre);
            this.roundedPanel1.Controls.Add(this.btnKayıtOl);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.btnGirisYap);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.btnGözKapa);
            this.roundedPanel1.Controls.Add(this.linkLabel1);
            this.roundedPanel1.Controls.Add(this.btnGozAc);
            this.roundedPanel1.Controls.Add(this.labeltick);
            this.roundedPanel1.Controls.Add(this.labelGoz);
            this.roundedPanel1.Controls.Add(this.lblSifreTick);
            this.roundedPanel1.Controls.Add(this.lblPostaTick);
            this.roundedPanel1.Location = new System.Drawing.Point(104, 74);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 50;
            this.roundedPanel1.Size = new System.Drawing.Size(888, 517);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.Thickness = 5F;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // tbxKullanıcıadı
            // 
            this.tbxKullanıcıadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKullanıcıadı.Location = new System.Drawing.Point(373, 74);
            this.tbxKullanıcıadı.Name = "tbxKullanıcıadı";
            this.tbxKullanıcıadı.Size = new System.Drawing.Size(214, 34);
            this.tbxKullanıcıadı.TabIndex = 61;
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.Crimson;
            this.admin.BackgroundColor = System.Drawing.Color.Crimson;
            this.admin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.admin.BorderRadius = 30;
            this.admin.BorderSize = 1;
            this.admin.FlatAppearance.BorderSize = 0;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin.ForeColor = System.Drawing.Color.White;
            this.admin.Location = new System.Drawing.Point(373, 369);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(150, 80);
            this.admin.TabIndex = 74;
            this.admin.Text = "Admin";
            this.admin.TextColor = System.Drawing.Color.White;
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // tbxŞifre
            // 
            this.tbxŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxŞifre.HideSelection = false;
            this.tbxŞifre.Location = new System.Drawing.Point(373, 146);
            this.tbxŞifre.Name = "tbxŞifre";
            this.tbxŞifre.PasswordChar = '*';
            this.tbxŞifre.Size = new System.Drawing.Size(214, 34);
            this.tbxŞifre.TabIndex = 62;
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnKayıtOl.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnKayıtOl.BorderColor = System.Drawing.Color.Black;
            this.btnKayıtOl.BorderRadius = 30;
            this.btnKayıtOl.BorderSize = 0;
            this.btnKayıtOl.FlatAppearance.BorderSize = 0;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtOl.ForeColor = System.Drawing.Color.White;
            this.btnKayıtOl.Location = new System.Drawing.Point(156, 267);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(149, 80);
            this.btnKayıtOl.TabIndex = 73;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.TextColor = System.Drawing.Color.White;
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(169, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "E  Posta :";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Magenta;
            this.btnGirisYap.BackgroundColor = System.Drawing.Color.Magenta;
            this.btnGirisYap.BorderColor = System.Drawing.Color.Black;
            this.btnGirisYap.BorderRadius = 30;
            this.btnGirisYap.BorderSize = 2;
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(583, 267);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(149, 80);
            this.btnGirisYap.TabIndex = 72;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.TextColor = System.Drawing.Color.White;
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click_1);
            this.btnGirisYap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGirisYap_KeyDown_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(169, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Şifre:";
            // 
            // btnGözKapa
            // 
            this.btnGözKapa.BackColor = System.Drawing.Color.White;
            this.btnGözKapa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGözKapa.BackgroundImage")));
            this.btnGözKapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGözKapa.Location = new System.Drawing.Point(628, 146);
            this.btnGözKapa.Name = "btnGözKapa";
            this.btnGözKapa.Size = new System.Drawing.Size(40, 34);
            this.btnGözKapa.TabIndex = 71;
            this.btnGözKapa.TabStop = false;
            this.btnGözKapa.Click += new System.EventHandler(this.btnGözKapa_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(401, 220);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 22);
            this.linkLabel1.TabIndex = 65;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // btnGozAc
            // 
            this.btnGozAc.BackColor = System.Drawing.Color.White;
            this.btnGozAc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGozAc.BackgroundImage")));
            this.btnGozAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGozAc.Location = new System.Drawing.Point(628, 146);
            this.btnGozAc.Name = "btnGozAc";
            this.btnGozAc.Size = new System.Drawing.Size(40, 34);
            this.btnGozAc.TabIndex = 70;
            this.btnGozAc.TabStop = false;
            this.btnGozAc.Click += new System.EventHandler(this.btnGozAc_Click);
            // 
            // labeltick
            // 
            this.labeltick.AutoSize = true;
            this.labeltick.BackColor = System.Drawing.Color.White;
            this.labeltick.Location = new System.Drawing.Point(593, 79);
            this.labeltick.Name = "labeltick";
            this.labeltick.Size = new System.Drawing.Size(0, 22);
            this.labeltick.TabIndex = 66;
            // 
            // labelGoz
            // 
            this.labelGoz.AutoSize = true;
            this.labelGoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGoz.Location = new System.Drawing.Point(655, 146);
            this.labelGoz.Name = "labelGoz";
            this.labelGoz.Size = new System.Drawing.Size(0, 32);
            this.labelGoz.TabIndex = 69;
            // 
            // lblSifreTick
            // 
            this.lblSifreTick.AutoSize = true;
            this.lblSifreTick.BackColor = System.Drawing.Color.White;
            this.lblSifreTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreTick.Location = new System.Drawing.Point(593, 151);
            this.lblSifreTick.Name = "lblSifreTick";
            this.lblSifreTick.Size = new System.Drawing.Size(0, 29);
            this.lblSifreTick.TabIndex = 67;
            // 
            // lblPostaTick
            // 
            this.lblPostaTick.AutoSize = true;
            this.lblPostaTick.BackColor = System.Drawing.Color.White;
            this.lblPostaTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPostaTick.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPostaTick.Location = new System.Drawing.Point(592, 79);
            this.lblPostaTick.Name = "lblPostaTick";
            this.lblPostaTick.Size = new System.Drawing.Size(0, 29);
            this.lblPostaTick.TabIndex = 68;
            // 
            // FormGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 668);
            this.Controls.Add(this.roundedPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGirisYap";
            this.Load += new System.EventHandler(this.FormGirisYap_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGözKapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGozAc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.TextBox tbxKullanıcıadı;
        private MyButton admin;
        private System.Windows.Forms.TextBox tbxŞifre;
        private MyButton btnKayıtOl;
        private System.Windows.Forms.Label label1;
        private MyButton btnGirisYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnGözKapa;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox btnGozAc;
        private System.Windows.Forms.Label labeltick;
        private System.Windows.Forms.Label labelGoz;
        private System.Windows.Forms.Label lblSifreTick;
        private System.Windows.Forms.Label lblPostaTick;
    }
}