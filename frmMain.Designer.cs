namespace QLNhânSự
{
    partial class frmMain
    {
        public frmMain(String LoaiTK)
        {
            InitializeComponent();
            if(LoaiTK == "1")
            {
                //Principal
                mnuPheduyet.Enabled = true;
                mnuDanhsach.Enabled = true;
                mnuDieudong.Enabled = false;
                mnuThuyenchuyen.Enabled = false;
                mnuKiemnhiem.Enabled = false;
                mnuBietphai.Enabled = false;
                mnuDaotao.Enabled = false;
                mnuCudihoc.Enabled = false;
                mnuKhenthuong.Enabled = false;
                mnuBHXH.Enabled = false;
                mnuBienche.Enabled = false;
            }
            if (LoaiTK == "2")
            {
                //HR
                mnuDanhsach.Enabled = true;
                mnuDieudong.Enabled = true;
                mnuThuyenchuyen.Enabled = true;
                mnuKiemnhiem.Enabled = true;
                mnuBietphai.Enabled = true;
                mnuDaotao.Enabled = true;
                mnuCudihoc.Enabled = true;
                mnuKhenthuong.Enabled = true;
                mnuBHXH.Enabled = true;
                mnuBienche.Enabled = true;
                mnuPheduyet.Enabled = false;
                
                
            }
            if (LoaiTK == "3")
            {
                //Lecturers
                mnuDanhsach.Enabled = true;
                mnuDieudong.Enabled = false;
                mnuThuyenchuyen.Enabled = false;
                mnuKiemnhiem.Enabled = false;
                mnuBietphai.Enabled = false;
                mnuDaotao.Enabled = false;
                mnuCudihoc.Enabled = false;
                mnuKhenthuong.Enabled = false;
                mnuBHXH.Enabled = false;
                mnuBienche.Enabled = false;
                mnuPheduyet.Enabled = false;
            }
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhsach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDieudong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuyenchuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKiemnhiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBietphai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDaotao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCudihoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhenthuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBHXH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBienche = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPheduyet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhsach,
            this.mnuDieudong,
            this.mnuThuyenchuyen,
            this.mnuKiemnhiem,
            this.mnuBietphai,
            this.mnuDaotao,
            this.mnuCudihoc,
            this.mnuKhenthuong,
            this.mnuBHXH,
            this.mnuBienche,
            this.mnuPheduyet});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhsach
            // 
            this.mnuDanhsach.BackColor = System.Drawing.Color.Lavender;
            this.mnuDanhsach.Name = "mnuDanhsach";
            this.mnuDanhsach.Size = new System.Drawing.Size(132, 20);
            this.mnuDanhsach.Text = "Danh sách giảng viên";
            this.mnuDanhsach.Click += new System.EventHandler(this.mnuDanhsach_Click);
            // 
            // mnuDieudong
            // 
            this.mnuDieudong.BackColor = System.Drawing.Color.Lavender;
            this.mnuDieudong.Name = "mnuDieudong";
            this.mnuDieudong.Size = new System.Drawing.Size(74, 20);
            this.mnuDieudong.Text = "Điều động";
            // 
            // mnuThuyenchuyen
            // 
            this.mnuThuyenchuyen.BackColor = System.Drawing.Color.Lavender;
            this.mnuThuyenchuyen.Name = "mnuThuyenchuyen";
            this.mnuThuyenchuyen.Size = new System.Drawing.Size(100, 20);
            this.mnuThuyenchuyen.Text = "Thuyên chuyển";
            // 
            // mnuKiemnhiem
            // 
            this.mnuKiemnhiem.BackColor = System.Drawing.Color.Lavender;
            this.mnuKiemnhiem.Name = "mnuKiemnhiem";
            this.mnuKiemnhiem.Size = new System.Drawing.Size(83, 20);
            this.mnuKiemnhiem.Text = "Kiêm nhiệm";
            // 
            // mnuBietphai
            // 
            this.mnuBietphai.BackColor = System.Drawing.Color.Lavender;
            this.mnuBietphai.Name = "mnuBietphai";
            this.mnuBietphai.Size = new System.Drawing.Size(65, 20);
            this.mnuBietphai.Text = "Biệt phái";
            this.mnuBietphai.Click += new System.EventHandler(this.mnuBietphai_Click);
            // 
            // mnuDaotao
            // 
            this.mnuDaotao.BackColor = System.Drawing.Color.Lavender;
            this.mnuDaotao.Name = "mnuDaotao";
            this.mnuDaotao.Size = new System.Drawing.Size(118, 20);
            this.mnuDaotao.Text = "Đào tạo bồi dưỡng";
            // 
            // mnuCudihoc
            // 
            this.mnuCudihoc.BackColor = System.Drawing.Color.Lavender;
            this.mnuCudihoc.Name = "mnuCudihoc";
            this.mnuCudihoc.Size = new System.Drawing.Size(70, 20);
            this.mnuCudihoc.Text = "Cử đi học";
            this.mnuCudihoc.Click += new System.EventHandler(this.mnuCudihoc_Click);
            // 
            // mnuKhenthuong
            // 
            this.mnuKhenthuong.BackColor = System.Drawing.Color.Lavender;
            this.mnuKhenthuong.Name = "mnuKhenthuong";
            this.mnuKhenthuong.Size = new System.Drawing.Size(135, 20);
            this.mnuKhenthuong.Text = "Khen thưởng / Kỷ luật";
            // 
            // mnuBHXH
            // 
            this.mnuBHXH.BackColor = System.Drawing.Color.Lavender;
            this.mnuBHXH.Name = "mnuBHXH";
            this.mnuBHXH.Size = new System.Drawing.Size(93, 20);
            this.mnuBHXH.Text = "BHXH / BHTN";
            // 
            // mnuBienche
            // 
            this.mnuBienche.BackColor = System.Drawing.Color.Lavender;
            this.mnuBienche.Name = "mnuBienche";
            this.mnuBienche.Size = new System.Drawing.Size(119, 20);
            this.mnuBienche.Text = "Biên chế hợp đồng";
            // 
            // mnuPheduyet
            // 
            this.mnuPheduyet.BackColor = System.Drawing.Color.Lavender;
            this.mnuPheduyet.Name = "mnuPheduyet";
            this.mnuPheduyet.Size = new System.Drawing.Size(104, 20);
            this.mnuPheduyet.Text = "Phê duyệt hồ sơ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1266, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản Lý Nhân Sự";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuDanhsach;
        private ToolStripMenuItem mnuDieudong;
        private ToolStripMenuItem mnuThuyenchuyen;
        private ToolStripMenuItem mnuKiemnhiem;
        private ToolStripMenuItem mnuBietphai;
        private ToolStripMenuItem mnuDaotao;
        private ToolStripMenuItem mnuCudihoc;
        private ToolStripMenuItem mnuKhenthuong;
        private ToolStripMenuItem mnuBHXH;
        private ToolStripMenuItem mnuBienche;
        private ToolStripMenuItem mnuPheduyet;
    }
}