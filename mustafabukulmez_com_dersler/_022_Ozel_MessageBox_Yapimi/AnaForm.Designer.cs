namespace mustafabukulmez_com_dersler._022_Ozel_MessageBox_Yapimi
{
    //https://mustafabukulmez.com/2019/04/02/c-ozel-messagebox-yapimi/
    partial class AnaForm
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
            this.lbl_mesaj = new System.Windows.Forms.Label();
            this.btn_devam_et = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_mesaj
            // 
            this.lbl_mesaj.AutoSize = true;
            this.lbl_mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mesaj.Location = new System.Drawing.Point(40, 116);
            this.lbl_mesaj.Name = "lbl_mesaj";
            this.lbl_mesaj.Size = new System.Drawing.Size(56, 20);
            this.lbl_mesaj.TabIndex = 6;
            this.lbl_mesaj.Text = "mesaj";
            // 
            // btn_devam_et
            // 
            this.btn_devam_et.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_devam_et.Location = new System.Drawing.Point(40, 41);
            this.btn_devam_et.Name = "btn_devam_et";
            this.btn_devam_et.Size = new System.Drawing.Size(149, 72);
            this.btn_devam_et.TabIndex = 5;
            this.btn_devam_et.Text = "Devam Et";
            this.btn_devam_et.UseVisualStyleBackColor = true;
            this.btn_devam_et.Click += new System.EventHandler(this.btn_devam_et_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(41, 264);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(515, 17);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2019/04/02/c-ozel-messagebox-yapimi/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(40, 235);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(279, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "C# Özel MessageBox Yapımı";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 336);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_mesaj);
            this.Controls.Add(this.btn_devam_et);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_mesaj;
        private System.Windows.Forms.Button btn_devam_et;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
    }
}