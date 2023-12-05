namespace list_uygulama_1473
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
            this.btnKişiEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnsilme = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAlfabetik = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKişiEkle
            // 
            this.btnKişiEkle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKişiEkle.Location = new System.Drawing.Point(196, 17);
            this.btnKişiEkle.Name = "btnKişiEkle";
            this.btnKişiEkle.Size = new System.Drawing.Size(146, 21);
            this.btnKişiEkle.TabIndex = 0;
            this.btnKişiEkle.Text = "kişi ekle";
            this.btnKişiEkle.UseVisualStyleBackColor = true;
            this.btnKişiEkle.Click += new System.EventHandler(this.btnKişiEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 319);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(12, 17);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 23);
            this.txtAd.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(348, 62);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(146, 21);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSirala.Location = new System.Drawing.Point(196, 62);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(146, 21);
            this.btnSirala.TabIndex = 4;
            this.btnSirala.Text = "sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(348, 99);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(146, 21);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "removeat ile silme";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnsilme
            // 
            this.btnsilme.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsilme.Location = new System.Drawing.Point(196, 99);
            this.btnsilme.Name = "btnsilme";
            this.btnsilme.Size = new System.Drawing.Size(146, 21);
            this.btnsilme.TabIndex = 6;
            this.btnsilme.Text = "remove ile silme";
            this.btnsilme.UseVisualStyleBackColor = true;
            this.btnsilme.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(348, 143);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 21);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAlfabetik
            // 
            this.btnAlfabetik.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlfabetik.Location = new System.Drawing.Point(196, 143);
            this.btnAlfabetik.Name = "btnAlfabetik";
            this.btnAlfabetik.Size = new System.Drawing.Size(146, 21);
            this.btnAlfabetik.TabIndex = 8;
            this.btnAlfabetik.Text = "ALFABETİK SIRALAMA ";
            this.btnAlfabetik.UseVisualStyleBackColor = true;
            this.btnAlfabetik.Click += new System.EventHandler(this.btnAlfabetik_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(348, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 21);
            this.button2.TabIndex = 9;
            this.button2.Text = "azaları sırala ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 19);
            this.button1.TabIndex = 10;
            this.button1.Text = "5 HARFİ OĞRWENCİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 24);
            this.button3.TabIndex = 11;
            this.button3.Text = "M HARFİ İLE BAŞLAYAN ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 19);
            this.button4.TabIndex = 12;
            this.button4.Text = "silme";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(344, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 19);
            this.button5.TabIndex = 13;
            this.button5.Text = "a harfi ile biten ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(502, 430);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAlfabetik);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnsilme);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKişiEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKişiEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnsilme;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAlfabetik;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

