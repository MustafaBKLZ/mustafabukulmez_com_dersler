
namespace mustafabukulmez_com_dersler._047_Dizideki_Bir_Elemanın_Indeksini_Bulmak
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
            this.btn_IndexOf = new System.Windows.Forms.Button();
            this.btn_FindIndex = new System.Windows.Forms.Button();
            this.btn_Enumrable_First = new System.Windows.Forms.Button();
            this.btn_Enumrable_FirstOrDefault = new System.Windows.Forms.Button();
            this.btn_Performing_Linear_Search = new System.Windows.Forms.Button();
            this.txt_Sayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_IndexOf
            // 
            this.btn_IndexOf.Location = new System.Drawing.Point(149, 151);
            this.btn_IndexOf.Name = "btn_IndexOf";
            this.btn_IndexOf.Size = new System.Drawing.Size(194, 23);
            this.btn_IndexOf.TabIndex = 0;
            this.btn_IndexOf.Text = "IndexOf";
            this.btn_IndexOf.UseVisualStyleBackColor = true;
            this.btn_IndexOf.Click += new System.EventHandler(this.btn_IndexOf_Click);
            // 
            // btn_FindIndex
            // 
            this.btn_FindIndex.Location = new System.Drawing.Point(149, 180);
            this.btn_FindIndex.Name = "btn_FindIndex";
            this.btn_FindIndex.Size = new System.Drawing.Size(194, 23);
            this.btn_FindIndex.TabIndex = 1;
            this.btn_FindIndex.Text = "FindIndex";
            this.btn_FindIndex.UseVisualStyleBackColor = true;
            this.btn_FindIndex.Click += new System.EventHandler(this.btn_FindIndex_Click);
            // 
            // btn_Enumrable_First
            // 
            this.btn_Enumrable_First.Location = new System.Drawing.Point(149, 209);
            this.btn_Enumrable_First.Name = "btn_Enumrable_First";
            this.btn_Enumrable_First.Size = new System.Drawing.Size(194, 23);
            this.btn_Enumrable_First.TabIndex = 2;
            this.btn_Enumrable_First.Text = "Enumrable ve First";
            this.btn_Enumrable_First.UseVisualStyleBackColor = true;
            this.btn_Enumrable_First.Click += new System.EventHandler(this.btn_Enumrable_First_Click);
            // 
            // btn_Enumrable_FirstOrDefault
            // 
            this.btn_Enumrable_FirstOrDefault.Location = new System.Drawing.Point(149, 238);
            this.btn_Enumrable_FirstOrDefault.Name = "btn_Enumrable_FirstOrDefault";
            this.btn_Enumrable_FirstOrDefault.Size = new System.Drawing.Size(194, 23);
            this.btn_Enumrable_FirstOrDefault.TabIndex = 3;
            this.btn_Enumrable_FirstOrDefault.Text = "Enumrable ve FirstOrDefault";
            this.btn_Enumrable_FirstOrDefault.UseVisualStyleBackColor = true;
            this.btn_Enumrable_FirstOrDefault.Click += new System.EventHandler(this.btn_Enumrable_FirstOrDefault_Click);
            // 
            // btn_Performing_Linear_Search
            // 
            this.btn_Performing_Linear_Search.Location = new System.Drawing.Point(149, 267);
            this.btn_Performing_Linear_Search.Name = "btn_Performing_Linear_Search";
            this.btn_Performing_Linear_Search.Size = new System.Drawing.Size(194, 23);
            this.btn_Performing_Linear_Search.TabIndex = 4;
            this.btn_Performing_Linear_Search.Text = "Performing Linear Search";
            this.btn_Performing_Linear_Search.UseVisualStyleBackColor = true;
            this.btn_Performing_Linear_Search.Click += new System.EventHandler(this.btn_Performing_Linear_Search_Click);
            // 
            // txt_Sayi
            // 
            this.txt_Sayi.Location = new System.Drawing.Point(57, 211);
            this.txt_Sayi.Name = "txt_Sayi";
            this.txt_Sayi.Size = new System.Drawing.Size(73, 20);
            this.txt_Sayi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aranacak Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arama Metodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sonuç";
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.AutoSize = true;
            this.lbl_Sonuc.Location = new System.Drawing.Point(379, 213);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(38, 13);
            this.lbl_Sonuc.TabIndex = 6;
            this.lbl_Sonuc.Text = "Sonuç";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(137, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 250);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(358, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 250);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(48, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 1);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(48, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 1);
            this.panel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(469, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "UYARI: Sonuç -1 ise aranan eleman dizi içerisinde yoktur.";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(48, 308);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(550, 1);
            this.panel5.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 388);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Sayi);
            this.Controls.Add(this.btn_Performing_Linear_Search);
            this.Controls.Add(this.btn_Enumrable_FirstOrDefault);
            this.Controls.Add(this.btn_Enumrable_First);
            this.Controls.Add(this.btn_FindIndex);
            this.Controls.Add(this.btn_IndexOf);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Yontem_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IndexOf;
        private System.Windows.Forms.Button btn_FindIndex;
        private System.Windows.Forms.Button btn_Enumrable_First;
        private System.Windows.Forms.Button btn_Enumrable_FirstOrDefault;
        private System.Windows.Forms.Button btn_Performing_Linear_Search;
        private System.Windows.Forms.TextBox txt_Sayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Sonuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
    }
}