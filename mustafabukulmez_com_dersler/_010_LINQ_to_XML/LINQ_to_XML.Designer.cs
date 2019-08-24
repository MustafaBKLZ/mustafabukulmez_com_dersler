namespace mustafabukulmez_com_dersler._010_LINQ_to_XML
{
    //https://mustafabukulmez.com/2019/01/05/c-linq-to-xml-ile-xml-dosyalarla-calismak/
    partial class LINQ_to_XML
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
            this.btn_Bilgileri_Goster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox_normal = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpg_Gridde_Goster = new System.Windows.Forms.TabPage();
            this.tpg_node_node_oku = new System.Windows.Forms.TabPage();
            this.listBox_sadece_tek_node = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_attiribute = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpg_sum_avg_count = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_avg_true = new System.Windows.Forms.TextBox();
            this.txt_sum_true = new System.Windows.Forms.TextBox();
            this.txt_count_true = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_avg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpg_select_order_by = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox_Group_by = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox_select_order_by = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpg_Gridde_Goster.SuspendLayout();
            this.tpg_node_node_oku.SuspendLayout();
            this.tpg_sum_avg_count.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpg_select_order_by.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Bilgileri_Goster
            // 
            this.btn_Bilgileri_Goster.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Bilgileri_Goster.Location = new System.Drawing.Point(0, 0);
            this.btn_Bilgileri_Goster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Bilgileri_Goster.Name = "btn_Bilgileri_Goster";
            this.btn_Bilgileri_Goster.Size = new System.Drawing.Size(130, 76);
            this.btn_Bilgileri_Goster.TabIndex = 0;
            this.btn_Bilgileri_Goster.Text = "Bilgileri Göster";
            this.btn_Bilgileri_Goster.UseVisualStyleBackColor = true;
            this.btn_Bilgileri_Goster.Click += new System.EventHandler(this.btn_Bilgileri_Goster_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // listBox_normal
            // 
            this.listBox_normal.FormattingEnabled = true;
            this.listBox_normal.Location = new System.Drawing.Point(6, 40);
            this.listBox_normal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_normal.Name = "listBox_normal";
            this.listBox_normal.Size = new System.Drawing.Size(202, 368);
            this.listBox_normal.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpg_Gridde_Goster);
            this.tabControl1.Controls.Add(this.tpg_node_node_oku);
            this.tabControl1.Controls.Add(this.tpg_sum_avg_count);
            this.tabControl1.Controls.Add(this.tpg_select_order_by);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 76);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 450);
            this.tabControl1.TabIndex = 4;
            // 
            // tpg_Gridde_Goster
            // 
            this.tpg_Gridde_Goster.Controls.Add(this.dataGridView1);
            this.tpg_Gridde_Goster.Location = new System.Drawing.Point(4, 22);
            this.tpg_Gridde_Goster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpg_Gridde_Goster.Name = "tpg_Gridde_Goster";
            this.tpg_Gridde_Goster.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpg_Gridde_Goster.Size = new System.Drawing.Size(889, 424);
            this.tpg_Gridde_Goster.TabIndex = 0;
            this.tpg_Gridde_Goster.Text = "XML Grid Doldurma";
            this.tpg_Gridde_Goster.UseVisualStyleBackColor = true;
            // 
            // tpg_node_node_oku
            // 
            this.tpg_node_node_oku.Controls.Add(this.listBox_sadece_tek_node);
            this.tpg_node_node_oku.Controls.Add(this.label3);
            this.tpg_node_node_oku.Controls.Add(this.listBox_attiribute);
            this.tpg_node_node_oku.Controls.Add(this.label2);
            this.tpg_node_node_oku.Controls.Add(this.label1);
            this.tpg_node_node_oku.Controls.Add(this.listBox_normal);
            this.tpg_node_node_oku.Location = new System.Drawing.Point(4, 22);
            this.tpg_node_node_oku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpg_node_node_oku.Name = "tpg_node_node_oku";
            this.tpg_node_node_oku.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpg_node_node_oku.Size = new System.Drawing.Size(889, 423);
            this.tpg_node_node_oku.TabIndex = 1;
            this.tpg_node_node_oku.Text = "XML Node Üzerinden Oku";
            this.tpg_node_node_oku.UseVisualStyleBackColor = true;
            // 
            // listBox_sadece_tek_node
            // 
            this.listBox_sadece_tek_node.FormattingEnabled = true;
            this.listBox_sadece_tek_node.Location = new System.Drawing.Point(417, 40);
            this.listBox_sadece_tek_node.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_sadece_tek_node.Name = "listBox_sadece_tek_node";
            this.listBox_sadece_tek_node.Size = new System.Drawing.Size(202, 368);
            this.listBox_sadece_tek_node.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sadece Ad Elemetlerini Okuma";
            // 
            // listBox_attiribute
            // 
            this.listBox_attiribute.FormattingEnabled = true;
            this.listBox_attiribute.Location = new System.Drawing.Point(212, 40);
            this.listBox_attiribute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_attiribute.Name = "listBox_attiribute";
            this.listBox_attiribute.Size = new System.Drawing.Size(202, 368);
            this.listBox_attiribute.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Attiribute Okuma Sonucu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Normal Okuma Sonucu";
            // 
            // tpg_sum_avg_count
            // 
            this.tpg_sum_avg_count.Controls.Add(this.panel2);
            this.tpg_sum_avg_count.Location = new System.Drawing.Point(4, 22);
            this.tpg_sum_avg_count.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpg_sum_avg_count.Name = "tpg_sum_avg_count";
            this.tpg_sum_avg_count.Size = new System.Drawing.Size(889, 423);
            this.tpg_sum_avg_count.TabIndex = 2;
            this.tpg_sum_avg_count.Text = "Sum, Count, Avg ";
            this.tpg_sum_avg_count.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_avg_true);
            this.panel2.Controls.Add(this.txt_sum_true);
            this.panel2.Controls.Add(this.txt_count_true);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_avg);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_sum);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_count);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 423);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Aktif = True";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Aktif = True";
            // 
            // txt_avg_true
            // 
            this.txt_avg_true.Location = new System.Drawing.Point(320, 89);
            this.txt_avg_true.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_avg_true.Name = "txt_avg_true";
            this.txt_avg_true.Size = new System.Drawing.Size(151, 20);
            this.txt_avg_true.TabIndex = 11;
            // 
            // txt_sum_true
            // 
            this.txt_sum_true.Location = new System.Drawing.Point(320, 66);
            this.txt_sum_true.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sum_true.Name = "txt_sum_true";
            this.txt_sum_true.Size = new System.Drawing.Size(151, 20);
            this.txt_sum_true.TabIndex = 9;
            // 
            // txt_count_true
            // 
            this.txt_count_true.Location = new System.Drawing.Point(320, 43);
            this.txt_count_true.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_count_true.Name = "txt_count_true";
            this.txt_count_true.Size = new System.Drawing.Size(151, 20);
            this.txt_count_true.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Aktif = True";
            // 
            // txt_avg
            // 
            this.txt_avg.Location = new System.Drawing.Point(100, 89);
            this.txt_avg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_avg.Name = "txt_avg";
            this.txt_avg.Size = new System.Drawing.Size(151, 20);
            this.txt_avg.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ortalama Maaş";
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(100, 66);
            this.txt_sum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(151, 20);
            this.txt_sum.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Toplam Maaş";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(100, 43);
            this.txt_count.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(151, 20);
            this.txt_count.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kayıt Sayısı";
            // 
            // tpg_select_order_by
            // 
            this.tpg_select_order_by.Controls.Add(this.panel3);
            this.tpg_select_order_by.Location = new System.Drawing.Point(4, 22);
            this.tpg_select_order_by.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpg_select_order_by.Name = "tpg_select_order_by";
            this.tpg_select_order_by.Size = new System.Drawing.Size(889, 423);
            this.tpg_select_order_by.TabIndex = 3;
            this.tpg_select_order_by.Text = "Select İşlemleri";
            this.tpg_select_order_by.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.listBox_Group_by);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.listBox_select_order_by);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 423);
            this.panel3.TabIndex = 1;
            // 
            // listBox_Group_by
            // 
            this.listBox_Group_by.FormattingEnabled = true;
            this.listBox_Group_by.Location = new System.Drawing.Point(212, 32);
            this.listBox_Group_by.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_Group_by.Name = "listBox_Group_by";
            this.listBox_Group_by.Size = new System.Drawing.Size(202, 368);
            this.listBox_Group_by.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Select Group By";
            // 
            // listBox_select_order_by
            // 
            this.listBox_select_order_by.FormattingEnabled = true;
            this.listBox_select_order_by.Location = new System.Drawing.Point(6, 32);
            this.listBox_select_order_by.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_select_order_by.Name = "listBox_select_order_by";
            this.listBox_select_order_by.Size = new System.Drawing.Size(202, 368);
            this.listBox_select_order_by.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Select Ad Order By Desc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btn_Bilgileri_Goster);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 76);
            this.panel1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(173, 45);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(609, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mustafabukulmez.com/2019/01/05/c-linq-to-xml-ile-xml-dosyalarla-calismak/" +
    "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(172, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(429, 24);
            this.label12.TabIndex = 3;
            this.label12.Text = "C# Linq To XML ile XML Dosyalarla Çalışmak";
            // 
            // LINQ_to_XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 526);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LINQ_to_XML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINQ_to_XML";
            this.Load += new System.EventHandler(this.LINQ_to_XML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpg_Gridde_Goster.ResumeLayout(false);
            this.tpg_node_node_oku.ResumeLayout(false);
            this.tpg_node_node_oku.PerformLayout();
            this.tpg_sum_avg_count.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpg_select_order_by.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Bilgileri_Goster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox_normal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpg_Gridde_Goster;
        private System.Windows.Forms.TabPage tpg_node_node_oku;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_attiribute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_sadece_tek_node;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpg_sum_avg_count;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_avg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_avg_true;
        private System.Windows.Forms.TextBox txt_sum_true;
        private System.Windows.Forms.TextBox txt_count_true;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tpg_select_order_by;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox_select_order_by;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox_Group_by;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
        //https://mustafabukulmez.com/2019/01/05/c-linq-to-xml-ile-xml-dosyalarla-calismak/
    }
}