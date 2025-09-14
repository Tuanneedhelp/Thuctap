namespace LucMinhTuanCD230010
{
    partial class MenuChinh
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
            menuStrip1 = new MenuStrip();
            quanLyToolStripMenuItem = new ToolStripMenuItem();
            quanLyKhachHangToolStripMenuItem = new ToolStripMenuItem();
            quanLyPhongToolStripMenuItem = new ToolStripMenuItem();
            quanLyDatPhongToolStripMenuItem = new ToolStripMenuItem();
            quanLyThanhToanToolStripMenuItem = new ToolStripMenuItem();
            baoCaotoolStripMenuItem = new ToolStripMenuItem();
            dangXuatToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quanLyToolStripMenuItem, baoCaotoolStripMenuItem, dangXuatToolStripMenuItem, thoatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            quanLyToolStripMenuItem.BackColor = Color.Beige;
            quanLyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quanLyKhachHangToolStripMenuItem, quanLyPhongToolStripMenuItem, quanLyDatPhongToolStripMenuItem, quanLyThanhToanToolStripMenuItem });
            quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            quanLyToolStripMenuItem.Size = new Size(60, 20);
            quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // quanLyKhachHangToolStripMenuItem
            // 
            quanLyKhachHangToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            quanLyKhachHangToolStripMenuItem.Name = "quanLyKhachHangToolStripMenuItem";
            quanLyKhachHangToolStripMenuItem.Size = new Size(180, 22);
            quanLyKhachHangToolStripMenuItem.Text = "Quản lý khách hàng";
            quanLyKhachHangToolStripMenuItem.Click += quanLyKhachHangToolStripMenuItem_Click;
            // 
            // quanLyPhongToolStripMenuItem
            // 
            quanLyPhongToolStripMenuItem.BackColor = SystemColors.Highlight;
            quanLyPhongToolStripMenuItem.Name = "quanLyPhongToolStripMenuItem";
            quanLyPhongToolStripMenuItem.Size = new Size(180, 22);
            quanLyPhongToolStripMenuItem.Text = "Quản lý phòng";
            quanLyPhongToolStripMenuItem.Click += quanLyPhongToolStripMenuItem_Click;
            // 
            // quanLyDatPhongToolStripMenuItem
            // 
            quanLyDatPhongToolStripMenuItem.BackColor = Color.RosyBrown;
            quanLyDatPhongToolStripMenuItem.Name = "quanLyDatPhongToolStripMenuItem";
            quanLyDatPhongToolStripMenuItem.Size = new Size(180, 22);
            quanLyDatPhongToolStripMenuItem.Text = "Quản lý đặt phòng";
            quanLyDatPhongToolStripMenuItem.Click += quanLyDatPhongToolStripMenuItem_Click;
            // 
            // quanLyThanhToanToolStripMenuItem
            // 
            quanLyThanhToanToolStripMenuItem.BackColor = Color.Gold;
            quanLyThanhToanToolStripMenuItem.Name = "quanLyThanhToanToolStripMenuItem";
            quanLyThanhToanToolStripMenuItem.Size = new Size(180, 22);
            quanLyThanhToanToolStripMenuItem.Text = "Quản lý thanh toán";
            quanLyThanhToanToolStripMenuItem.Click += quanLyThanhToanToolStripMenuItem_Click;
            // 
            // baoCaotoolStripMenuItem
            // 
            baoCaotoolStripMenuItem.BackColor = Color.LimeGreen;
            baoCaotoolStripMenuItem.Name = "baoCaotoolStripMenuItem";
            baoCaotoolStripMenuItem.Size = new Size(61, 20);
            baoCaotoolStripMenuItem.Text = "Báo cáo";
            baoCaotoolStripMenuItem.Click += baoCaotoolStripMenuItem_Click;
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.BackColor = Color.Yellow;
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(73, 20);
            dangXuatToolStripMenuItem.Text = "Đăng xuất";
            dangXuatToolStripMenuItem.Click += dangXuatToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.BackColor = Color.Crimson;
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(49, 20);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // MenuChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(700, 422);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý khách sạn";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyDatPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyThanhToanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaotoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
    }
}