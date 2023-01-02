namespace Otomasyon1
{
    partial class KullaniciVerileri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciVerileri));
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet2 = new Otomasyon1.MainDataSet2();
            this.BtnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAlım = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbxAraKullanıcıVerileri = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.peopleTableAdapter = new Otomasyon1.MainDataSet2TableAdapters.PeopleTableAdapter();
            this.dataGridViewKulanıcıVerileri = new System.Windows.Forms.DataGridView();
            this.Sat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKulanıcıVerileri)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.mainDataSet2;
            // 
            // mainDataSet2
            // 
            this.mainDataSet2.DataSetName = "MainDataSet2";
            this.mainDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(12, 4);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(153, 51);
            this.BtnSil.TabIndex = 1;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.labelAlım);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(-1, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "En Çok Ürün Alan 10 Kişi  Kullanıcı Adına göre Sıralanmıştır";
            // 
            // labelAlım
            // 
            this.labelAlım.AutoSize = true;
            this.labelAlım.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAlım.Location = new System.Drawing.Point(657, 140);
            this.labelAlım.Name = "labelAlım";
            this.labelAlım.Size = new System.Drawing.Size(28, 22);
            this.labelAlım.TabIndex = 2;
            this.labelAlım.Text = "00";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(362, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 30);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(362, 131);
            this.progressBar1.Maximum = 8000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 31);
            this.progressBar1.TabIndex = 0;
            // 
            // tbxAraKullanıcıVerileri
            // 
            this.tbxAraKullanıcıVerileri.Location = new System.Drawing.Point(1074, 20);
            this.tbxAraKullanıcıVerileri.Name = "tbxAraKullanıcıVerileri";
            this.tbxAraKullanıcıVerileri.Size = new System.Drawing.Size(131, 29);
            this.tbxAraKullanıcıVerileri.TabIndex = 3;
            this.tbxAraKullanıcıVerileri.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1012, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ara:";
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewKulanıcıVerileri
            // 
            this.dataGridViewKulanıcıVerileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKulanıcıVerileri.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewKulanıcıVerileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKulanıcıVerileri.Location = new System.Drawing.Point(-1, 53);
            this.dataGridViewKulanıcıVerileri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewKulanıcıVerileri.Name = "dataGridViewKulanıcıVerileri";
            this.dataGridViewKulanıcıVerileri.RowHeadersWidth = 51;
            this.dataGridViewKulanıcıVerileri.RowTemplate.Height = 24;
            this.dataGridViewKulanıcıVerileri.Size = new System.Drawing.Size(1232, 349);
            this.dataGridViewKulanıcıVerileri.TabIndex = 0;
            this.dataGridViewKulanıcıVerileri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKulanıcıVerileri_CellContentClick);
            // 
            // Sat
            // 
            this.Sat.BackColor = System.Drawing.Color.Fuchsia;
            this.Sat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sat.Location = new System.Drawing.Point(1016, 417);
            this.Sat.Name = "Sat";
            this.Sat.Size = new System.Drawing.Size(153, 69);
            this.Sat.TabIndex = 8;
            this.Sat.Text = "Ürün Sat";
            this.Sat.UseVisualStyleBackColor = false;
            this.Sat.Click += new System.EventHandler(this.Sat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "En Çok Satılan Ürün";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KullaniciVerileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAraKullanıcıVerileri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.dataGridViewKulanıcıVerileri);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KullaniciVerileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.KullaniciVerileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKulanıcıVerileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelAlım;
        private System.Windows.Forms.TextBox tbxAraKullanıcıVerileri;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private MainDataSet2 mainDataSet2;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private MainDataSet2TableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewKulanıcıVerileri;
        private System.Windows.Forms.Button Sat;
        private System.Windows.Forms.Button button1;
    }
}