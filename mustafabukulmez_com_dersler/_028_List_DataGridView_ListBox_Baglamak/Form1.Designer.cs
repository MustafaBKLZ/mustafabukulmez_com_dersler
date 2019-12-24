namespace mustafabukulmez_com_dersler._028_List_DataGridView_ListBox_Baglamak
{
    //https://mustafabukulmez.com/2019/12/24/c-list-ogelerini-datagridview-ve-listbox-a-baglamak/
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_tek = new System.Windows.Forms.Button();
            this.btn_iki = new System.Windows.Forms.Button();
            this.btn_uc = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 478);
            this.listBox1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(321, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 478);
            this.dataGridView1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btn_temizle);
            this.panel1.Controls.Add(this.btn_uc);
            this.panel1.Controls.Add(this.btn_iki);
            this.panel1.Controls.Add(this.btn_tek);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 144);
            this.panel1.TabIndex = 19;
            //https://mustafabukulmez.com/2019/12/24/c-list-ogelerini-datagridview-ve-listbox-a-baglamak/
            // 
            // btn_tek
            // 
            this.btn_tek.Location = new System.Drawing.Point(156, 12);
            this.btn_tek.Name = "btn_tek";
            this.btn_tek.Size = new System.Drawing.Size(138, 47);
            this.btn_tek.TabIndex = 0;
            this.btn_tek.Text = "Tek Liste İle";
            this.btn_tek.UseVisualStyleBackColor = true;
            this.btn_tek.Click += new System.EventHandler(this.btn_tek_Click);
            // 
            // btn_iki
            // 
            this.btn_iki.Location = new System.Drawing.Point(300, 12);
            this.btn_iki.Name = "btn_iki";
            this.btn_iki.Size = new System.Drawing.Size(138, 47);
            this.btn_iki.TabIndex = 1;
            this.btn_iki.Text = "İki Liste İle";
            this.btn_iki.UseVisualStyleBackColor = true;
            this.btn_iki.Click += new System.EventHandler(this.btn_iki_Click);
            // 
            // btn_uc
            // 
            this.btn_uc.Location = new System.Drawing.Point(444, 12);
            this.btn_uc.Name = "btn_uc";
            this.btn_uc.Size = new System.Drawing.Size(138, 47);
            this.btn_uc.TabIndex = 2;
            this.btn_uc.Text = "Üç Liste İle";
            this.btn_uc.UseVisualStyleBackColor = true;
            this.btn_uc.Click += new System.EventHandler(this.btn_uc_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(12, 12);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(138, 47);
            this.btn_temizle.TabIndex = 3;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(11, 105);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(683, 17);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2019/12/24/c-list-ogelerini-datagridview-ve-listbox-a" +
    "-baglamak/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(10, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(509, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "C# List Ögelerini DataGridView ve ListBox\'a Bağlamak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 622);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        //https://mustafabukulmez.com/2019/12/24/c-list-ogelerini-datagridview-ve-listbox-a-baglamak/
        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_uc;
        private System.Windows.Forms.Button btn_iki;
        private System.Windows.Forms.Button btn_tek;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
    }
}//https://mustafabukulmez.com/2019/12/24/c-list-ogelerini-datagridview-ve-listbox-a-baglamak/