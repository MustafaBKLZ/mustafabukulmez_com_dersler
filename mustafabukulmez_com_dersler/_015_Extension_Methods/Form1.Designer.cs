namespace mustafabukulmez_com_dersler._015_Extension_Methods
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-1/
        //https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-2/
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_kontrol = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_karakter_al = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kontrol
            // 
            this.btn_kontrol.Location = new System.Drawing.Point(248, 61);
            this.btn_kontrol.Name = "btn_kontrol";
            this.btn_kontrol.Size = new System.Drawing.Size(171, 23);
            this.btn_kontrol.TabIndex = 3;
            this.btn_kontrol.Text = "Kontrol Et";
            this.btn_kontrol.UseVisualStyleBackColor = true;
            this.btn_kontrol.Click += new System.EventHandler(this.btn_kontrol_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 22);
            this.textBox2.TabIndex = 2;
            // 
            // btn_karakter_al
            // 
            this.btn_karakter_al.Location = new System.Drawing.Point(248, 99);
            this.btn_karakter_al.Name = "btn_karakter_al";
            this.btn_karakter_al.Size = new System.Drawing.Size(171, 23);
            this.btn_karakter_al.TabIndex = 5;
            this.btn_karakter_al.Text = "Soldan Karakter Al";
            this.btn_karakter_al.UseVisualStyleBackColor = true;
            this.btn_karakter_al.Click += new System.EventHandler(this.btn_karakter_al_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 22);
            this.textBox3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sağdan Karakter Al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 368);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_karakter_al);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_kontrol);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-1/
        //https://mustafabukulmez.com/2019/01/05/c-extension-methods-genisletme-metodlari-2/
        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_kontrol;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_karakter_al;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
    }
}