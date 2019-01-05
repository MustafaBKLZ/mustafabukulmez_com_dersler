namespace mustafabukulmez_com_dersler._007_Kelime_heceleme_islemi
{
    partial class Form2
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
            this.txt_girilen_cumle = new System.Windows.Forms.TextBox();
            this.txt_cikan_cumle = new System.Windows.Forms.TextBox();
            this.btn_isle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_girilen_cumle
            // 
            this.txt_girilen_cumle.Location = new System.Drawing.Point(25, 98);
            this.txt_girilen_cumle.Name = "txt_girilen_cumle";
            this.txt_girilen_cumle.Size = new System.Drawing.Size(549, 22);
            this.txt_girilen_cumle.TabIndex = 0;
            this.txt_girilen_cumle.Text = "mustafa bükülmez";
            // 
            // txt_cikan_cumle
            // 
            this.txt_cikan_cumle.Location = new System.Drawing.Point(25, 140);
            this.txt_cikan_cumle.Name = "txt_cikan_cumle";
            this.txt_cikan_cumle.Size = new System.Drawing.Size(549, 22);
            this.txt_cikan_cumle.TabIndex = 1;
            // 
            // btn_isle
            // 
            this.btn_isle.Location = new System.Drawing.Point(580, 88);
            this.btn_isle.Name = "btn_isle";
            this.btn_isle.Size = new System.Drawing.Size(159, 87);
            this.btn_isle.TabIndex = 2;
            this.btn_isle.Text = "İşle";
            this.btn_isle.UseVisualStyleBackColor = true;
            this.btn_isle.Click += new System.EventHandler(this.btn_isle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(52, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "C# Kelime Heceleme İşlemi";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_isle);
            this.Controls.Add(this.txt_cikan_cumle);
            this.Controls.Add(this.txt_girilen_cumle);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_girilen_cumle;
        private System.Windows.Forms.TextBox txt_cikan_cumle;
        private System.Windows.Forms.Button btn_isle;
        private System.Windows.Forms.Label label3;
    }
}