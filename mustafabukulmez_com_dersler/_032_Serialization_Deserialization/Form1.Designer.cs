namespace mustafabukulmez_com_dersler._032_Serialization_Deserialization
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
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_xml_cikti = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Serialization = new System.Windows.Forms.Button();
            this.btn_Deserialization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(68, 12);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(181, 20);
            this.txt_adi.TabIndex = 0;
            this.txt_adi.Text = "Mustafa";
            // 
            // txt_xml_cikti
            // 
            this.txt_xml_cikti.Location = new System.Drawing.Point(299, 12);
            this.txt_xml_cikti.Multiline = true;
            this.txt_xml_cikti.Name = "txt_xml_cikti";
            this.txt_xml_cikti.Size = new System.Drawing.Size(400, 250);
            this.txt_xml_cikti.TabIndex = 1;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(68, 38);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(181, 20);
            this.txt_soyadi.TabIndex = 2;
            this.txt_soyadi.Text = "BÜKÜLMEZ";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(68, 64);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(181, 20);
            this.txt_tel.TabIndex = 3;
            this.txt_tel.Text = "0555 555 55 55";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(68, 90);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(181, 20);
            this.txt_mail.TabIndex = 4;
            this.txt_mail.Text = "mustafabukulmez3446@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mail Adres";
            // 
            // btn_Serialization
            // 
            this.btn_Serialization.Location = new System.Drawing.Point(68, 116);
            this.btn_Serialization.Name = "btn_Serialization";
            this.btn_Serialization.Size = new System.Drawing.Size(181, 35);
            this.btn_Serialization.TabIndex = 10;
            this.btn_Serialization.Text = "Serialization";
            this.btn_Serialization.UseVisualStyleBackColor = true;
            this.btn_Serialization.Click += new System.EventHandler(this.btn_Serialization_Click);
            // 
            // btn_Deserialization
            // 
            this.btn_Deserialization.Location = new System.Drawing.Point(299, 268);
            this.btn_Deserialization.Name = "btn_Deserialization";
            this.btn_Deserialization.Size = new System.Drawing.Size(400, 33);
            this.btn_Deserialization.TabIndex = 11;
            this.btn_Deserialization.Text = "Deserialization";
            this.btn_Deserialization.UseVisualStyleBackColor = true;
            this.btn_Deserialization.Click += new System.EventHandler(this.btn_Deserialization_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 371);
            this.Controls.Add(this.btn_Deserialization);
            this.Controls.Add(this.btn_Serialization);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.txt_xml_cikti);
            this.Controls.Add(this.txt_adi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_xml_cikti;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Serialization;
        private System.Windows.Forms.Button btn_Deserialization;
    }
}