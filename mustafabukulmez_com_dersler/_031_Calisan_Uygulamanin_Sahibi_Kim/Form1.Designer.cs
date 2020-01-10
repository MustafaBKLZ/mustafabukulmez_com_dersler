namespace mustafabukulmez_com_dersler._031_Calisan_Uygulamanin_Sahibi_Kim
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
            this.txt_exe_adi = new System.Windows.Forms.TextBox();
            this.btn_islemler_getir = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_win_kullanici = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXE Adı";
            // 
            // txt_exe_adi
            // 
            this.txt_exe_adi.Location = new System.Drawing.Point(129, 16);
            this.txt_exe_adi.Name = "txt_exe_adi";
            this.txt_exe_adi.Size = new System.Drawing.Size(201, 20);
            this.txt_exe_adi.TabIndex = 1;
            // 
            // btn_islemler_getir
            // 
            this.btn_islemler_getir.Location = new System.Drawing.Point(336, 14);
            this.btn_islemler_getir.Name = "btn_islemler_getir";
            this.btn_islemler_getir.Size = new System.Drawing.Size(116, 23);
            this.btn_islemler_getir.TabIndex = 2;
            this.btn_islemler_getir.Text = "İşlemleri Getir";
            this.btn_islemler_getir.UseVisualStyleBackColor = true;
            this.btn_islemler_getir.Click += new System.EventHandler(this.btn_islemler_getir_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(37, 365);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(568, 17);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2019/12/28/c-process-islemleri-neler-yapilabilir/";
            this.linkLabel1.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(36, 336);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(403, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "C# Kullanıcıya Ait Çalışan İşlemleri Bulmak";
            this.label12.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(129, 115);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(201, 20);
            this.txt_id.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Process ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Process Win Kullanıcı";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(129, 141);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(201, 20);
            this.txt_user.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Win Kullanıcı";
            // 
            // txt_win_kullanici
            // 
            this.txt_win_kullanici.Location = new System.Drawing.Point(129, 42);
            this.txt_win_kullanici.Name = "txt_win_kullanici";
            this.txt_win_kullanici.Size = new System.Drawing.Size(201, 20);
            this.txt_win_kullanici.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_win_kullanici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_islemler_getir);
            this.Controls.Add(this.txt_exe_adi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_exe_adi;
        private System.Windows.Forms.Button btn_islemler_getir;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_win_kullanici;
    }
}