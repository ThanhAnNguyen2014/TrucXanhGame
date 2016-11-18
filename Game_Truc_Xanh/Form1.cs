using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Truc_Xanh
{
	public partial class frmHome : Form
	{
		public frmHome()
		{
			InitializeComponent();
			form_Load();
		}
		public void form_Load()
		{
			btnBatDau.Visible = false;
			btnTamDung.Visible = false;
			thoiGiancbbox.Visible = false;
			diemcbbox.Visible = false;
			choiLaiToolStripMenuItem.Enabled = false;
			lbDiem.Visible = false;
			lbGiay.Visible = false;


		}
		int flag = 0; // khởi tạo giá trị cờ cho việc chọn chế độ

		private void deToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (btnData != null) // xóa các hình khi còn chơi game
                ResetGame();

            flag = 1;
			btnBatDau.Visible = true;
			btnTamDung.Visible = true;
			btnBatDau.Enabled = true;
			btnTamDung.Enabled = false;
            btnTamDung.Text = "Pause";
			thoiGiancbbox.Visible = true;
			diemcbbox.Visible = true;
			choiLaiToolStripMenuItem.Enabled = true;
			lbDiem.Visible = true;
			lbGiay.Visible = true;
			khoToolStripMenuItem.Enabled = false;
			trungBinhToolStripMenuItem.Enabled = false;
			deToolStripMenuItem.Enabled = false;
		}
		// khởi tạo một số biến liên quan.
		int n; // khởi tạo giá trị tương ứng với số button được hiển thị
		Button[] btnData;// khởi tạo mảng các button chứa hình ảnh
		// khởi tạo giá trị các tham số điểm số, phút, giây,số giây qui định và biến đếm (kiểm tra đã đủ số hình chọn đúng).
		int dem = 0, diemso = 0, phut = 0, giay = 0, giaydemnguoc = 0, diem=0;
		private void btnBatDau_Click(object sender, EventArgs e)
		{
			if(flag==1)
			{
				lbPhut.Visible = true;
				lbGiay.Visible = true;

				choiLaiToolStripMenuItem.Enabled = true;
				btnTamDung.Enabled = true;
				btnBatDau.Enabled = false;
				cheDoDe();
				RandomImage_De();
				timer1.Start();
				flag = 0;
			}else
				if(flag==2)
			{
				lbPhut.Visible = true;
				lbGiay.Visible = true;

				choiLaiToolStripMenuItem.Enabled = true;
				btnTamDung.Enabled = true;
				btnBatDau.Enabled = false;
				cheDoTrungBinh();
				RandomImage_TrungBinh();
				timer1.Start();
				flag = 0;
			}
			else
			if(flag==3)
			{
				lbPhut.Visible = true;
				lbGiay.Visible = true;

				choiLaiToolStripMenuItem.Enabled = true;
				btnTamDung.Enabled = true;
				btnBatDau.Enabled = false;
				cheDoKho();
				RandomImage_Kho();
				timer1.Start();
				flag = 0;
			}
				
			

		}

		// Xử lý khi người chơi chọn cấp độ dễ.
		public void cheDoDe()
		{
			int i = 0, j = 1;
			// xét thời gian để hoàn thành một lượt chơi.
			giay = 45;// Số giây qui định để hoàn thành một lượt chơi.
			phut = 0;
			n = 16; // một mảng chơi ở chế độ dễ có 16 hình.
			giaydemnguoc = giay + phut * 60; // tổng thời gian điếm ngược.
			btnData = new Button[n]; // khởi tạo mảng các button với 16 ô.
			for (int k = 0; k < n; k++)
			{
				btnData[k] = new Button(); // khởi tạo thuộc tính button.
				btnData[k].Size = new Size(75, 75);
				btnData[k].Image = Image.FromFile("daucham.jpg"); // load hình mặt định cho btn
				btnData[k].Location = new Point(i * 100 + 190, j * 100 + 80);// định dạng vị trí xuất hiện các btn
				btnData[k].Click += new EventHandler(Click_Handle); // đặt sự kiện click chuột cho btn.
				Controls.Add(btnData[k]); // thêm btn vào controls và hiển thị lên form
				i++;
				if (i == 4) // một hàng sẽ xuất hiện 4 hình
				{
					i = 0;
					j++;
				}
			}
		}
		// chế độ trung bình
		public void cheDoTrungBinh()
		{
            
            int i = 0, j = 1;
			// xét thời gian để hoàn thành một lượt chơi.
			giay = 30;// Số giây qui định để hoàn thành một lượt chơi.
			phut = 1;
			n = 24; // một mảng chơi ở chế độ dễ có 16 hình.
			giaydemnguoc = giay + phut * 60; // tổng thời gian điếm ngược.
			btnData = new Button[n]; // khởi tạo mảng các button với 16 ô.
			for (int k = 0; k < n; k++)
			{
				btnData[k] = new Button(); // khởi tạo thuộc tính button.
				btnData[k].Size = new Size(75, 75);
				btnData[k].Image = Image.FromFile("daucham.jpg"); // load hình mặt định cho btn
				btnData[k].Location = new Point(i * 85 + 140, j * 90+125);// định dạng vị trí xuất hiện các btn
				btnData[k].Click += new EventHandler(Click_Handle); // đặt sự kiện click chuột cho btn.
				Controls.Add(btnData[k]); // thêm btn vào controls và hiển thị lên form
				i++;
				if (i == 6) // một hàng sẽ xuất hiện 6 hình
				{
					i = 0;
					j++;
				}
			}
		}
		// random hình ở chế độ dễ
		// ý tưởng: lấy một mảng button , sau đó chia đôi để random vị trí, nữa còn lại sẽ random ngẫn nhiên lại từ những hình đã random chứa trong mảng.
		Random random = new Random();
		private void RandomImage_De()
		{
			ArrayList list = new ArrayList();
			for (int i = 0; i<btnData.Length/2; i++)
			{
				int j = random.Next(0, 8);
				btnData[i].Tag = j;
				list.Add(j);
			}
			for (int i = btnData.Length / 2; i < btnData.Length; i++)
			{
				int x = random.Next(0, list.Count - 1);
				btnData[i].Tag = list[x];
				list.RemoveAt(x);
			}

		}
		private void RandomImage_TrungBinh()
		{
			ArrayList list = new ArrayList();
			for (int i = 0; i < btnData.Length / 2; i++)
			{
				int j = random.Next(0, 12);
				btnData[i].Tag = j;
				list.Add(j);
			}
			for (int i = btnData.Length / 2; i < btnData.Length; i++)
			{
				int x = random.Next(0, list.Count - 1);
				btnData[i].Tag = list[x];
				list.RemoveAt(x);
			}

		}
		// che độ khó
		private void RandomImage_Kho()
		{
			ArrayList list = new ArrayList();
			for (int i = 0; i < btnData.Length / 2; i++)
			{
				int j = random.Next(0, 18);
				btnData[i].Tag = j;
				list.Add(j);
			}
			for (int i = btnData.Length / 2; i < btnData.Length; i++)
			{
				int x = random.Next(0, list.Count - 1);
				btnData[i].Tag = list[x];
				list.RemoveAt(x);
			}

		}
		public void cheDoKho()
		{
            int i = 0, j = 1;
			// xét thời gian để hoàn thành một lượt chơi.
			giay = 50;// Số giây qui định để hoàn thành một lượt chơi.
			phut = 1;
			n = 36; // một mảng chơi ở chế độ dễ có 16 hình.
			giaydemnguoc = giay + phut * 60; // tổng thời gian điếm ngược.
			btnData = new Button[n]; // khởi tạo mảng các button với 16 ô.
			for (int k = 0; k < n; k++)
			{
				btnData[k] = new Button(); // khởi tạo thuộc tính button.
				btnData[k].Size = new Size(75, 75);
				btnData[k].Image = Image.FromFile("daucham.jpg"); // load hình mặt định cho btn
				btnData[k].Location = new Point(i * 85 + 140, j * 90 + 25);// định dạng vị trí xuất hiện các btn
				btnData[k].Click += new EventHandler(Click_Handle); // đặt sự kiện click chuột cho btn.
				Controls.Add(btnData[k]); // thêm btn vào controls và hiển thị lên form
				i++;
				if (i == 6) // một hàng sẽ xuất hiện 6 hình
				{
					i = 0;
					j++;
				}
			}
		}

		private void thoiGiancbbox_Enter(object sender, EventArgs e)
		{

		}

		private void trungBinhToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (btnData != null)
                ResetGame();

            flag = 2;
			btnBatDau.Visible = true;
			btnTamDung.Visible = true;
			btnBatDau.Enabled = true;
			btnTamDung.Enabled = false;
            btnTamDung.Text = "Pause";
            thoiGiancbbox.Visible = true;
			diemcbbox.Visible = true;
			choiLaiToolStripMenuItem.Enabled = true;
			lbDiem.Visible = true;
			lbGiay.Visible = true;
			deToolStripMenuItem.Enabled = false;
			khoToolStripMenuItem.Enabled = false;
			trungBinhToolStripMenuItem.Enabled = false;
		}

		private void btnTamDung_Click(object sender, EventArgs e)
		{
			if (btnTamDung.Text == "Pause")
			{
				btnTamDung.Text = "Resume";// button Pause sẽ thay đổi thành button Resume
				timer1.Stop();//thời gian dừng lại
				for (int i = 0; i < btnData.Length; i++)
				{
					btnData[i].Image = Image.FromFile("daucham.jpg");
					btnData[i].Enabled = false;    //các button sẽ ẩn đi
				}
			}
			else
			{
				
				btnTamDung.Text = "Pause";// btn Resume sẽ thay đổi lại thành button Pause
				timer1.Start();//thời gian tiếp túc chạy
				for (int i = 0; i < btnData.Length; i++)
				{
					btnData[i].Enabled = true; //các button sẽ hiện lên
				}
			}
		}

		private void khoToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (btnData != null)
                ResetGame();

            flag = 3;
			btnBatDau.Visible = true;
			btnTamDung.Visible = true;
			btnBatDau.Enabled = true;
			btnTamDung.Enabled = false;
            btnTamDung.Text = "Pause";
            thoiGiancbbox.Visible = true;
			diemcbbox.Visible = true;
			choiLaiToolStripMenuItem.Enabled = true;
			lbDiem.Visible = true;
			lbGiay.Visible = true;
			deToolStripMenuItem.Enabled = false;
			khoToolStripMenuItem.Enabled = false;
			trungBinhToolStripMenuItem.Enabled = false;
			deToolStripMenuItem.Enabled = false;
		}

		private void choiLaiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn muốn từ bỏ à! \n Chơi lại luôn đi bạn ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
            {
                ResetGame();
                deToolStripMenuItem.Enabled = true;
                khoToolStripMenuItem.Enabled = true;
                trungBinhToolStripMenuItem.Enabled = true;
            }
				

		}
		// Choi lai
		public void ResetGame()
		{
			timer1.Stop();//thời gian dừng lại
			thoiGianprogressBar.Maximum = 0;
			diemso = 0;
            dem = 0;
			lbDiem.Text = diem.ToString();// Điểm sẽ reset lại thành giá trị 0
			lbPhut.Visible = false;
			lbGiay.Visible = false;
			diemcbbox.Enabled = true;
			thoiGiancbbox.Enabled = true;
			btnBatDau.Enabled = true;
			btnTamDung.Enabled = false;
            demclick = 0;
            indexbtn = -1;
            //Xóa tất cả các button hiện có trên form
            for (int i = 0; i < btnData.Length; i++)
			{

                btnData[i].Visible = false;
			}
			

		}


        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        // xử lý sự kiện click chuột vào btn
        int demclick = 0;

		private void huongDanChoiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form huongdan = new formHuongDanChoi();
			huongdan.Show();
		}

		private void thongtintools_Click(object sender, EventArgs e)
		{
			Form thongtin = new formThongTin();
			thongtin.Show();
		}

		int indexbtn = -1;

        public void Click_Handle(object sender, EventArgs e)
		{
            
            demclick++;//nhận mỗi lần nhấn btn tăng lên 1
            

            Button btn = (Button)sender;
            // Thực hiện ép kiểu đối tượng btn cho sender.
            btn.Image = Image.FromFile(btn.Tag.ToString() + ".jpg"); // thực hiện việc đưa hình vào btn
            if (demclick == 1)  //nếu là lần click vào btn là lần thứ 1
            {
                btn.Enabled = true;
                indexbtn = btn.TabIndex;  //nhận giá trị btn đã click
            }
                
            else if(btn.TabIndex!=indexbtn)  //nếu click là lần thứ 2 và phải khác btn lần 1
            {
                btn.Enabled = false;
                check_trung(indexbtn);//thay the ham check_image_trung
                demclick = 0;
                indexbtn = -1;
            }
            else //nếu click lại cùng 1 btn
            {
				falsemusic();
                btn.Enabled = true;
                btn.Image = Image.FromFile("daucham.jpg");
                indexbtn = -1;
                if (diemso > 0)
                {
                    diemso--;
                    lbDiem.Text = diemso.ToString();
                }
                demclick = 0;
            }
            //Check_Image_Trung();
           
            
		}
        // thực hiện việc check 2 hình trùng nhau.
        public void check_trung(int indexbtn)
        {
            for (int i = 0; i < btnData.Length; i++)
            {
                for (int j = 0; j < btnData.Length; j++)
                {
                    if (btnData[i].TabIndex == indexbtn && btnData[j].Enabled == false&& i!=j)
                    {
                        if (btnData[i].Tag.ToString() == btnData[j].Tag.ToString())
                        {
                            btnData[j].Enabled = true;
                            System.Threading.Thread.Sleep(300);
                            //correct();//âm thanh khi chọn đúng
                            btnData[i].Visible = false;//Hình ẩn đi
                            btnData[j].Visible = false;//Hình ẩn đi
                            dem++;
							truemusic();
                            diemso += 10;
                            lbDiem.Text = diemso.ToString();
                        }
                        else
                        {
                            btnData[j].Enabled = true;
							falsemusic();
                            System.Threading.Thread.Sleep(300);
                            //wrong();//âm thanh khi chọn sai
                            if (diemso > 0)
                                diemso -= 1;
                            lbDiem.Text = diemso.ToString();
                            btnData[i].Image = Image.FromFile("daucham.jpg");
                            btnData[j].Image = Image.FromFile("daucham.jpg");

                        }
                    }
                    
                }
            }
        }

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			giay--;
			
			if (giay == 0 && phut >= 1)
			{
				giay = 59;
				phut--;
				
			}
			
			thoiGianprogressBar.Maximum = giaydemnguoc;
			thoiGianprogressBar.Minimum = 0;
			thoiGianprogressBar.Step =1;
			thoiGianprogressBar.PerformStep();
			

			lbGiay.Text = giay.ToString() + " s";
			lbPhut.Text = phut.ToString() + " m :";
			Stop();
		}

		// xử lý khi hết giờ chơi quy định
		public void Stop()
		{
			if (phut == 0 && giay == 0)
			{
				timer1.Stop();
				btnTamDung.Enabled = false;
				for (int i = 0; i < btnData.Length - 1; i++)
				{
					for (int j = i + 1; j < btnData.Length; j++)
					{
						btnData[i].Enabled = false;
						btnData[j].Enabled = false;
					}
				}
                for(int i = 0; i < btnData.Length; i++)
                {
                    btnData[i].Image = Image.FromFile(btnData[i].Tag.ToString() + ".jpg");
                }
				MessageBox.Show("Đã hết thời gian!.", "Thông báo");
                deToolStripMenuItem.Enabled = true;
                trungBinhToolStripMenuItem.Enabled = true;
                khoToolStripMenuItem.Enabled = true;

            }
			else
			{
				for (int i = 0; i < btnData.Length - 1; i++)
				{
					if (dem == btnData.Length / 2)
					{
						btnTamDung.Enabled = false;
						timer1.Stop();
						dem = 0;
						MessageBox.Show("Chúc mừng bạn đã hoàn thành xong màn chơi ^.^ \nBạn đạt được " + lbDiem.Text + " điểm.", "Thông Báo");
                        deToolStripMenuItem.Enabled = true;
                        trungBinhToolStripMenuItem.Enabled = true;
                        khoToolStripMenuItem.Enabled = true;

					}
				}
			}
		}
		// âm thanh chọn đúng
		public void truemusic()
		{
			SoundPlayer sp = new SoundPlayer("audio.wav");
			sp.Play();
		}
		// âm thanh chọn sai
		public void falsemusic()
		{
			SoundPlayer sp = new SoundPlayer("audio2.wav");
			sp.Play();
		}


	}
}
