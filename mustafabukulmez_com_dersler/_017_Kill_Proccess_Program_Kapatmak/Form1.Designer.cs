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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kapatılacak Program Adı";
            // 
            // txt_kapatilacak_program_adi
            // 
            this.txt_kapatilacak_program_adi.Location = new System.Drawing.Point(161, 142);
            this.txt_kapatilacak_program_adi.Name = "txt_kapatilacak_program_adi";
            this.txt_kapatilacak_program_adi.Size = new System.Drawing.Size(201, 20);
            this.txt_kapatilacak_program_adi.TabIndex = 1;
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(368, 131);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(75, 40);
            this.btn_kapat.TabIndex = 2;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(32, 73);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(637, 17);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2019/02/28/c-kill-proccess-otomatik-program-kapatmak/" +
    "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(31, 44);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(442, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "C# Kill Proccess - Otomatik Program Kapatmak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 261);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.txt_kapatilacak_program_adi);
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
        private System.Windows.Forms.TextBox txt_kapatilacak_program_adi;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
    }
}