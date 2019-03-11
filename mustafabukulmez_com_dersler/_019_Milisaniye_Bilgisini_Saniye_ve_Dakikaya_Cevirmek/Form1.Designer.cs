namespace mustafabukulmez_com_dersler._019_Milisaniye_Bilgisini_Saniye_ve_Dakikaya_Cevirmek
{
    //https://mustafabukulmez.com/2019/03/11/c-milisaniye-convert-saniye-ve-dakikaya-cevirmek/
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mili_saniye = new System.Windows.Forms.TextBox();
            this.btn_cevir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_gun = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Milisaniye Girin";
            // 
            // txt_mili_saniye
            // 
            this.txt_mili_saniye.Location = new System.Drawing.Point(94, 41);
            this.txt_mili_saniye.Name = "txt_mili_saniye";
            this.txt_mili_saniye.Size = new System.Drawing.Size(269, 20);
            this.txt_mili_saniye.TabIndex = 1;
            // 
            // btn_cevir
            // 
            this.btn_cevir.Location = new System.Drawing.Point(369, 41);
            this.btn_cevir.Name = "btn_cevir";
            this.btn_cevir.Size = new System.Drawing.Size(75, 23);
            this.btn_cevir.TabIndex = 2;
            this.btn_cevir.Text = "Çevir";
            this.btn_cevir.UseVisualStyleBackColor = true;
            this.btn_cevir.Click += new System.EventHandler(this.btn_cevir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dakika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Saniye";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Location = new System.Drawing.Point(170, 128);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(16, 13);
            this.lbl_saniye.TabIndex = 11;
            this.lbl_saniye.Text = "...";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Location = new System.Drawing.Point(170, 113);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(16, 13);
            this.lbl_dakika.TabIndex = 10;
            this.lbl_dakika.Text = "...";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(170, 98);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(16, 13);
            this.lbl_saat.TabIndex = 9;
            this.lbl_saat.Text = "...";
            // 
            // lbl_gun
            // 
            this.lbl_gun.AutoSize = true;
            this.lbl_gun.Location = new System.Drawing.Point(170, 83);
            this.lbl_gun.Name = "lbl_gun";
            this.lbl_gun.Size = new System.Drawing.Size(16, 13);
            this.lbl_gun.TabIndex = 8;
            this.lbl_gun.Text = "...";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(42, 204);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(674, 17);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2019/03/11/c-milisaniye-convert-saniye-ve-dakikaya-ce" +
    "virmek/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(41, 175);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(504, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "C# Milisaniye Convert – Saniye ve Dakikaya Çevirmek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 271);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.lbl_gun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cevir);
            this.Controls.Add(this.txt_mili_saniye);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Milisaniye Bilgisini Saniye ve Dakikaya Çevirmek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //https://mustafabukulmez.com/2019/03/11/c-milisaniye-convert-saniye-ve-dakikaya-cevirmek/
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mili_saniye;
        private System.Windows.Forms.Button btn_cevir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_gun;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
    }
}