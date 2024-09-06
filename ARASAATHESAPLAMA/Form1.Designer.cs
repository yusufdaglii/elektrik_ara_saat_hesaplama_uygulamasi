
namespace ARASAATHESAPLAMA
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yapıcı = new System.Windows.Forms.Label();
            this.MENDERESTUTAR = new System.Windows.Forms.TextBox();
            this.ADEMTUTAR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BUAYENDEKS = new System.Windows.Forms.TextBox();
            this.TEKZAMANENDEKSBOX = new System.Windows.Forms.TextBox();
            this.GEÇENAYENDEKS = new System.Windows.Forms.TextBox();
            this.FATURABOX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.yapıcı);
            this.groupBox1.Controls.Add(this.MENDERESTUTAR);
            this.groupBox1.Controls.Add(this.ADEMTUTAR);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BUAYENDEKS);
            this.groupBox1.Controls.Add(this.TEKZAMANENDEKSBOX);
            this.groupBox1.Controls.Add(this.GEÇENAYENDEKS);
            this.groupBox1.Controls.Add(this.FATURABOX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(296, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARASAAT HESAPLAMA";
            // 
            // yapıcı
            // 
            this.yapıcı.AutoSize = true;
            this.yapıcı.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yapıcı.Location = new System.Drawing.Point(675, 491);
            this.yapıcı.Name = "yapıcı";
            this.yapıcı.Size = new System.Drawing.Size(93, 23);
            this.yapıcı.TabIndex = 26;
            this.yapıcı.Text = "BY DAĞLI";
            this.yapıcı.Visible = false;
            // 
            // MENDERESTUTAR
            // 
            this.MENDERESTUTAR.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MENDERESTUTAR.Location = new System.Drawing.Point(397, 418);
            this.MENDERESTUTAR.Multiline = true;
            this.MENDERESTUTAR.Name = "MENDERESTUTAR";
            this.MENDERESTUTAR.Size = new System.Drawing.Size(315, 31);
            this.MENDERESTUTAR.TabIndex = 25;
            // 
            // ADEMTUTAR
            // 
            this.ADEMTUTAR.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ADEMTUTAR.Location = new System.Drawing.Point(396, 351);
            this.ADEMTUTAR.Multiline = true;
            this.ADEMTUTAR.Name = "ADEMTUTAR";
            this.ADEMTUTAR.Size = new System.Drawing.Size(316, 31);
            this.ADEMTUTAR.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(36, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "MENDERES DAĞLI İÇİN ÖDENECEK TUTAR...:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(72, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "ADEM DAĞLI İÇİN ÖDENECEK TUTAR...:";
            // 
            // BUAYENDEKS
            // 
            this.BUAYENDEKS.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BUAYENDEKS.Location = new System.Drawing.Point(396, 141);
            this.BUAYENDEKS.Multiline = true;
            this.BUAYENDEKS.Name = "BUAYENDEKS";
            this.BUAYENDEKS.Size = new System.Drawing.Size(223, 31);
            this.BUAYENDEKS.TabIndex = 21;
            // 
            // TEKZAMANENDEKSBOX
            // 
            this.TEKZAMANENDEKSBOX.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TEKZAMANENDEKSBOX.Location = new System.Drawing.Point(398, 92);
            this.TEKZAMANENDEKSBOX.Multiline = true;
            this.TEKZAMANENDEKSBOX.Name = "TEKZAMANENDEKSBOX";
            this.TEKZAMANENDEKSBOX.Size = new System.Drawing.Size(223, 31);
            this.TEKZAMANENDEKSBOX.TabIndex = 20;
            // 
            // GEÇENAYENDEKS
            // 
            this.GEÇENAYENDEKS.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GEÇENAYENDEKS.Location = new System.Drawing.Point(396, 186);
            this.GEÇENAYENDEKS.Multiline = true;
            this.GEÇENAYENDEKS.Name = "GEÇENAYENDEKS";
            this.GEÇENAYENDEKS.Size = new System.Drawing.Size(223, 31);
            this.GEÇENAYENDEKS.TabIndex = 19;
            // 
            // FATURABOX
            // 
            this.FATURABOX.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FATURABOX.Location = new System.Drawing.Point(398, 45);
            this.FATURABOX.Multiline = true;
            this.FATURABOX.Name = "FATURABOX";
            this.FATURABOX.Size = new System.Drawing.Size(223, 31);
            this.FATURABOX.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "GEÇEN AYIN ARASAAT ENDEKSİNİ GİRİNİZ...:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "BU AYIN ARASAAT ENDEKSİNİZ GİRİNİZ...:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(137, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "TEK ZAMAN ENDEKSİ GİRİNİZ...:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(162, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "FATURA TUTARINI GİRİNİZ...:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(396, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 64);
            this.button1.TabIndex = 13;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1278, 707);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MENDERESTUTAR;
        private System.Windows.Forms.TextBox ADEMTUTAR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BUAYENDEKS;
        private System.Windows.Forms.TextBox TEKZAMANENDEKSBOX;
        private System.Windows.Forms.TextBox GEÇENAYENDEKS;
        private System.Windows.Forms.TextBox FATURABOX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label yapıcı;
    }
}

