namespace mustafabukulmez_com_dersler
{
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
            this.btn_Kurulu_Antivirus_Bulmak = new DevExpress.XtraEditors.SimpleButton();
            this.btn_FolderBrowserDialog_Kullanimi = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn_Kurulu_Antivirus_Bulmak
            // 
            this.btn_Kurulu_Antivirus_Bulmak.Location = new System.Drawing.Point(12, 12);
            this.btn_Kurulu_Antivirus_Bulmak.Name = "btn_Kurulu_Antivirus_Bulmak";
            this.btn_Kurulu_Antivirus_Bulmak.Size = new System.Drawing.Size(264, 38);
            this.btn_Kurulu_Antivirus_Bulmak.TabIndex = 0;
            this.btn_Kurulu_Antivirus_Bulmak.Text = "Kurulu Anti Virüs Programını Bulmak";
            this.btn_Kurulu_Antivirus_Bulmak.Click += new System.EventHandler(this.btn_Kurulu_Antivirus_Bulmak_Click);
            // 
            // btn_FolderBrowserDialog_Kullanimi
            // 
            this.btn_FolderBrowserDialog_Kullanimi.Location = new System.Drawing.Point(12, 56);
            this.btn_FolderBrowserDialog_Kullanimi.Name = "btn_FolderBrowserDialog_Kullanimi";
            this.btn_FolderBrowserDialog_Kullanimi.Size = new System.Drawing.Size(264, 38);
            this.btn_FolderBrowserDialog_Kullanimi.TabIndex = 1;
            this.btn_FolderBrowserDialog_Kullanimi.Text = "FolderBrowserDialog Kullanimi";
            this.btn_FolderBrowserDialog_Kullanimi.Click += new System.EventHandler(this.btn_FolderBrowserDialog_Kullanimi_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 621);
            this.Controls.Add(this.btn_FolderBrowserDialog_Kullanimi);
            this.Controls.Add(this.btn_Kurulu_Antivirus_Bulmak);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Kurulu_Antivirus_Bulmak;
        private DevExpress.XtraEditors.SimpleButton btn_FolderBrowserDialog_Kullanimi;
    }
}