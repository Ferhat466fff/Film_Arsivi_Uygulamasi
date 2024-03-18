namespace Film_arsıvım
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_ÇIKIŞ = new System.Windows.Forms.Button();
            this.btn_RENK_DEĞİŞ = new System.Windows.Forms.Button();
            this.btn_HAKKIMIZDA = new System.Windows.Forms.Button();
            this.btn_TAM_EKRAN = new System.Windows.Forms.Button();
            this.btn_KAYDET = new System.Windows.Forms.Button();
            this.txt_LINK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_KATEGORII = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_FİLM_AD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1725, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİNEMA KOLTUK YAZILIM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1120, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(394, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 480);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(426, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(832, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 480);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 26);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(636, 451);
            this.webBrowser1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btn_KAYDET);
            this.groupBox3.Controls.Add(this.txt_LINK);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_KATEGORII);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_FİLM_AD);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(20, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 480);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Film";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_ÇIKIŞ);
            this.groupBox4.Controls.Add(this.btn_RENK_DEĞİŞ);
            this.groupBox4.Controls.Add(this.btn_HAKKIMIZDA);
            this.groupBox4.Controls.Add(this.btn_TAM_EKRAN);
            this.groupBox4.Location = new System.Drawing.Point(6, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 225);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // btn_ÇIKIŞ
            // 
            this.btn_ÇIKIŞ.Location = new System.Drawing.Point(6, 180);
            this.btn_ÇIKIŞ.Name = "btn_ÇIKIŞ";
            this.btn_ÇIKIŞ.Size = new System.Drawing.Size(329, 45);
            this.btn_ÇIKIŞ.TabIndex = 10;
            this.btn_ÇIKIŞ.Text = "Çıkış";
            this.btn_ÇIKIŞ.UseVisualStyleBackColor = true;
            this.btn_ÇIKIŞ.Click += new System.EventHandler(this.btn_ÇIKIŞ_Click);
            // 
            // btn_RENK_DEĞİŞ
            // 
            this.btn_RENK_DEĞİŞ.Location = new System.Drawing.Point(6, 131);
            this.btn_RENK_DEĞİŞ.Name = "btn_RENK_DEĞİŞ";
            this.btn_RENK_DEĞİŞ.Size = new System.Drawing.Size(329, 45);
            this.btn_RENK_DEĞİŞ.TabIndex = 9;
            this.btn_RENK_DEĞİŞ.Text = "Renk Değiştir";
            this.btn_RENK_DEĞİŞ.UseVisualStyleBackColor = true;
            this.btn_RENK_DEĞİŞ.Click += new System.EventHandler(this.btn_RENK_DEĞİŞ_Click);
            // 
            // btn_HAKKIMIZDA
            // 
            this.btn_HAKKIMIZDA.Location = new System.Drawing.Point(6, 80);
            this.btn_HAKKIMIZDA.Name = "btn_HAKKIMIZDA";
            this.btn_HAKKIMIZDA.Size = new System.Drawing.Size(329, 45);
            this.btn_HAKKIMIZDA.TabIndex = 8;
            this.btn_HAKKIMIZDA.Text = "Hakkımızda";
            this.btn_HAKKIMIZDA.UseVisualStyleBackColor = true;
            this.btn_HAKKIMIZDA.Click += new System.EventHandler(this.btn_HAKKIMIZDA_Click);
            // 
            // btn_TAM_EKRAN
            // 
            this.btn_TAM_EKRAN.Location = new System.Drawing.Point(6, 29);
            this.btn_TAM_EKRAN.Name = "btn_TAM_EKRAN";
            this.btn_TAM_EKRAN.Size = new System.Drawing.Size(329, 45);
            this.btn_TAM_EKRAN.TabIndex = 7;
            this.btn_TAM_EKRAN.Text = "Tam Ekran";
            this.btn_TAM_EKRAN.UseVisualStyleBackColor = true;
            // 
            // btn_KAYDET
            // 
            this.btn_KAYDET.Location = new System.Drawing.Point(109, 189);
            this.btn_KAYDET.Name = "btn_KAYDET";
            this.btn_KAYDET.Size = new System.Drawing.Size(214, 45);
            this.btn_KAYDET.TabIndex = 6;
            this.btn_KAYDET.Text = "Kaydet";
            this.btn_KAYDET.UseVisualStyleBackColor = true;
            this.btn_KAYDET.Click += new System.EventHandler(this.btn_KAYDET_Click);
            // 
            // txt_LINK
            // 
            this.txt_LINK.Location = new System.Drawing.Point(109, 141);
            this.txt_LINK.Name = "txt_LINK";
            this.txt_LINK.Size = new System.Drawing.Size(214, 30);
            this.txt_LINK.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Link:";
            // 
            // txt_KATEGORII
            // 
            this.txt_KATEGORII.Location = new System.Drawing.Point(109, 89);
            this.txt_KATEGORII.Name = "txt_KATEGORII";
            this.txt_KATEGORII.Size = new System.Drawing.Size(214, 30);
            this.txt_KATEGORII.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori:";
            // 
            // txt_FİLM_AD
            // 
            this.txt_FİLM_AD.Location = new System.Drawing.Point(109, 39);
            this.txt_FİLM_AD.Name = "txt_FİLM_AD";
            this.txt_FİLM_AD.Size = new System.Drawing.Size(214, 30);
            this.txt_FİLM_AD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Ad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1725, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_ÇIKIŞ;
        private System.Windows.Forms.Button btn_RENK_DEĞİŞ;
        private System.Windows.Forms.Button btn_HAKKIMIZDA;
        private System.Windows.Forms.Button btn_TAM_EKRAN;
        private System.Windows.Forms.Button btn_KAYDET;
        private System.Windows.Forms.TextBox txt_LINK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_KATEGORII;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_FİLM_AD;
        private System.Windows.Forms.Label label2;
    }
}

