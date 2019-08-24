namespace mustafabukulmez_com_dersler._023_XML_Islemleri
{
    partial class XML_Diger_Islemler
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
            this.btn_dataset_ile_olustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dataset_ile_olustur
            // 
            this.btn_dataset_ile_olustur.Location = new System.Drawing.Point(12, 12);
            this.btn_dataset_ile_olustur.Name = "btn_dataset_ile_olustur";
            this.btn_dataset_ile_olustur.Size = new System.Drawing.Size(247, 70);
            this.btn_dataset_ile_olustur.TabIndex = 0;
            this.btn_dataset_ile_olustur.Text = "DataSet ile XML Dosyası Oluştur";
            this.btn_dataset_ile_olustur.UseVisualStyleBackColor = true;
            this.btn_dataset_ile_olustur.Click += new System.EventHandler(this.Btn_dataset_ile_olustur_Click);
            // 
            // XML_Diger_Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 538);
            this.Controls.Add(this.btn_dataset_ile_olustur);
            this.Name = "XML_Diger_Islemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML_Diger_Islemler";
            this.Load += new System.EventHandler(this.XML_Diger_Islemler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dataset_ile_olustur;
    }
}