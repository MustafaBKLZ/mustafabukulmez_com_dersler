namespace mustafabukulmez_com_dersler._004_Thread_Sleep_ile_Islem_Suresini_Uzatmak
{
    partial class thread_sleep
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tmr_1 = new System.Windows.Forms.Label();
            this.lbl_tmr_2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_basla_thread = new System.Windows.Forms.Button();
            this.btn_basla_normal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(72, 195);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 308);
            this.listBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(358, 195);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(177, 308);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thread";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(404, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Normal";
            // 
            // lbl_tmr_1
            // 
            this.lbl_tmr_1.AutoSize = true;
            this.lbl_tmr_1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tmr_1.Location = new System.Drawing.Point(122, 520);
            this.lbl_tmr_1.Name = "lbl_tmr_1";
            this.lbl_tmr_1.Size = new System.Drawing.Size(69, 21);
            this.lbl_tmr_1.TabIndex = 4;
            this.lbl_tmr_1.Text = "Timer1";
            // 
            // lbl_tmr_2
            // 
            this.lbl_tmr_2.AutoSize = true;
            this.lbl_tmr_2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tmr_2.Location = new System.Drawing.Point(418, 520);
            this.lbl_tmr_2.Name = "lbl_tmr_2";
            this.lbl_tmr_2.Size = new System.Drawing.Size(69, 21);
            this.lbl_tmr_2.TabIndex = 5;
            this.lbl_tmr_2.Text = "Timer2";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_basla_thread
            // 
            this.btn_basla_thread.Location = new System.Drawing.Point(72, 21);
            this.btn_basla_thread.Name = "btn_basla_thread";
            this.btn_basla_thread.Size = new System.Drawing.Size(177, 61);
            this.btn_basla_thread.TabIndex = 6;
            this.btn_basla_thread.Text = "Başla";
            this.btn_basla_thread.UseVisualStyleBackColor = true;
            this.btn_basla_thread.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // btn_basla_normal
            // 
            this.btn_basla_normal.Location = new System.Drawing.Point(358, 21);
            this.btn_basla_normal.Name = "btn_basla_normal";
            this.btn_basla_normal.Size = new System.Drawing.Size(177, 61);
            this.btn_basla_normal.TabIndex = 7;
            this.btn_basla_normal.Text = "Başla";
            this.btn_basla_normal.UseVisualStyleBackColor = true;
            this.btn_basla_normal.Click += new System.EventHandler(this.btn_basla_normal_Click);
            // 
            // thread_sleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 612);
            this.Controls.Add(this.btn_basla_normal);
            this.Controls.Add(this.btn_basla_thread);
            this.Controls.Add(this.lbl_tmr_2);
            this.Controls.Add(this.lbl_tmr_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "thread_sleep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "thread_sleep";
            this.Load += new System.EventHandler(this.thread_sleep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tmr_1;
        private System.Windows.Forms.Label lbl_tmr_2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_basla_thread;
        private System.Windows.Forms.Button btn_basla_normal;
    }
}