namespace mustafabukulmez_com_dersler.FolderBrowserDialog_Kullanimi
{
    partial class FolderBrowserDialogKullanimi_
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
            this.btn_goster = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_klasor_yolu = new DevExpress.XtraEditors.LabelControl();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(12, 12);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(155, 87);
            this.btn_goster.TabIndex = 0;
            this.btn_goster.Text = "Göster";
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // lbl_klasor_yolu
            // 
            this.lbl_klasor_yolu.Location = new System.Drawing.Point(12, 105);
            this.lbl_klasor_yolu.Name = "lbl_klasor_yolu";
            this.lbl_klasor_yolu.Size = new System.Drawing.Size(75, 16);
            this.lbl_klasor_yolu.TabIndex = 1;
            this.lbl_klasor_yolu.Text = "labelControl1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(233, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 292);
            this.listBox1.TabIndex = 3;
            // 
            // FolderBrowserDialogKullanimi_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 314);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_klasor_yolu);
            this.Controls.Add(this.btn_goster);
            this.Name = "FolderBrowserDialogKullanimi_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderBrowserDialogKullanimi_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_goster;
        private DevExpress.XtraEditors.LabelControl lbl_klasor_yolu;
        private System.Windows.Forms.ListBox listBox1;
    }
}