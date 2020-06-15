using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAnQuanLyNhanSu.ucNhanVien;
using MetroFramework;
using MetroFramework.Controls;
using DuAnQuanLyNhanSu.ucHopDong;

namespace DuAnQuanLyNhanSu.ucHeThong
{
    public partial class ucManHinhChinh : UserControl
    {
        int changePointX = 0;
        int donViDichChuyen = 50;
        string ucName = "";
        public ucManHinhChinh()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MetroTile btn = (MetroTile)sender;
            ucName = btn.Tag.ToString();//xác định button uc nào được click
            //Gọi phương thức bắt của timer
            timerManHinhChinh.Start();
         
        }

        private void timerManHinhChinh_Tick(object sender, EventArgs e)
        {
            if (changePointX >= mPanelContainer.Size.Width)
            {
                timerManHinhChinh.Stop();

                switch (ucName)
                {
                    case "ucNhanVien": {
                            //Khởi tạo template nhân viên
                            ucQuanLyNhanVien tmpNhanVien = new ucQuanLyNhanVien();
                            tmpNhanVien.Dock = DockStyle.Fill;
                            //Add template nhân viên vào panel chính
                            FormMain.FrmMain.MetroContainer.Controls.Add(tmpNhanVien);
                            FormMain.FrmMain.MetroContainer.Controls["templateNhanVien"].BringToFront();
                            //xóa ucManHinhChinh
                            foreach (ucManHinhChinh ucManHinhChinh in FormMain.FrmMain.MetroContainer.Controls.OfType<ucManHinhChinh>())
                            {
                                FormMain.FrmMain.MetroContainer.Controls.Remove(ucManHinhChinh);
                            }
                        };break;
                    case "ucHopDong":
                        {
                            //Khởi tạo template nhân viên
                            templateHopDong ucHopDong = new templateHopDong();
                            ucHopDong.Dock = DockStyle.Fill;
                            //Add template nhân viên vào panel chính
                            FormMain.FrmMain.MetroContainer.Controls.Add(ucHopDong);
                            FormMain.FrmMain.MetroContainer.Controls["templateHopDong"].BringToFront();
                            //xóa ucManHinhChinh
                            foreach (ucManHinhChinh ucManHinhChinh in FormMain.FrmMain.MetroContainer.Controls.OfType<ucManHinhChinh>())
                            {
                                FormMain.FrmMain.MetroContainer.Controls.Remove(ucManHinhChinh);
                            }
                        }; break;
                }
               
            }
            else
            {
                changePointX = changePointX + donViDichChuyen;
                mPanelContainer.Location = new Point(changePointX,0);
            }
        }

       
    }
}
