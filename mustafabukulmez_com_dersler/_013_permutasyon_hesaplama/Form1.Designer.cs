namespace mustafabukulmez_com_dersler._013_permutasyon_hesaplama
{
    //https://mustafabukulmez.com/2019/01/05/c-permutasyon-hesaplama/
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
        //https://mustafabukulmez.com/2019/01/05/c-permutasyon-hesaplama/
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.bt_permutasyon_hesapla = new System.Windows.Forms.Button();
            this.txt_r = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eleman Sayısı?";
            // 
            // txt_n
            // 
            this.txt_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_n.Location = new System.Drawing.Point(195, 28);
            this.txt_n.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(79, 23);
            this.txt_n.TabIndex = 1;
            // 
            // bt_permutasyon_hesapla
            // 
            this.bt_permutasyon_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_permutasyon_hesapla.Location = new System.Drawing.Point(278, 28);
            this.bt_permutasyon_hesapla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_permutasyon_hesapla.Name = "bt_permutasyon_hesapla";
            this.bt_permutasyon_hesapla.Size = new System.Drawing.Size(89, 76);
            this.bt_permutasyon_hesapla.TabIndex = 4;
            this.bt_permutasyon_hesapla.Text = "Hesapla";
            this.bt_permutasyon_hesapla.UseVisualStyleBackColor = true;
            this.bt_permutasyon_hesapla.Click += new System.EventHandler(this.bt_permutasyon_hesapla_Click);
            // 
            // txt_r
            // 
            this.txt_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_r.Location = new System.Drawing.Point(195, 54);
            this.txt_r.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_r.Name = "txt_r";
            this.txt_r.Size = new System.Drawing.Size(79, 23);
            this.txt_r.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kaçlı Kombinasyon?";
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.Enabled = false;
            this.txt_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sonuc.Location = new System.Drawing.Point(195, 81);
            this.txt_sonuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.Size = new System.Drawing.Size(79, 23);
            this.txt_sonuc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sonuç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(157, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "( r )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(157, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "( n )";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_n);
            this.groupBox1.Controls.Add(this.bt_permutasyon_hesapla);
            this.groupBox1.Controls.Add(this.txt_r);
            this.groupBox1.Controls.Add(this.txt_sonuc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(592, 115);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permütasyon Hesaplama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 344);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kombinasyon Hesaplama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Button bt_permutasyon_hesapla;
        private System.Windows.Forms.TextBox txt_r;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
//https://mustafabukulmez.com/2019/01/05/c-permutasyon-hesaplama/