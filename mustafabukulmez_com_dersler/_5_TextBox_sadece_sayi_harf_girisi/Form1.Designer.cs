namespace mustafabukulmez_com_dersler._5_TextBox_sadece_sayi_harf_girisi
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
            this.txt_sadece_sayi = new System.Windows.Forms.TextBox();
            this.txt_sadece_harf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ozel_giremez = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bosluk_giremez = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_sadece_sayi
            // 
            this.txt_sadece_sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sadece_sayi.Location = new System.Drawing.Point(54, 149);
            this.txt_sadece_sayi.Name = "txt_sadece_sayi";
            this.txt_sadece_sayi.Size = new System.Drawing.Size(225, 27);
            this.txt_sadece_sayi.TabIndex = 0;
            this.txt_sadece_sayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_sayi_KeyPress);
            // 
            // txt_sadece_harf
            // 
            this.txt_sadece_harf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sadece_harf.Location = new System.Drawing.Point(54, 232);
            this.txt_sadece_harf.Name = "txt_sadece_harf";
            this.txt_sadece_harf.Size = new System.Drawing.Size(225, 27);
            this.txt_sadece_harf.TabIndex = 1;
            this.txt_sadece_harf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_harf_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sadece Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sadece Harf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Özel Karakter Giremez";
            // 
            // txt_ozel_giremez
            // 
            this.txt_ozel_giremez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ozel_giremez.Location = new System.Drawing.Point(356, 149);
            this.txt_ozel_giremez.Name = "txt_ozel_giremez";
            this.txt_ozel_giremez.Size = new System.Drawing.Size(225, 27);
            this.txt_ozel_giremez.TabIndex = 4;
            this.txt_ozel_giremez.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ozel_giremez_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Boşluk Giremez";
            // 
            // txt_bosluk_giremez
            // 
            this.txt_bosluk_giremez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bosluk_giremez.Location = new System.Drawing.Point(356, 232);
            this.txt_bosluk_giremez.Name = "txt_bosluk_giremez";
            this.txt_bosluk_giremez.Size = new System.Drawing.Size(225, 27);
            this.txt_bosluk_giremez.TabIndex = 6;
            this.txt_bosluk_giremez.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bosluk_giremez_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(54, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(456, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "C# Textbox Sadece Sayı Harf Girişi Yaptırmak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 321);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_bosluk_giremez);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ozel_giremez);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sadece_harf);
            this.Controls.Add(this.txt_sadece_sayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sadece_sayi;
        private System.Windows.Forms.TextBox txt_sadece_harf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ozel_giremez;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bosluk_giremez;
        private System.Windows.Forms.Label label5;
    }
}