namespace mustafabukulmez_com_dersler._17_Kill_Proccess_Program_Kapatmak
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
            this.txt_kapatilacak_program_adi = new System.Windows.Forms.TextBox();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kapatılacak Program Adı";
            // 
            // txt_kapatilacak_program_adi
            // 
            this.txt_kapatilacak_program_adi.Location = new System.Drawing.Point(173, 56);
            this.txt_kapatilacak_program_adi.Name = "txt_kapatilacak_program_adi";
            this.txt_kapatilacak_program_adi.Size = new System.Drawing.Size(201, 20);
            this.txt_kapatilacak_program_adi.TabIndex = 1;
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(380, 45);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(75, 40);
            this.btn_kapat.TabIndex = 2;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 261);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.txt_kapatilacak_program_adi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kapatilacak_program_adi;
        private System.Windows.Forms.Button btn_kapat;
    }
}