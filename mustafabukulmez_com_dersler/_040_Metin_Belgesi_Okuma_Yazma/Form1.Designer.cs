
namespace mustafabukulmez_com_dersler._040_Metin_Belgesi_Okuma_Yazma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_yazilacak_metin = new System.Windows.Forms.TextBox();
            this.btn_yaz = new System.Windows.Forms.Button();
            this.btn_oku = new System.Windows.Forms.Button();
            this.txt_okunan_metin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_altina_ekle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazılacak Metin";
            // 
            // txt_yazilacak_metin
            // 
            this.txt_yazilacak_metin.Location = new System.Drawing.Point(12, 28);
            this.txt_yazilacak_metin.Multiline = true;
            this.txt_yazilacak_metin.Name = "txt_yazilacak_metin";
            this.txt_yazilacak_metin.Size = new System.Drawing.Size(256, 194);
            this.txt_yazilacak_metin.TabIndex = 1;
            // 
            // btn_yaz
            // 
            this.btn_yaz.Location = new System.Drawing.Point(274, 28);
            this.btn_yaz.Name = "btn_yaz";
            this.btn_yaz.Size = new System.Drawing.Size(87, 42);
            this.btn_yaz.TabIndex = 2;
            this.btn_yaz.Text = "Yaz";
            this.btn_yaz.UseVisualStyleBackColor = true;
            this.btn_yaz.Click += new System.EventHandler(this.btn_yaz_Click);
            // 
            // btn_oku
            // 
            this.btn_oku.Location = new System.Drawing.Point(629, 28);
            this.btn_oku.Name = "btn_oku";
            this.btn_oku.Size = new System.Drawing.Size(87, 42);
            this.btn_oku.TabIndex = 3;
            this.btn_oku.Text = "Oku";
            this.btn_oku.UseVisualStyleBackColor = true;
            this.btn_oku.Click += new System.EventHandler(this.btn_oku_Click);
            // 
            // txt_okunan_metin
            // 
            this.txt_okunan_metin.Location = new System.Drawing.Point(367, 28);
            this.txt_okunan_metin.Multiline = true;
            this.txt_okunan_metin.Name = "txt_okunan_metin";
            this.txt_okunan_metin.Size = new System.Drawing.Size(256, 194);
            this.txt_okunan_metin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Okunan Metin";
            // 
            // chk_altina_ekle
            // 
            this.chk_altina_ekle.AutoSize = true;
            this.chk_altina_ekle.Location = new System.Drawing.Point(274, 76);
            this.chk_altina_ekle.Name = "chk_altina_ekle";
            this.chk_altina_ekle.Size = new System.Drawing.Size(76, 17);
            this.chk_altina_ekle.TabIndex = 6;
            this.chk_altina_ekle.Text = "Altına Ekle";
            this.chk_altina_ekle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 307);
            this.Controls.Add(this.chk_altina_ekle);
            this.Controls.Add(this.txt_okunan_metin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_oku);
            this.Controls.Add(this.btn_yaz);
            this.Controls.Add(this.txt_yazilacak_metin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_yazilacak_metin;
        private System.Windows.Forms.Button btn_yaz;
        private System.Windows.Forms.Button btn_oku;
        private System.Windows.Forms.TextBox txt_okunan_metin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_altina_ekle;
    }
}