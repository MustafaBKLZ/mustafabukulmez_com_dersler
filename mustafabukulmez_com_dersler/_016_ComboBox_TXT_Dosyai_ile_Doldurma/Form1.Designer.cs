namespace mustafabukulmez_com_dersler._016_ComboBox_TXT_Dosyai_ile_Doldurma
{
    //https://mustafabukulmez.com/2019/01/10/c-combobox-txt-dosyasi-ile-doldurma/
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
        //https://mustafabukulmez.com/2019/01/10/c-combobox-txt-dosyasi-ile-doldurma/
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_arac_marka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_arac_marka
            // 
            this.cmb_arac_marka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_arac_marka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_arac_marka.FormattingEnabled = true;
            this.cmb_arac_marka.Location = new System.Drawing.Point(135, 158);
            this.cmb_arac_marka.Name = "cmb_arac_marka";
            this.cmb_arac_marka.Size = new System.Drawing.Size(222, 24);
            this.cmb_arac_marka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Araç Markaları";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(32, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(738, 21);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2019/01/10/c-combobox-txt-dosyasi-ile-doldurma/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(31, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(494, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = "C# ComboBox TXT Dosyası ile Doldurma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 334);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_arac_marka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_arac_marka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
    }
}
//https://mustafabukulmez.com/2019/01/10/c-combobox-txt-dosyasi-ile-doldurma/