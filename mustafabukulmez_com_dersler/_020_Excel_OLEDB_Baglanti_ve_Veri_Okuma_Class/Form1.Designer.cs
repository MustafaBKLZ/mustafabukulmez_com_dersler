namespace mustafabukulmez_com_dersler._020_Excel_OLEDB_Baglanti_ve_Veri_Okuma_Class
{
    //https://mustafabukulmez.com/2019/03/15/c-excel-oledb-baglanti-ve-veri-okuma-class/
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
            this.txt_excel_yolu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_oku = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_klasorden_coklu_sec = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_secilenleri_oku = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_excel_yolu
            // 
            this.txt_excel_yolu.Location = new System.Drawing.Point(116, 9);
            this.txt_excel_yolu.Name = "txt_excel_yolu";
            this.txt_excel_yolu.Size = new System.Drawing.Size(248, 20);
            this.txt_excel_yolu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Excel Dosyası Seç";
            // 
            // btn_sec
            // 
            this.btn_sec.Location = new System.Drawing.Point(370, 7);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(75, 23);
            this.btn_sec.TabIndex = 2;
            this.btn_sec.Text = "Seç";
            this.btn_sec.UseVisualStyleBackColor = true;
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(280, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 344);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_oku
            // 
            this.btn_oku.Location = new System.Drawing.Point(451, 7);
            this.btn_oku.Name = "btn_oku";
            this.btn_oku.Size = new System.Drawing.Size(75, 23);
            this.btn_oku.TabIndex = 4;
            this.btn_oku.Text = "Oku";
            this.btn_oku.UseVisualStyleBackColor = true;
            this.btn_oku.Click += new System.EventHandler(this.btn_oku_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(15, 90);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(629, 17);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2019/03/15/c-excel-oledb-baglanti-ve-veri-okuma-class" +
    "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(14, 61);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(463, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "C# Excel OLEDB Bağlantı ve Veri Okuma – Class";
            // 
            // btn_klasorden_coklu_sec
            // 
            this.btn_klasorden_coklu_sec.Location = new System.Drawing.Point(532, 7);
            this.btn_klasorden_coklu_sec.Name = "btn_klasorden_coklu_sec";
            this.btn_klasorden_coklu_sec.Size = new System.Drawing.Size(141, 23);
            this.btn_klasorden_coklu_sec.TabIndex = 32;
            this.btn_klasorden_coklu_sec.Text = "Klasörden Çoklu Seç";
            this.btn_klasorden_coklu_sec.UseVisualStyleBackColor = true;
            this.btn_klasorden_coklu_sec.Click += new System.EventHandler(this.btn_klasorden_coklu_sec_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 207);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 344);
            this.listBox1.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_secilenleri_oku);
            this.panel1.Controls.Add(this.btn_klasorden_coklu_sec);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btn_oku);
            this.panel1.Controls.Add(this.btn_sec);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_excel_yolu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 207);
            this.panel1.TabIndex = 34;
            // 
            // btn_secilenleri_oku
            // 
            this.btn_secilenleri_oku.Location = new System.Drawing.Point(679, 7);
            this.btn_secilenleri_oku.Name = "btn_secilenleri_oku";
            this.btn_secilenleri_oku.Size = new System.Drawing.Size(141, 23);
            this.btn_secilenleri_oku.TabIndex = 33;
            this.btn_secilenleri_oku.Text = "Seçilenleri Oku";
            this.btn_secilenleri_oku.UseVisualStyleBackColor = true;
            this.btn_secilenleri_oku.Click += new System.EventHandler(this.btn_secilenleri_oku_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "C# Çoklu Excel Dosyası Okuma";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.Location = new System.Drawing.Point(15, 154);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(629, 17);
            this.linkLabel2.TabIndex = 35;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://mustafabukulmez.com/2019/03/15/c-excel-oledb-baglanti-ve-veri-okuma-class" +
    "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_excel_yolu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_oku;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_klasorden_coklu_sec;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_secilenleri_oku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}