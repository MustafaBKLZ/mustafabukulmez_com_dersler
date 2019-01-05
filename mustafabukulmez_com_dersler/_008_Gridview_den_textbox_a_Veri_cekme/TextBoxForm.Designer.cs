namespace mustafabukulmez_com_dersler._008_Gridview_den_textbox_a_Veri_cekme
{
    partial class TextBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //https://mustafabukulmez.com/2018/12/31/c-datagridviewden-veri-cekme/

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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_per_adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_per_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_per_TC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_per_tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Okunan ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(132, 49);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(136, 22);
            this.txt_ID.TabIndex = 9;
            // 
            // txt_per_adi
            // 
            this.txt_per_adi.Location = new System.Drawing.Point(132, 97);
            this.txt_per_adi.Name = "txt_per_adi";
            this.txt_per_adi.Size = new System.Drawing.Size(136, 22);
            this.txt_per_adi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Personel Adı";
            // 
            // txt_per_soyad
            // 
            this.txt_per_soyad.Location = new System.Drawing.Point(132, 125);
            this.txt_per_soyad.Name = "txt_per_soyad";
            this.txt_per_soyad.Size = new System.Drawing.Size(136, 22);
            this.txt_per_soyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Soyad";
            // 
            // txt_per_TC
            // 
            this.txt_per_TC.Location = new System.Drawing.Point(408, 97);
            this.txt_per_TC.Name = "txt_per_TC";
            this.txt_per_TC.Size = new System.Drawing.Size(136, 22);
            this.txt_per_TC.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Personel TC";
            // 
            // txt_per_tel
            // 
            this.txt_per_tel.Location = new System.Drawing.Point(408, 125);
            this.txt_per_tel.Name = "txt_per_tel";
            this.txt_per_tel.Size = new System.Drawing.Size(136, 22);
            this.txt_per_tel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Personel Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(464, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "https://mustafabukulmez.com/2018/12/31/c-datagridviewden-veri-cekme/";
            // 
            // TextBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 241);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_per_tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_per_TC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_per_soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_per_adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label1);
            this.Name = "TextBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextBoxForm";
            this.Load += new System.EventHandler(this.TextBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_per_adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_per_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_per_TC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_per_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
//https://mustafabukulmez.com/2018/12/31/c-datagridviewden-veri-cekme/