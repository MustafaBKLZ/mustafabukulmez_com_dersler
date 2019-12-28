namespace mustafabukulmez_com_dersler._030_Process_islemleri_Neler_Yapılabilir
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
            this.btn_klasor_ac = new System.Windows.Forms.Button();
            this.btn_dosya_ac = new System.Windows.Forms.Button();
            this.txt_klasor = new System.Windows.Forms.TextBox();
            this.txt_dosya = new System.Windows.Forms.TextBox();
            this.txt_google_ara = new System.Windows.Forms.TextBox();
            this.btn_google = new System.Windows.Forms.Button();
            this.txt_word_ile = new System.Windows.Forms.TextBox();
            this.btn_word = new System.Windows.Forms.Button();
            this.btn_islem_kapat = new System.Windows.Forms.Button();
            this.btn_islemler_liste = new System.Windows.Forms.Button();
            this.list_islemler = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.list_islemler_adlari = new System.Windows.Forms.ListBox();
            this.btn_islemler_adi = new System.Windows.Forms.Button();
            this.txt_aranacak_islem = new System.Windows.Forms.TextBox();
            this.txt_id_ile_kapat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_klasor_ac
            // 
            this.btn_klasor_ac.Location = new System.Drawing.Point(12, 69);
            this.btn_klasor_ac.Name = "btn_klasor_ac";
            this.btn_klasor_ac.Size = new System.Drawing.Size(163, 23);
            this.btn_klasor_ac.TabIndex = 0;
            this.btn_klasor_ac.Text = "Klasör Aç";
            this.btn_klasor_ac.UseVisualStyleBackColor = true;
            this.btn_klasor_ac.Click += new System.EventHandler(this.btn_klasor_ac_Click);
            // 
            // btn_dosya_ac
            // 
            this.btn_dosya_ac.Location = new System.Drawing.Point(12, 99);
            this.btn_dosya_ac.Name = "btn_dosya_ac";
            this.btn_dosya_ac.Size = new System.Drawing.Size(163, 23);
            this.btn_dosya_ac.TabIndex = 1;
            this.btn_dosya_ac.Text = "Dosya Aç";
            this.btn_dosya_ac.UseVisualStyleBackColor = true;
            this.btn_dosya_ac.Click += new System.EventHandler(this.btn_dosya_ac_Click);
            // 
            // txt_klasor
            // 
            this.txt_klasor.Location = new System.Drawing.Point(181, 70);
            this.txt_klasor.Name = "txt_klasor";
            this.txt_klasor.Size = new System.Drawing.Size(231, 20);
            this.txt_klasor.TabIndex = 2;
            this.txt_klasor.Text = "C:\\\\";
            // 
            // txt_dosya
            // 
            this.txt_dosya.Location = new System.Drawing.Point(181, 100);
            this.txt_dosya.Name = "txt_dosya";
            this.txt_dosya.Size = new System.Drawing.Size(231, 20);
            this.txt_dosya.TabIndex = 3;
            // 
            // txt_google_ara
            // 
            this.txt_google_ara.Location = new System.Drawing.Point(181, 129);
            this.txt_google_ara.Name = "txt_google_ara";
            this.txt_google_ara.Size = new System.Drawing.Size(231, 20);
            this.txt_google_ara.TabIndex = 5;
            this.txt_google_ara.Text = "mustafabükülmez";
            // 
            // btn_google
            // 
            this.btn_google.Location = new System.Drawing.Point(12, 128);
            this.btn_google.Name = "btn_google";
            this.btn_google.Size = new System.Drawing.Size(163, 23);
            this.btn_google.TabIndex = 4;
            this.btn_google.Text = "Google İle Ara";
            this.btn_google.UseVisualStyleBackColor = true;
            this.btn_google.Click += new System.EventHandler(this.btn_google_Click);
            // 
            // txt_word_ile
            // 
            this.txt_word_ile.Location = new System.Drawing.Point(181, 158);
            this.txt_word_ile.Name = "txt_word_ile";
            this.txt_word_ile.Size = new System.Drawing.Size(231, 20);
            this.txt_word_ile.TabIndex = 7;
            // 
            // btn_word
            // 
            this.btn_word.Location = new System.Drawing.Point(12, 157);
            this.btn_word.Name = "btn_word";
            this.btn_word.Size = new System.Drawing.Size(163, 23);
            this.btn_word.TabIndex = 6;
            this.btn_word.Text = "Word İle Aç";
            this.btn_word.UseVisualStyleBackColor = true;
            this.btn_word.Click += new System.EventHandler(this.btn_word_Click);
            // 
            // btn_islem_kapat
            // 
            this.btn_islem_kapat.Location = new System.Drawing.Point(12, 420);
            this.btn_islem_kapat.Name = "btn_islem_kapat";
            this.btn_islem_kapat.Size = new System.Drawing.Size(163, 23);
            this.btn_islem_kapat.TabIndex = 8;
            this.btn_islem_kapat.Text = "İşlem Kapat";
            this.btn_islem_kapat.UseVisualStyleBackColor = true;
            this.btn_islem_kapat.Click += new System.EventHandler(this.btn_islem_kapat_Click);
            // 
            // btn_islemler_liste
            // 
            this.btn_islemler_liste.Location = new System.Drawing.Point(12, 186);
            this.btn_islemler_liste.Name = "btn_islemler_liste";
            this.btn_islemler_liste.Size = new System.Drawing.Size(254, 23);
            this.btn_islemler_liste.TabIndex = 10;
            this.btn_islemler_liste.Text = "İşlemler Listesi (ID)";
            this.btn_islemler_liste.UseVisualStyleBackColor = true;
            this.btn_islemler_liste.Click += new System.EventHandler(this.btn_islemler_liste_Click);
            // 
            // list_islemler
            // 
            this.list_islemler.FormattingEnabled = true;
            this.list_islemler.Location = new System.Drawing.Point(12, 215);
            this.list_islemler.Name = "list_islemler";
            this.list_islemler.Size = new System.Drawing.Size(254, 199);
            this.list_islemler.TabIndex = 11;
            this.list_islemler.SelectedIndexChanged += new System.EventHandler(this.list_islemler_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 38);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(683, 17);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2019/12/24/c-list-ogelerini-datagridview-ve-listbox-a" +
    "-baglamak/";
            this.linkLabel1.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(378, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "C# Process İşlemleri - Neler Yapılabilir?";
            this.label12.Visible = false;
            // 
            // list_islemler_adlari
            // 
            this.list_islemler_adlari.FormattingEnabled = true;
            this.list_islemler_adlari.Location = new System.Drawing.Point(272, 215);
            this.list_islemler_adlari.Name = "list_islemler_adlari";
            this.list_islemler_adlari.Size = new System.Drawing.Size(390, 199);
            this.list_islemler_adlari.TabIndex = 19;
            // 
            // btn_islemler_adi
            // 
            this.btn_islemler_adi.Location = new System.Drawing.Point(272, 186);
            this.btn_islemler_adi.Name = "btn_islemler_adi";
            this.btn_islemler_adi.Size = new System.Drawing.Size(390, 23);
            this.btn_islemler_adi.TabIndex = 20;
            this.btn_islemler_adi.Text = "İşlemler Listesi (Name)";
            this.btn_islemler_adi.UseVisualStyleBackColor = true;
            this.btn_islemler_adi.Click += new System.EventHandler(this.btn_islemler_adi_Click);
            // 
            // txt_aranacak_islem
            // 
            this.txt_aranacak_islem.Location = new System.Drawing.Point(668, 186);
            this.txt_aranacak_islem.Name = "txt_aranacak_islem";
            this.txt_aranacak_islem.Size = new System.Drawing.Size(103, 20);
            this.txt_aranacak_islem.TabIndex = 21;
            this.txt_aranacak_islem.Text = "chrome";
            // 
            // txt_id_ile_kapat
            // 
            this.txt_id_ile_kapat.Location = new System.Drawing.Point(181, 422);
            this.txt_id_ile_kapat.Name = "txt_id_ile_kapat";
            this.txt_id_ile_kapat.Size = new System.Drawing.Size(231, 20);
            this.txt_id_ile_kapat.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 572);
            this.Controls.Add(this.txt_id_ile_kapat);
            this.Controls.Add(this.txt_aranacak_islem);
            this.Controls.Add(this.btn_islemler_adi);
            this.Controls.Add(this.list_islemler_adlari);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.list_islemler);
            this.Controls.Add(this.btn_islemler_liste);
            this.Controls.Add(this.btn_islem_kapat);
            this.Controls.Add(this.txt_word_ile);
            this.Controls.Add(this.btn_word);
            this.Controls.Add(this.txt_google_ara);
            this.Controls.Add(this.btn_google);
            this.Controls.Add(this.txt_dosya);
            this.Controls.Add(this.txt_klasor);
            this.Controls.Add(this.btn_dosya_ac);
            this.Controls.Add(this.btn_klasor_ac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_klasor_ac;
        private System.Windows.Forms.Button btn_dosya_ac;
        private System.Windows.Forms.TextBox txt_klasor;
        private System.Windows.Forms.TextBox txt_dosya;
        private System.Windows.Forms.TextBox txt_google_ara;
        private System.Windows.Forms.Button btn_google;
        private System.Windows.Forms.TextBox txt_word_ile;
        private System.Windows.Forms.Button btn_word;
        private System.Windows.Forms.Button btn_islem_kapat;
        private System.Windows.Forms.Button btn_islemler_liste;
        private System.Windows.Forms.ListBox list_islemler;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox list_islemler_adlari;
        private System.Windows.Forms.Button btn_islemler_adi;
        private System.Windows.Forms.TextBox txt_aranacak_islem;
        private System.Windows.Forms.TextBox txt_id_ile_kapat;
    }
}