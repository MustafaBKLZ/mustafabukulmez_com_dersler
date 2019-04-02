namespace mustafabukulmez_com_dersler._022_Ozel_MessageBox_Yapimi
{
    partial class MyMessageBox
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
        //https://mustafabukulmez.com/2019/04/02/c-ozel-messagebox-yapimi/
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_mesaj = new System.Windows.Forms.Label();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_vazgeç = new System.Windows.Forms.Button();
            this.btn_devam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            //https://mustafabukulmez.com/2019/04/02/c-ozel-messagebox-yapimi/
            // lbl_mesaj
            // 
            this.lbl_mesaj.AutoSize = true;
            this.lbl_mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mesaj.Location = new System.Drawing.Point(15, 34);
            this.lbl_mesaj.Name = "lbl_mesaj";
            this.lbl_mesaj.Size = new System.Drawing.Size(56, 20);
            this.lbl_mesaj.TabIndex = 7;
            this.lbl_mesaj.Text = "mesaj";
            // 
            // btn_iptal
            // 
            this.btn_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.Location = new System.Drawing.Point(324, 96);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(149, 72);
            this.btn_iptal.TabIndex = 6;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_vazgeç
            // 
            this.btn_vazgeç.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vazgeç.Location = new System.Drawing.Point(169, 96);
            this.btn_vazgeç.Name = "btn_vazgeç";
            this.btn_vazgeç.Size = new System.Drawing.Size(149, 72);
            this.btn_vazgeç.TabIndex = 5;
            this.btn_vazgeç.Text = "Vazgeç";
            this.btn_vazgeç.UseVisualStyleBackColor = true;
            this.btn_vazgeç.Click += new System.EventHandler(this.btn_vazgeç_Click);
            // 
            // btn_devam
            // 
            this.btn_devam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_devam.Location = new System.Drawing.Point(14, 96);
            this.btn_devam.Name = "btn_devam";
            this.btn_devam.Size = new System.Drawing.Size(149, 72);
            this.btn_devam.TabIndex = 4;
            this.btn_devam.Text = "Devam Et";
            this.btn_devam.UseVisualStyleBackColor = true;
            this.btn_devam.Click += new System.EventHandler(this.btn_devam_Click);
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 178);
            this.Controls.Add(this.lbl_mesaj);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_vazgeç);
            this.Controls.Add(this.btn_devam);
            this.Name = "MyMessageBox";
            this.Text = "MyMessageBox";
            this.Load += new System.EventHandler(this.MyMessageBox_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_mesaj;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_vazgeç;
        private System.Windows.Forms.Button btn_devam;
    }
}