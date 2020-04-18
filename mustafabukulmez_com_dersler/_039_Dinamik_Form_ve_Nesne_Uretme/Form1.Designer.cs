namespace mustafabukulmez_com_dersler._039_Dinamik_Form_ve_Nesne_Uretme
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
            this.txt_kod = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.btn_stok_Sec = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kodu / Adı";
            // 
            // txt_kod
            // 
            this.txt_kod.Location = new System.Drawing.Point(101, 7);
            this.txt_kod.Name = "txt_kod";
            this.txt_kod.Size = new System.Drawing.Size(100, 20);
            this.txt_kod.TabIndex = 1;
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(207, 7);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_adi.TabIndex = 2;
            // 
            // btn_stok_Sec
            // 
            this.btn_stok_Sec.Location = new System.Drawing.Point(313, 6);
            this.btn_stok_Sec.Name = "btn_stok_Sec";
            this.btn_stok_Sec.Size = new System.Drawing.Size(75, 23);
            this.btn_stok_Sec.TabIndex = 3;
            this.btn_stok_Sec.Text = "Stok Seç";
            this.btn_stok_Sec.UseVisualStyleBackColor = true;
            this.btn_stok_Sec.Click += new System.EventHandler(this.btn_stok_Sec_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(56, 137);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(646, 17);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2020/04/18/c-dinamik-form-ve-nesneler-uretip-kullanma" +
    "k/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(54, 107);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(452, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "C# Dinamik Form ve Nesneler Üretip Kullanmak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 241);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_stok_Sec);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.txt_kod);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kod;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Button btn_stok_Sec;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
    }
}