namespace mustafabukulmez_com_dersler._021_Rastgele_Sifre_Olusturma
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_sifre_karakter_adet = new System.Windows.Forms.NumericUpDown();
            this.cmb_zorluk = new System.Windows.Forms.ComboBox();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.txt_olusan_sfire = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sifre_karakter_adet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oluşan Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre Kaç Karakter Olacak?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zorluk Seçin";
            // 
            // nud_sifre_karakter_adet
            // 
            this.nud_sifre_karakter_adet.Location = new System.Drawing.Point(165, 49);
            this.nud_sifre_karakter_adet.Name = "nud_sifre_karakter_adet";
            this.nud_sifre_karakter_adet.Size = new System.Drawing.Size(120, 20);
            this.nud_sifre_karakter_adet.TabIndex = 1;
            this.nud_sifre_karakter_adet.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cmb_zorluk
            // 
            this.cmb_zorluk.FormattingEnabled = true;
            this.cmb_zorluk.Items.AddRange(new object[] {
            "Zorluk 1",
            "Zorluk 2",
            "Zorluk 3"});
            this.cmb_zorluk.Location = new System.Drawing.Point(165, 22);
            this.cmb_zorluk.Name = "cmb_zorluk";
            this.cmb_zorluk.Size = new System.Drawing.Size(182, 21);
            this.cmb_zorluk.TabIndex = 0;
            // 
            // btn_olustur
            // 
            this.btn_olustur.Location = new System.Drawing.Point(625, 25);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(138, 83);
            this.btn_olustur.TabIndex = 3;
            this.btn_olustur.Text = "Oluştur";
            this.btn_olustur.UseVisualStyleBackColor = true;
            this.btn_olustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_olusan_sfire
            // 
            this.txt_olusan_sfire.Location = new System.Drawing.Point(165, 75);
            this.txt_olusan_sfire.Multiline = true;
            this.txt_olusan_sfire.Name = "txt_olusan_sfire";
            this.txt_olusan_sfire.Size = new System.Drawing.Size(454, 33);
            this.txt_olusan_sfire.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(63, 189);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(512, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2019/03/15/c-rastgele-sifre-olusturma/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(62, 160);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(271, 24);
            this.label12.TabIndex = 7;
            this.label12.Text = "C# Rastgele Şifre Oluşturma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 261);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_sifre_karakter_adet);
            this.Controls.Add(this.cmb_zorluk);
            this.Controls.Add(this.btn_olustur);
            this.Controls.Add(this.txt_olusan_sfire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_sifre_karakter_adet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_sifre_karakter_adet;
        private System.Windows.Forms.ComboBox cmb_zorluk;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.TextBox txt_olusan_sfire;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
    }
}