namespace Otomasyon1
{
    partial class FormÜrünSat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÜrünSat));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet3 = new Otomasyon1.MainDataSet3();
            this.btnSil = new System.Windows.Forms.Button();
            this.Labelİsim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxgücelleÜrünİsmi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxgüncelleÜrünAdedi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxgücelleÜrünFiyatı = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxÜrünİsmi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxürünadedi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxfiyat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxUrunTuru = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.productsTableAdapter = new Otomasyon1.MainDataSet3TableAdapters.ProductsTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbxÜrünTürü = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.stockAmountDataGridViewTextBoxColumn,
            this.explainDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.mainDataSet3;
            // 
            // mainDataSet3
            // 
            this.mainDataSet3.DataSetName = "MainDataSet3";
            this.mainDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(961, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 31);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Labelİsim
            // 
            this.Labelİsim.AutoSize = true;
            this.Labelİsim.Location = new System.Drawing.Point(506, 20);
            this.Labelİsim.Name = "Labelİsim";
            this.Labelİsim.Size = new System.Drawing.Size(42, 23);
            this.Labelİsim.TabIndex = 11;
            this.Labelİsim.Text = "isim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ürün Fiyatı:";
            // 
            // tbxgücelleÜrünİsmi
            // 
            this.tbxgücelleÜrünİsmi.Location = new System.Drawing.Point(842, 398);
            this.tbxgücelleÜrünİsmi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxgücelleÜrünİsmi.Name = "tbxgücelleÜrünİsmi";
            this.tbxgücelleÜrünİsmi.Size = new System.Drawing.Size(183, 30);
            this.tbxgücelleÜrünİsmi.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(722, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Stok Adedi:";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(842, 604);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(183, 33);
            this.btnGüncelle.TabIndex = 12;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 23);
            this.label6.TabIndex = 17;
            // 
            // tbxgüncelleÜrünAdedi
            // 
            this.tbxgüncelleÜrünAdedi.Location = new System.Drawing.Point(842, 474);
            this.tbxgüncelleÜrünAdedi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxgüncelleÜrünAdedi.Name = "tbxgüncelleÜrünAdedi";
            this.tbxgüncelleÜrünAdedi.Size = new System.Drawing.Size(183, 30);
            this.tbxgüncelleÜrünAdedi.TabIndex = 14;
            this.tbxgüncelleÜrünAdedi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxgüncelleÜrünAdedi_KeyPress_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(719, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ürün ismi:";
            // 
            // tbxgücelleÜrünFiyatı
            // 
            this.tbxgücelleÜrünFiyatı.Location = new System.Drawing.Point(842, 436);
            this.tbxgücelleÜrünFiyatı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxgücelleÜrünFiyatı.Name = "tbxgücelleÜrünFiyatı";
            this.tbxgücelleÜrünFiyatı.Size = new System.Drawing.Size(183, 30);
            this.tbxgücelleÜrünFiyatı.TabIndex = 15;
            this.tbxgücelleÜrünFiyatı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxgücelleÜrünFiyatı_KeyPress_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(455, 420);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 96);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "Açıklama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ürün Fiyatı:";
            // 
            // tbxÜrünİsmi
            // 
            this.tbxÜrünİsmi.Location = new System.Drawing.Point(153, 383);
            this.tbxÜrünİsmi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxÜrünİsmi.Name = "tbxÜrünİsmi";
            this.tbxÜrünİsmi.Size = new System.Drawing.Size(183, 30);
            this.tbxÜrünİsmi.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Stok Adedi:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(153, 604);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(183, 33);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 25;
            // 
            // tbxürünadedi
            // 
            this.tbxürünadedi.Location = new System.Drawing.Point(153, 532);
            this.tbxürünadedi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxürünadedi.Name = "tbxürünadedi";
            this.tbxürünadedi.Size = new System.Drawing.Size(183, 30);
            this.tbxürünadedi.TabIndex = 22;
            this.tbxürünadedi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxürünadedi_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ürün ismi:";
            // 
            // tbxfiyat
            // 
            this.tbxfiyat.Location = new System.Drawing.Point(153, 457);
            this.tbxfiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxfiyat.Name = "tbxfiyat";
            this.tbxfiyat.Size = new System.Drawing.Size(183, 30);
            this.tbxfiyat.TabIndex = 23;
            this.tbxfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxfiyat_KeyPress_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(704, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 25);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(15, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 25);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Sat";
            // 
            // tbxUrunTuru
            // 
            this.tbxUrunTuru.Location = new System.Drawing.Point(842, 512);
            this.tbxUrunTuru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxUrunTuru.Name = "tbxUrunTuru";
            this.tbxUrunTuru.Size = new System.Drawing.Size(183, 30);
            this.tbxUrunTuru.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(716, 614);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 23);
            this.label10.TabIndex = 35;
            this.label10.Text = "Ürün Türü:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(722, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 23);
            this.label11.TabIndex = 37;
            this.label11.Text = "Ürün Türü:";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbxÜrünTürü
            // 
            this.tbxÜrünTürü.Location = new System.Drawing.Point(455, 327);
            this.tbxÜrünTürü.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxÜrünTürü.Name = "tbxÜrünTürü";
            this.tbxÜrünTürü.Size = new System.Drawing.Size(183, 30);
            this.tbxÜrünTürü.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Ürün Türü:";
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // stockAmountDataGridViewTextBoxColumn
            // 
            this.stockAmountDataGridViewTextBoxColumn.DataPropertyName = "StockAmount";
            this.stockAmountDataGridViewTextBoxColumn.HeaderText = "StockAmount";
            this.stockAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockAmountDataGridViewTextBoxColumn.Name = "stockAmountDataGridViewTextBoxColumn";
            // 
            // explainDataGridViewTextBoxColumn
            // 
            this.explainDataGridViewTextBoxColumn.DataPropertyName = "Explain";
            this.explainDataGridViewTextBoxColumn.HeaderText = "Explain";
            this.explainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.explainDataGridViewTextBoxColumn.Name = "explainDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // FormÜrünSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 668);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxUrunTuru);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxÜrünTürü);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxÜrünİsmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxürünadedi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxfiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxgücelleÜrünİsmi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxgüncelleÜrünAdedi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxgücelleÜrünFiyatı);
            this.Controls.Add(this.Labelİsim);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormÜrünSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Sat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label Labelİsim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxgücelleÜrünİsmi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxgüncelleÜrünAdedi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxgücelleÜrünFiyatı;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxÜrünİsmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxürünadedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxfiyat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxUrunTuru;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private MainDataSet3 mainDataSet3;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MainDataSet3TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbxÜrünTürü;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}

