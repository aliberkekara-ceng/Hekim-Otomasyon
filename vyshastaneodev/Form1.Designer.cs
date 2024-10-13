namespace vyshastaneodev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ilac5 = new System.Windows.Forms.TextBox();
            this.txt_ilac4 = new System.Windows.Forms.TextBox();
            this.txt_ilac3 = new System.Windows.Forms.TextBox();
            this.txt_ilac2 = new System.Windows.Forms.TextBox();
            this.txt_ilac1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_receteNo = new System.Windows.Forms.TextBox();
            this.txt_hastalikTeshis = new System.Windows.Forms.TextBox();
            this.txt_hastaSikayet = new System.Windows.Forms.TextBox();
            this.txt_muayeneTarihi = new System.Windows.Forms.TextBox();
            this.txt_tcKimlikNo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reçeteYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verileriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(338, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(431, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(343, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(63, 245);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(711, 150);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta TC Kimlik Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Muayene Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta Şikayeti ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hastalık Teşhisi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reçete Numarası";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_receteNo);
            this.groupBox1.Controls.Add(this.txt_hastalikTeshis);
            this.groupBox1.Controls.Add(this.txt_hastaSikayet);
            this.groupBox1.Controls.Add(this.txt_muayeneTarihi);
            this.groupBox1.Controls.Add(this.txt_tcKimlikNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(63, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 318);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reçete";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ilac5);
            this.groupBox2.Controls.Add(this.txt_ilac4);
            this.groupBox2.Controls.Add(this.txt_ilac3);
            this.groupBox2.Controls.Add(this.txt_ilac2);
            this.groupBox2.Controls.Add(this.txt_ilac1);
            this.groupBox2.Location = new System.Drawing.Point(437, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 184);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlaç Yaz";
            // 
            // txt_ilac5
            // 
            this.txt_ilac5.Location = new System.Drawing.Point(20, 145);
            this.txt_ilac5.Name = "txt_ilac5";
            this.txt_ilac5.Size = new System.Drawing.Size(134, 23);
            this.txt_ilac5.TabIndex = 4;
            // 
            // txt_ilac4
            // 
            this.txt_ilac4.Location = new System.Drawing.Point(20, 116);
            this.txt_ilac4.Name = "txt_ilac4";
            this.txt_ilac4.Size = new System.Drawing.Size(134, 23);
            this.txt_ilac4.TabIndex = 3;
            // 
            // txt_ilac3
            // 
            this.txt_ilac3.Location = new System.Drawing.Point(20, 82);
            this.txt_ilac3.Name = "txt_ilac3";
            this.txt_ilac3.Size = new System.Drawing.Size(134, 23);
            this.txt_ilac3.TabIndex = 2;
            // 
            // txt_ilac2
            // 
            this.txt_ilac2.Location = new System.Drawing.Point(20, 53);
            this.txt_ilac2.Name = "txt_ilac2";
            this.txt_ilac2.Size = new System.Drawing.Size(134, 23);
            this.txt_ilac2.TabIndex = 1;
            // 
            // txt_ilac1
            // 
            this.txt_ilac1.Location = new System.Drawing.Point(20, 24);
            this.txt_ilac1.Name = "txt_ilac1";
            this.txt_ilac1.Size = new System.Drawing.Size(134, 23);
            this.txt_ilac1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(435, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reçete Yaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_receteNo
            // 
            this.txt_receteNo.Location = new System.Drawing.Point(170, 170);
            this.txt_receteNo.Name = "txt_receteNo";
            this.txt_receteNo.Size = new System.Drawing.Size(224, 23);
            this.txt_receteNo.TabIndex = 12;
            // 
            // txt_hastalikTeshis
            // 
            this.txt_hastalikTeshis.Location = new System.Drawing.Point(170, 138);
            this.txt_hastalikTeshis.Name = "txt_hastalikTeshis";
            this.txt_hastalikTeshis.Size = new System.Drawing.Size(224, 23);
            this.txt_hastalikTeshis.TabIndex = 11;
            // 
            // txt_hastaSikayet
            // 
            this.txt_hastaSikayet.Location = new System.Drawing.Point(170, 109);
            this.txt_hastaSikayet.Name = "txt_hastaSikayet";
            this.txt_hastaSikayet.Size = new System.Drawing.Size(224, 23);
            this.txt_hastaSikayet.TabIndex = 10;
            // 
            // txt_muayeneTarihi
            // 
            this.txt_muayeneTarihi.Location = new System.Drawing.Point(170, 75);
            this.txt_muayeneTarihi.Name = "txt_muayeneTarihi";
            this.txt_muayeneTarihi.Size = new System.Drawing.Size(224, 23);
            this.txt_muayeneTarihi.TabIndex = 9;
            // 
            // txt_tcKimlikNo
            // 
            this.txt_tcKimlikNo.Location = new System.Drawing.Point(170, 46);
            this.txt_tcKimlikNo.Name = "txt_tcKimlikNo";
            this.txt_tcKimlikNo.Size = new System.Drawing.Size(224, 23);
            this.txt_tcKimlikNo.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reçeteYazToolStripMenuItem,
            this.verileriGösterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reçeteYazToolStripMenuItem
            // 
            this.reçeteYazToolStripMenuItem.Name = "reçeteYazToolStripMenuItem";
            this.reçeteYazToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.reçeteYazToolStripMenuItem.Text = "Reçete Yaz";
            // 
            // verileriGösterToolStripMenuItem
            // 
            this.verileriGösterToolStripMenuItem.Name = "verileriGösterToolStripMenuItem";
            this.verileriGösterToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.verileriGösterToolStripMenuItem.Text = "Verileri Göster";
            this.verileriGösterToolStripMenuItem.Click += new System.EventHandler(this.verileriGösterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 765);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox txt_receteNo;
        private TextBox txt_hastalikTeshis;
        private TextBox txt_hastaSikayet;
        private TextBox txt_muayeneTarihi;
        private TextBox txt_tcKimlikNo;
        private GroupBox groupBox2;
        private TextBox txt_ilac5;
        private TextBox txt_ilac4;
        private TextBox txt_ilac3;
        private TextBox txt_ilac2;
        private TextBox txt_ilac1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem reçeteYazToolStripMenuItem;
        private ToolStripMenuItem verileriGösterToolStripMenuItem;
    }
}