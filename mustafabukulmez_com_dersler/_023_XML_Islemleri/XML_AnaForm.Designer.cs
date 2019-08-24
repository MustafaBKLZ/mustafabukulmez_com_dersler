namespace mustafabukulmez_com_dersler._023_XML_Islemleri
{
    partial class XML_AnaForm
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
            this.btn_xml_dosya_olustur = new System.Windows.Forms.Button();
            this.lbl_bildirim = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_xml_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_diger_islemler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xml_dosya_olustur
            // 
            this.btn_xml_dosya_olustur.Location = new System.Drawing.Point(12, 35);
            this.btn_xml_dosya_olustur.Name = "btn_xml_dosya_olustur";
            this.btn_xml_dosya_olustur.Size = new System.Drawing.Size(171, 72);
            this.btn_xml_dosya_olustur.TabIndex = 0;
            this.btn_xml_dosya_olustur.Text = "XML Dosya Oku /  Oluştur";
            this.btn_xml_dosya_olustur.UseVisualStyleBackColor = true;
            this.btn_xml_dosya_olustur.Click += new System.EventHandler(this.Btn_xml_dosya_olustur_Click);
            // 
            // lbl_bildirim
            // 
            this.lbl_bildirim.AutoSize = true;
            this.lbl_bildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bildirim.ForeColor = System.Drawing.Color.Red;
            this.lbl_bildirim.Location = new System.Drawing.Point(12, 9);
            this.lbl_bildirim.Name = "lbl_bildirim";
            this.lbl_bildirim.Size = new System.Drawing.Size(52, 18);
            this.lbl_bildirim.TabIndex = 1;
            this.lbl_bildirim.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1004, 343);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(253, 87);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(173, 20);
            this.txt_soyad.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyadı";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(253, 61);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(173, 20);
            this.txt_ad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adı";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(253, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(173, 20);
            this.txt_id.TabIndex = 5;
            // 
            // btn_xml_kaydet
            // 
            this.btn_xml_kaydet.Location = new System.Drawing.Point(573, 35);
            this.btn_xml_kaydet.Name = "btn_xml_kaydet";
            this.btn_xml_kaydet.Size = new System.Drawing.Size(118, 72);
            this.btn_xml_kaydet.TabIndex = 4;
            this.btn_xml_kaydet.Text = "Kaydet";
            this.btn_xml_kaydet.UseVisualStyleBackColor = true;
            this.btn_xml_kaydet.Click += new System.EventHandler(this.Btn_xml_kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(449, 35);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(118, 72);
            this.btn_temizle.TabIndex = 10;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.Btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(697, 35);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(118, 72);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // btn_diger_islemler
            // 
            this.btn_diger_islemler.Location = new System.Drawing.Point(821, 35);
            this.btn_diger_islemler.Name = "btn_diger_islemler";
            this.btn_diger_islemler.Size = new System.Drawing.Size(118, 72);
            this.btn_diger_islemler.TabIndex = 12;
            this.btn_diger_islemler.Text = "Diğer İşlemler";
            this.btn_diger_islemler.UseVisualStyleBackColor = true;
            this.btn_diger_islemler.Click += new System.EventHandler(this.Btn_diger_islemler_Click);
            // 
            // XML_AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 472);
            this.Controls.Add(this.btn_diger_islemler);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.lbl_bildirim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_xml_dosya_olustur);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xml_kaydet);
            this.Name = "XML_AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML_AnaForm";
            this.Load += new System.EventHandler(this.XML_AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xml_dosya_olustur;
        private System.Windows.Forms.Label lbl_bildirim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_xml_kaydet;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_diger_islemler;
    }
}