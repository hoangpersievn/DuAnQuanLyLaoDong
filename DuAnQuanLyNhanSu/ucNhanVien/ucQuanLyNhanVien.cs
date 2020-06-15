using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAnQuanLyNhanSu.ucHeThong;
using MetroFramework.Controls;

namespace DuAnQuanLyNhanSu.ucNhanVien
{
    public partial class ucQuanLyNhanVien : UserControl
    {
        public ucQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            //Khởi tạo user màn hình chính
            ucManHinhChinh ucManHinhChinh = new ucManHinhChinh();
            ucManHinhChinh.Dock = DockStyle.Fill;
            //Add vào panel chính
            FormMain.FrmMain.MetroContainer.Controls.Add(ucManHinhChinh);
            FormMain.FrmMain.MetroContainer.Controls["ucManHinhChinh"].BringToFront();
            foreach (ucQuanLyNhanVien templateNhanVien in FormMain.FrmMain.MetroContainer.Controls.OfType<ucQuanLyNhanVien>())
            {
                FormMain.FrmMain.MetroContainer.Controls.Remove(templateNhanVien);
            }


        }

        private void mPanelMenuItem_MouseHover(object sender, EventArgs e)
        {
            //Xác định panel được chọn 
            MetroPanel pnl = (MetroPanel)sender;
            //Xét thuộc tính cho phép thay đổi màu nền
            pnl.UseCustomBackColor = true;
            //Đổi màu nền
            pnl.BackColor = Color.FromArgb(126, 158, 166);

        }

        private void mPanelMenuItem_MouseLeave(object sender, EventArgs e)
        {
            //Xác định panel được chọn 
            MetroPanel mPanel = (MetroPanel)sender;
            //Xét thuộc tính cho phép thay đổi màu nền
            mPanel.UseCustomBackColor = true;
            //Đổi màu nền
            mPanel.BackColor = Color.FromArgb(0, 64, 80);
            if (mPanel.Tag.ToString() == "1")
            {
                mPanel.BackColor = Color.FromArgb(126, 158, 166); //Màu được thay đổi
            }
            else
            {
                mPanel.BackColor = Color.FromArgb(0, 64, 80); // Màu gốc
            }
        }
        //mouseLeave
        private void metroLabel_MouseLeave(object sender, EventArgs e)
        {
            //Xác định control đựa chọn (tương tác sự kiện)
            MetroLabel mLbl = (MetroLabel) sender;
            //Truy xuất đến phần tử chứa nó
            MetroPanel pnlParent = (MetroPanel)mLbl.Parent;
            pnlParent.UseCustomBackColor = true;
            if (pnlParent.Tag.ToString() == "1")
            {
                pnlParent.BackColor = Color.FromArgb(126, 158, 166); //Màu được thay đổi
            }
            else
            {
                pnlParent.BackColor = Color.FromArgb(0, 64, 80); // Màu gốc
            }
        }
        //hover
        private void metroLabel_MouseHover(object sender, EventArgs e)
        {
            //Xác định control đựa chọn (tương tác sự kiện)
            MetroLabel mLbl = (MetroLabel)sender;
            //Truy xuất đến phần tử chứa nó (phần tử cha)
            MetroPanel pnlParent = (MetroPanel)mLbl.Parent;
            pnlParent.UseCustomBackColor = true;
            pnlParent.BackColor = Color.FromArgb(126, 158, 166); //Màu được thay đổi
        }
        //active
        private void mPanel_Click(object sender, EventArgs e)
        {
            MetroPanel mPanel = (MetroPanel)sender;
            MetroPanel mPanelParent = (MetroPanel)mPanel.Parent; // Panel cha (chứa)
            //Xóa màu
            foreach (MetroPanel pnlChild in mPanelParent.Controls.OfType<MetroPanel>())
            {
                pnlChild.Tag = 0;
                pnlChild.BackColor = Color.FromArgb(0, 64, 80); // Màu gốc
            }
            //thêm màu panel được chọn
            mPanel.UseCustomBackColor = true;
            mPanel.Tag = 1;
            mPanel.BackColor = Color.FromArgb(126, 158, 166);
            //Lấy name của userControl gọi phương thức hiển thị nội dung uc
            NoiDungUserControl(mPanel.AccessibleName);
        }

        private void metroLabel_Click(object sender, EventArgs e)
        {
            MetroLabel mLbl = (MetroLabel)sender;
            MetroPanel mPanel = (MetroPanel)mLbl.Parent;
            MetroPanel mPanelParent = (MetroPanel)mPanel.Parent; // Panel cha (chứa)
            //Xóa màu
            foreach (MetroPanel pnlChild in mPanelParent.Controls.OfType<MetroPanel>())
            {
                pnlChild.Tag = 0;
                pnlChild.BackColor = Color.FromArgb(0, 64, 80); // Màu gốc
            }
            //thêm màu panel được chọn
            mPanel.UseCustomBackColor = true;
            mPanel.Tag = 1;
            mPanel.BackColor = Color.FromArgb(126, 158, 166);
            //Lấy name của userControl gọi phương thức hiển thị nội dung uc
            NoiDungUserControl(mPanel.AccessibleName);
        }
        public void NoiDungUserControl(string ucName)
        {
            //Xóa hết những user control trong phần
            foreach (UserControl uc in mPanelContent.Controls.OfType<UserControl>())
            {
                mPanelContent.Controls.Remove(uc);
            }
            //Add ucName vào
            switch (ucName)
            {
                case "ucHoSoNhanVien": {
                        ucHoSoNhanVien uc = new ucHoSoNhanVien();
                        uc.Dock = DockStyle.Fill;
                        mPanelContent.Controls.Add(uc);
                        mPanelContent.Controls["ucHoSoNhanVien"].BringToFront();
                    };break;
                case "ucNhanVienThoiViec": {
                        ucNhanVienThoiViec uc = new ucNhanVienThoiViec();
                        uc.Dock = DockStyle.Fill;
                        mPanelContent.Controls.Add(uc);
                        mPanelContent.Controls["ucNhanVienThoiViec"].BringToFront();
                    }; break;
                case "ucNhapXuatNhanVien": {
                        ucNhapXuatNhanVien uc = new ucNhapXuatNhanVien();
                        uc.Dock = DockStyle.Fill;
                        mPanelContent.Controls.Add(uc);
                        mPanelContent.Controls["ucNhapXuatNhanVien"].BringToFront();
                    }; break;
                case "ucHopDongNhanVien": {
                        ucHopDongNhanVien uc = new ucHopDongNhanVien();
                        uc.Dock = DockStyle.Fill;
                        mPanelContent.Controls.Add(uc);
                        mPanelContent.Controls["ucHopDongNhanVien"].BringToFront();

                    }; break;

            } 
        }


    }
}
