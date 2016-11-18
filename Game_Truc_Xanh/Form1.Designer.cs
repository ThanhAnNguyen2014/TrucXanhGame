namespace Game_Truc_Xanh
{
	partial class frmHome
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.choiMoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trungBinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.choiLaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.huongDanChoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thongtintools = new System.Windows.Forms.ToolStripMenuItem();
			this.diemcbbox = new System.Windows.Forms.GroupBox();
			this.lbDiem = new System.Windows.Forms.Label();
			this.thoiGiancbbox = new System.Windows.Forms.GroupBox();
			this.lbs = new System.Windows.Forms.Label();
			this.lnm = new System.Windows.Forms.Label();
			this.lbGiay = new System.Windows.Forms.Label();
			this.lbPhut = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.thoiGianprogressBar = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBatDau = new System.Windows.Forms.Button();
			this.btnTamDung = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.toolStrip1.SuspendLayout();
			this.diemcbbox.SuspendLayout();
			this.thoiGiancbbox.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(784, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choiMoiToolStripMenuItem,
            this.choiLaiToolStripMenuItem,
            this.thoatToolStripMenuItem});
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(71, 22);
			this.toolStripDropDownButton1.Text = "Lựa Chọn";
			// 
			// choiMoiToolStripMenuItem
			// 
			this.choiMoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deToolStripMenuItem,
            this.trungBinhToolStripMenuItem,
            this.khoToolStripMenuItem});
			this.choiMoiToolStripMenuItem.Name = "choiMoiToolStripMenuItem";
			this.choiMoiToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.choiMoiToolStripMenuItem.Text = "Chơi Mới";
			// 
			// deToolStripMenuItem
			// 
			this.deToolStripMenuItem.Name = "deToolStripMenuItem";
			this.deToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.deToolStripMenuItem.Text = "Dễ";
			this.deToolStripMenuItem.Click += new System.EventHandler(this.deToolStripMenuItem_Click);
			// 
			// trungBinhToolStripMenuItem
			// 
			this.trungBinhToolStripMenuItem.Name = "trungBinhToolStripMenuItem";
			this.trungBinhToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.trungBinhToolStripMenuItem.Text = "Trung Bình";
			this.trungBinhToolStripMenuItem.Click += new System.EventHandler(this.trungBinhToolStripMenuItem_Click);
			// 
			// khoToolStripMenuItem
			// 
			this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
			this.khoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.khoToolStripMenuItem.Text = "Khó";
			this.khoToolStripMenuItem.Click += new System.EventHandler(this.khoToolStripMenuItem_Click);
			// 
			// choiLaiToolStripMenuItem
			// 
			this.choiLaiToolStripMenuItem.Name = "choiLaiToolStripMenuItem";
			this.choiLaiToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.choiLaiToolStripMenuItem.Text = "Chơi Lại";
			this.choiLaiToolStripMenuItem.Click += new System.EventHandler(this.choiLaiToolStripMenuItem_Click);
			// 
			// thoatToolStripMenuItem
			// 
			this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
			this.thoatToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.thoatToolStripMenuItem.Text = "Thoát";
			this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huongDanChoiToolStripMenuItem,
            this.thongtintools});
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(65, 22);
			this.toolStripDropDownButton2.Text = "Trợ Giúp";
			// 
			// huongDanChoiToolStripMenuItem
			// 
			this.huongDanChoiToolStripMenuItem.Name = "huongDanChoiToolStripMenuItem";
			this.huongDanChoiToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.huongDanChoiToolStripMenuItem.Text = "Hướng dẫn chơi";
			this.huongDanChoiToolStripMenuItem.Click += new System.EventHandler(this.huongDanChoiToolStripMenuItem_Click);
			// 
			// thongtintools
			// 
			this.thongtintools.Name = "thongtintools";
			this.thongtintools.Size = new System.Drawing.Size(160, 22);
			this.thongtintools.Text = "Thông Tin";
			this.thongtintools.Click += new System.EventHandler(this.thongtintools_Click);
			// 
			// diemcbbox
			// 
			this.diemcbbox.BackColor = System.Drawing.Color.Transparent;
			this.diemcbbox.Controls.Add(this.lbDiem);
			this.diemcbbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.diemcbbox.ForeColor = System.Drawing.Color.Red;
			this.diemcbbox.Location = new System.Drawing.Point(652, 32);
			this.diemcbbox.Name = "diemcbbox";
			this.diemcbbox.Size = new System.Drawing.Size(130, 55);
			this.diemcbbox.TabIndex = 2;
			this.diemcbbox.TabStop = false;
			this.diemcbbox.Text = "Điểm:";
			// 
			// lbDiem
			// 
			this.lbDiem.AutoSize = true;
			this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDiem.Location = new System.Drawing.Point(45, 20);
			this.lbDiem.Name = "lbDiem";
			this.lbDiem.Size = new System.Drawing.Size(25, 25);
			this.lbDiem.TabIndex = 0;
			this.lbDiem.Text = "0";
			// 
			// thoiGiancbbox
			// 
			this.thoiGiancbbox.BackColor = System.Drawing.Color.Transparent;
			this.thoiGiancbbox.Controls.Add(this.lbs);
			this.thoiGiancbbox.Controls.Add(this.lnm);
			this.thoiGiancbbox.Controls.Add(this.lbGiay);
			this.thoiGiancbbox.Controls.Add(this.lbPhut);
			this.thoiGiancbbox.Controls.Add(this.label2);
			this.thoiGiancbbox.Controls.Add(this.thoiGianprogressBar);
			this.thoiGiancbbox.Controls.Add(this.label1);
			this.thoiGiancbbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.thoiGiancbbox.ForeColor = System.Drawing.Color.Red;
			this.thoiGiancbbox.Location = new System.Drawing.Point(8, 28);
			this.thoiGiancbbox.Name = "thoiGiancbbox";
			this.thoiGiancbbox.Size = new System.Drawing.Size(437, 71);
			this.thoiGiancbbox.TabIndex = 3;
			this.thoiGiancbbox.TabStop = false;
			this.thoiGiancbbox.Text = "Thời gian";
			this.thoiGiancbbox.Enter += new System.EventHandler(this.thoiGiancbbox_Enter);
			// 
			// lbs
			// 
			this.lbs.AutoSize = true;
			this.lbs.ForeColor = System.Drawing.Color.Red;
			this.lbs.Location = new System.Drawing.Point(283, 13);
			this.lbs.Name = "lbs";
			this.lbs.Size = new System.Drawing.Size(0, 18);
			this.lbs.TabIndex = 7;
			// 
			// lnm
			// 
			this.lnm.AutoSize = true;
			this.lnm.ForeColor = System.Drawing.Color.Red;
			this.lnm.Location = new System.Drawing.Point(205, 14);
			this.lnm.Name = "lnm";
			this.lnm.Size = new System.Drawing.Size(0, 18);
			this.lnm.TabIndex = 4;
			// 
			// lbGiay
			// 
			this.lbGiay.AutoSize = true;
			this.lbGiay.Location = new System.Drawing.Point(238, 15);
			this.lbGiay.Name = "lbGiay";
			this.lbGiay.Size = new System.Drawing.Size(47, 18);
			this.lbGiay.TabIndex = 6;
			this.lbGiay.Text = "Giây:";
			// 
			// lbPhut
			// 
			this.lbPhut.AutoSize = true;
			this.lbPhut.Location = new System.Drawing.Point(159, 15);
			this.lbPhut.Name = "lbPhut";
			this.lbPhut.Size = new System.Drawing.Size(47, 18);
			this.lbPhut.TabIndex = 5;
			this.lbPhut.Text = "Phút:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(366, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kết thúc";
			// 
			// thoiGianprogressBar
			// 
			this.thoiGianprogressBar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.thoiGianprogressBar.Location = new System.Drawing.Point(65, 42);
			this.thoiGianprogressBar.Name = "thoiGianprogressBar";
			this.thoiGianprogressBar.Size = new System.Drawing.Size(300, 13);
			this.thoiGianprogressBar.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(2, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bắt đầu";
			// 
			// btnBatDau
			// 
			this.btnBatDau.BackColor = System.Drawing.Color.Lime;
			this.btnBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBatDau.Location = new System.Drawing.Point(462, 44);
			this.btnBatDau.Name = "btnBatDau";
			this.btnBatDau.Size = new System.Drawing.Size(80, 46);
			this.btnBatDau.TabIndex = 4;
			this.btnBatDau.Text = "Play";
			this.btnBatDau.UseVisualStyleBackColor = false;
			this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
			// 
			// btnTamDung
			// 
			this.btnTamDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnTamDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTamDung.Location = new System.Drawing.Point(556, 44);
			this.btnTamDung.Name = "btnTamDung";
			this.btnTamDung.Size = new System.Drawing.Size(80, 46);
			this.btnTamDung.TabIndex = 5;
			this.btnTamDung.Text = "Pause";
			this.btnTamDung.UseVisualStyleBackColor = false;
			this.btnTamDung.Click += new System.EventHandler(this.btnTamDung_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// frmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Game_Truc_Xanh.Properties.Resources.pikachu;
			this.ClientSize = new System.Drawing.Size(784, 661);
			this.Controls.Add(this.btnTamDung);
			this.Controls.Add(this.btnBatDau);
			this.Controls.Add(this.thoiGiancbbox);
			this.Controls.Add(this.diemcbbox);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "frmHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Game Trúc Xanh Mini";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.diemcbbox.ResumeLayout(false);
			this.diemcbbox.PerformLayout();
			this.thoiGiancbbox.ResumeLayout(false);
			this.thoiGiancbbox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem choiMoiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem choiLaiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem huongDanChoiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thongtintools;
		private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trungBinhToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
		private System.Windows.Forms.GroupBox diemcbbox;
		private System.Windows.Forms.Label lbDiem;
		private System.Windows.Forms.GroupBox thoiGiancbbox;
		private System.Windows.Forms.ProgressBar thoiGianprogressBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbPhut;
		private System.Windows.Forms.Label lbGiay;
		private System.Windows.Forms.Button btnBatDau;
		private System.Windows.Forms.Button btnTamDung;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbs;
		private System.Windows.Forms.Label lnm;
    }
}

