namespace mustafabukulmez_com_dersler._011_Sayilari_Roma_Rakamina_Cevir
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
            this.txt_sayi_gir = new System.Windows.Forms.TextBox();
            this.btn_cevir = new System.Windows.Forms.Button();
            this.txt_cevir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir Sayı Giriniz";
            // 
            // txt_sayi_gir
            // 
            this.txt_sayi_gir.Location = new System.Drawing.Point(129, 53);
            this.txt_sayi_gir.Name = "txt_sayi_gir";
            this.txt_sayi_gir.Size = new System.Drawing.Size(182, 22);
            this.txt_sayi_gir.TabIndex = 1;
            // 
            // btn_cevir
            // 
            this.btn_cevir.Location = new System.Drawing.Point(339, 53);
            this.btn_cevir.Name = "btn_cevir";
            this.btn_cevir.Size = new System.Drawing.Size(183, 50);
            this.btn_cevir.TabIndex = 2;
            this.btn_cevir.Text = "Çevir";
            this.btn_cevir.UseVisualStyleBackColor = true;
            this.btn_cevir.Click += new System.EventHandler(this.btn_cevir_Click);
            // 
            // txt_cevir
            // 
            this.txt_cevir.Location = new System.Drawing.Point(129, 81);
            this.txt_cevir.Name = "txt_cevir";
            this.txt_cevir.Size = new System.Drawing.Size(182, 22);
            this.txt_cevir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Roma Rakamıyla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 166);
            this.Controls.Add(this.txt_cevir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cevir);
            this.Controls.Add(this.txt_sayi_gir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sayi_gir;
        private System.Windows.Forms.Button btn_cevir;
        private System.Windows.Forms.TextBox txt_cevir;
        private System.Windows.Forms.Label label2;
    }
}