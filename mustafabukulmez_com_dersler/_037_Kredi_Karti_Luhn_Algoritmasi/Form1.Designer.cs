namespace mustafabukulmez_com_dersler._037_Kredi_Karti_Luhn_Algoritmasi
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_kontrol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_card_no = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(22, 145);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(614, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2020/04/08/c-kredi-karti-dogrulama-luhn-algoritmasi/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(21, 116);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(419, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "C# Kredi Kartı Doğrulama - Luhn Algoritması";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(109, 65);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(47, 13);
            this.lbl_sonuc.TabIndex = 10;
            this.lbl_sonuc.Text = "Sonuç : ";
            // 
            // btn_kontrol
            // 
            this.btn_kontrol.Location = new System.Drawing.Point(325, 31);
            this.btn_kontrol.Name = "btn_kontrol";
            this.btn_kontrol.Size = new System.Drawing.Size(75, 23);
            this.btn_kontrol.TabIndex = 9;
            this.btn_kontrol.Text = "Kontol Et";
            this.btn_kontrol.UseVisualStyleBackColor = true;
            this.btn_kontrol.Click += new System.EventHandler(this.btn_kontrol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kredi Kart No";
            // 
            // txt_card_no
            // 
            this.txt_card_no.Location = new System.Drawing.Point(112, 32);
            this.txt_card_no.Name = "txt_card_no";
            this.txt_card_no.Size = new System.Drawing.Size(207, 20);
            this.txt_card_no.TabIndex = 7;
            this.txt_card_no.Text = "1234-5678-9876-5432";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 219);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_kontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_card_no);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Button btn_kontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_card_no;
    }
}