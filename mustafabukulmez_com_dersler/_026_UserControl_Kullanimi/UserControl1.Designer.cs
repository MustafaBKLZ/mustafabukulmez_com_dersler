namespace mustafabukulmez_com_dersler._026_UserControl_Kullanimi
{
    partial class UserControl1
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kulkod = new System.Windows.Forms.TextBox();
            this.btn_kullanici_sec = new System.Windows.Forms.Button();
            this.txt_kul_adi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı";
            // 
            // txt_kulkod
            // 
            this.txt_kulkod.Location = new System.Drawing.Point(65, 4);
            this.txt_kulkod.Name = "txt_kulkod";
            this.txt_kulkod.Size = new System.Drawing.Size(100, 20);
            this.txt_kulkod.TabIndex = 1;
            // 
            // btn_kullanici_sec
            // 
            this.btn_kullanici_sec.Location = new System.Drawing.Point(362, 3);
            this.btn_kullanici_sec.Name = "btn_kullanici_sec";
            this.btn_kullanici_sec.Size = new System.Drawing.Size(120, 23);
            this.btn_kullanici_sec.TabIndex = 3;
            this.btn_kullanici_sec.Text = "Kullanıcı Seç";
            this.btn_kullanici_sec.UseVisualStyleBackColor = true;
            this.btn_kullanici_sec.Click += new System.EventHandler(this.btn_kullanici_sec_Click);
            // 
            // txt_kul_adi
            // 
            this.txt_kul_adi.Location = new System.Drawing.Point(171, 4);
            this.txt_kul_adi.Name = "txt_kul_adi";
            this.txt_kul_adi.Size = new System.Drawing.Size(185, 20);
            this.txt_kul_adi.TabIndex = 4;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_kul_adi);
            this.Controls.Add(this.btn_kullanici_sec);
            this.Controls.Add(this.txt_kulkod);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(539, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_kulkod;
        public System.Windows.Forms.TextBox txt_kul_adi;
        public System.Windows.Forms.Button btn_kullanici_sec;
    }
}
