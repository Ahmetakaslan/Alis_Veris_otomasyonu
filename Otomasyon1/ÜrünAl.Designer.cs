namespace Otomasyon1
{
    partial class FormÜrünAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÜrünAl));
            this.btnSil = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet1 = new Otomasyon1.MainDataSet1();
            this.tbxAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.Labelİsim = new System.Windows.Forms.Label();
            this.tbxAçıklama = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productsTableAdapter = new Otomasyon1.MainDataSet1TableAdapters.ProductsTableAdapter();
            this.groupBoxDoviz = new System.Windows.Forms.GroupBox();
            this.labelEuroAlis = new System.Windows.Forms.Label();
            this.labelDolarAlis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new Otomasyon1.RoundedPanel();
            this.SatinAldiklarim = new Otomasyon1.MyButton();
            this.roundedPanel1 = new Otomasyon1.RoundedPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSatınAl = new Otomasyon1.MyButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxAlÜrünİsmi = new System.Windows.Forms.TextBox();
            this.tbxAlınacakÜrünAdedi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).BeginInit();
            this.groupBoxDoviz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1204, 12);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(162, 45);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.mainDataSet1;
            // 
            // mainDataSet1
            // 
            this.mainDataSet1.DataSetName = "MainDataSet1";
            this.mainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxAra
            // 
            this.tbxAra.Location = new System.Drawing.Point(923, 12);
            this.tbxAra.Name = "tbxAra";
            this.tbxAra.Size = new System.Drawing.Size(158, 30);
            this.tbxAra.TabIndex = 16;
            this.tbxAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 17;
            this.label4.Tag = "";
            this.label4.Text = "Ara ";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // Labelİsim
            // 
            this.Labelİsim.AutoSize = true;
            this.Labelİsim.Location = new System.Drawing.Point(502, 50);
            this.Labelİsim.Name = "Labelİsim";
            this.Labelİsim.Size = new System.Drawing.Size(42, 23);
            this.Labelİsim.TabIndex = 18;
            this.Labelİsim.Text = "İsim";
            // 
            // tbxAçıklama
            // 
            this.tbxAçıklama.Enabled = false;
            this.tbxAçıklama.Location = new System.Drawing.Point(867, 405);
            this.tbxAçıklama.Multiline = true;
            this.tbxAçıklama.Name = "tbxAçıklama";
            this.tbxAçıklama.Size = new System.Drawing.Size(191, 116);
            this.tbxAçıklama.TabIndex = 19;
            this.tbxAçıklama.Text = "Açıklama:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxDoviz
            // 
            this.groupBoxDoviz.Controls.Add(this.labelEuroAlis);
            this.groupBoxDoviz.Controls.Add(this.labelDolarAlis);
            this.groupBoxDoviz.Controls.Add(this.label5);
            this.groupBoxDoviz.Controls.Add(this.label3);
            this.groupBoxDoviz.Location = new System.Drawing.Point(1, 421);
            this.groupBoxDoviz.Name = "groupBoxDoviz";
            this.groupBoxDoviz.Size = new System.Drawing.Size(272, 100);
            this.groupBoxDoviz.TabIndex = 21;
            this.groupBoxDoviz.TabStop = false;
            this.groupBoxDoviz.Text = "Döviz";
            // 
            // labelEuroAlis
            // 
            this.labelEuroAlis.AutoSize = true;
            this.labelEuroAlis.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuroAlis.Location = new System.Drawing.Point(97, 65);
            this.labelEuroAlis.Name = "labelEuroAlis";
            this.labelEuroAlis.Size = new System.Drawing.Size(28, 30);
            this.labelEuroAlis.TabIndex = 3;
            this.labelEuroAlis.Text = "...";
            // 
            // labelDolarAlis
            // 
            this.labelDolarAlis.AutoSize = true;
            this.labelDolarAlis.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolarAlis.Location = new System.Drawing.Point(97, 30);
            this.labelDolarAlis.Name = "labelDolarAlis";
            this.labelDolarAlis.Size = new System.Drawing.Size(28, 30);
            this.labelDolarAlis.TabIndex = 2;
            this.labelDolarAlis.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Euro Alış :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dolar Alış :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1, 92);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1093, 256);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 31);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tür:";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderColor = System.Drawing.Color.White;
            this.roundedPanel2.Controls.Add(this.SatinAldiklarim);
            this.roundedPanel2.Location = new System.Drawing.Point(895, 566);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Radius = 30;
            this.roundedPanel2.Size = new System.Drawing.Size(165, 77);
            this.roundedPanel2.TabIndex = 27;
            this.roundedPanel2.Thickness = 5F;
            // 
            // SatinAldiklarim
            // 
            this.SatinAldiklarim.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SatinAldiklarim.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.SatinAldiklarim.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SatinAldiklarim.BorderRadius = 30;
            this.SatinAldiklarim.BorderSize = 0;
            this.SatinAldiklarim.FlatAppearance.BorderSize = 0;
            this.SatinAldiklarim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SatinAldiklarim.ForeColor = System.Drawing.Color.White;
            this.SatinAldiklarim.Location = new System.Drawing.Point(0, 0);
            this.SatinAldiklarim.Name = "SatinAldiklarim";
            this.SatinAldiklarim.Size = new System.Drawing.Size(165, 77);
            this.SatinAldiklarim.TabIndex = 28;
            this.SatinAldiklarim.Text = "Satın Aldıklarım";
            this.SatinAldiklarim.TextColor = System.Drawing.Color.White;
            this.SatinAldiklarim.UseVisualStyleBackColor = false;
            this.SatinAldiklarim.Click += new System.EventHandler(this.SatinAldiklarim_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.groupBox4);
            this.roundedPanel1.Controls.Add(this.btnSatınAl);
            this.roundedPanel1.Controls.Add(this.groupBox5);
            this.roundedPanel1.Controls.Add(this.tbxAlÜrünİsmi);
            this.roundedPanel1.Controls.Add(this.tbxAlınacakÜrünAdedi);
            this.roundedPanel1.Location = new System.Drawing.Point(372, 398);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 40;
            this.roundedPanel1.Size = new System.Drawing.Size(390, 218);
            this.roundedPanel1.TabIndex = 26;
            this.roundedPanel1.Thickness = 5F;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(26, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 26);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ürün ismi  :";
            // 
            // btnSatınAl
            // 
            this.btnSatınAl.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSatınAl.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.btnSatınAl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSatınAl.BorderRadius = 20;
            this.btnSatınAl.BorderSize = 0;
            this.btnSatınAl.FlatAppearance.BorderSize = 0;
            this.btnSatınAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatınAl.ForeColor = System.Drawing.Color.White;
            this.btnSatınAl.Location = new System.Drawing.Point(194, 155);
            this.btnSatınAl.Name = "btnSatınAl";
            this.btnSatınAl.Size = new System.Drawing.Size(150, 60);
            this.btnSatınAl.TabIndex = 25;
            this.btnSatınAl.Text = "Satın AL";
            this.btnSatınAl.TextColor = System.Drawing.Color.White;
            this.btnSatınAl.UseVisualStyleBackColor = false;
            this.btnSatınAl.Click += new System.EventHandler(this.myButton1_Click);
            this.btnSatınAl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSatınAl_KeyDown);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(24, 101);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(128, 25);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(-2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 30);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ürün adedi:";
            // 
            // tbxAlÜrünİsmi
            // 
            this.tbxAlÜrünİsmi.Location = new System.Drawing.Point(174, 22);
            this.tbxAlÜrünİsmi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAlÜrünİsmi.Name = "tbxAlÜrünİsmi";
            this.tbxAlÜrünİsmi.Size = new System.Drawing.Size(183, 30);
            this.tbxAlÜrünİsmi.TabIndex = 25;
            // 
            // tbxAlınacakÜrünAdedi
            // 
            this.tbxAlınacakÜrünAdedi.Location = new System.Drawing.Point(174, 103);
            this.tbxAlınacakÜrünAdedi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAlınacakÜrünAdedi.Name = "tbxAlınacakÜrünAdedi";
            this.tbxAlınacakÜrünAdedi.Size = new System.Drawing.Size(183, 30);
            this.tbxAlınacakÜrünAdedi.TabIndex = 26;
            // 
            // FormÜrünAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 668);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBoxDoviz);
            this.Controls.Add(this.tbxAçıklama);
            this.Controls.Add(this.Labelİsim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormÜrünAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Al";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).EndInit();
            this.groupBoxDoviz.ResumeLayout(false);
            this.groupBoxDoviz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox tbxAra;
        private System.Windows.Forms.Label label4;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label Labelİsim;
        private System.Windows.Forms.TextBox tbxAçıklama;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MainDataSet1 mainDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MainDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxDoviz;
        private System.Windows.Forms.Label labelEuroAlis;
        private System.Windows.Forms.Label labelDolarAlis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private MyButton btnSatınAl;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxAlÜrünİsmi;
        private System.Windows.Forms.TextBox tbxAlınacakÜrünAdedi;
        private RoundedPanel roundedPanel2;
        private MyButton SatinAldiklarim;
    }
}