namespace Otomasyon1
{
    partial class SifreKurtar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreKurtar));
            this.tbxSendEmail = new System.Windows.Forms.TextBox();
            this.tbxEnterCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.btnGönder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxSendEmail
            // 
            this.tbxSendEmail.Location = new System.Drawing.Point(534, 219);
            this.tbxSendEmail.Name = "tbxSendEmail";
            this.tbxSendEmail.Size = new System.Drawing.Size(195, 30);
            this.tbxSendEmail.TabIndex = 0;
            this.tbxSendEmail.TextChanged += new System.EventHandler(this.tbxSendEmail_TextChanged);
            // 
            // tbxEnterCode
            // 
            this.tbxEnterCode.Location = new System.Drawing.Point(534, 328);
            this.tbxEnterCode.Name = "tbxEnterCode";
            this.tbxEnterCode.Size = new System.Drawing.Size(195, 30);
            this.tbxEnterCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "E posta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kod      :";
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(586, 389);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(89, 37);
            this.btnDogrula.TabIndex = 5;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGönder
            // 
            this.btnGönder.Location = new System.Drawing.Point(586, 266);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(89, 37);
            this.btnGönder.TabIndex = 6;
            this.btnGönder.Text = "Gönder";
            this.btnGönder.UseVisualStyleBackColor = true;
            this.btnGönder.Click += new System.EventHandler(this.button2_Click);
            this.btnGönder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
            // 
            // SifreKurtar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxEnterCode);
            this.Controls.Add(this.tbxSendEmail);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SifreKurtar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreKurtar";
            this.Load += new System.EventHandler(this.SifreKurtar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxEnterCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Button btnGönder;
        protected internal System.Windows.Forms.TextBox tbxSendEmail;
    }
}