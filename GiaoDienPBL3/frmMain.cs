using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDienPBL3.UC;
using Guna.UI2.WinForms;

namespace GiaoDienPBL3
{
    public partial class frmMain : Form
    {
        public static UC_TrangChu myUC_TrangChu = new UC_TrangChu();
        public static UC_QuanLyMenu myUC_QuanLyMenu = new UC_QuanLyMenu();
        public static UC_QuanLyMay myUC_QuanLyMay = new UC_QuanLyMay();
        public static UC_QuanLyKho myUC_QuanLyKho = new UC_QuanLyKho();
        public frmMain()
        {
            InitializeComponent();
        }

        private void imgbtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TurnOffAllPanelQuanLy();
            SetOffAllCheckStateButton();
            AddUserControlOnBackGround(myUC_TrangChu);
            btnTrangChu.Checked = true;
            imgbtnThoat.Location = new Point(12, 750);
            myUC_TrangChu.Visible = true;
        }

        private void SetOffAllCheckStateButton()
        {
            btnQuanLy1.Checked = false;
            btnQuanLy2.Checked = false;
            btnQuanLy3.Checked = false;
            btnCaiDat.Checked = false;
            btnTrangChu.Checked = false;
        }

        private void SetOnCheckStateButton(Guna2Button btn)
        {
            SetOffAllCheckStateButton();
            btn.Checked = true;
        }

        private void HideSubMenu()
        {
            if (panelQuanLy1.Visible == true)
                panelQuanLy1.Visible = false;
            if (panelQuanLy2.Visible == true)
                panelQuanLy2.Visible = false;
            if (panelQuanLy3.Visible == true)
                panelQuanLy3.Visible = false;
            if (panelCaiDat.Visible == true)
                panelCaiDat.Visible = false;
        }

        private void TurnOffAllPanelQuanLy()
        {
            panelQuanLy1.Visible = false;
            panelQuanLy2.Visible = false;
            panelQuanLy3.Visible = false;
            panelCaiDat.Visible = false;
        }


        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnQuanLy1_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            SetOnCheckStateButton(btn);
            ShowSubMenu(panelQuanLy1);
        }

        private void btnQuanLy2_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            SetOnCheckStateButton(btn);
            ShowSubMenu(panelQuanLy2);
        }

        private void btnQuanLy3_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            SetOnCheckStateButton(btn);
            ShowSubMenu(panelQuanLy3);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            SetOnCheckStateButton(btn);
            ShowSubMenu(panelCaiDat);
        }

        private void AddUserControlOnBackGround(UserControl userControl)
        {
            panelBackGround.Controls.Clear();
            panelBackGround.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            SetOnCheckStateButton(btn);
            HideSubMenu();
            //panelBackGround.Controls.Clear();
            //panelBackGround.Controls.Add(myUC_TrangChu);
            //myUC_TrangChu.Dock = DockStyle.Fill;
            AddUserControlOnBackGround(myUC_TrangChu);
        }

        private void btnQuanLyMenu_Click(object sender, EventArgs e)
        {
            AddUserControlOnBackGround(myUC_QuanLyMenu);
        }

        private void btnQuanLyMay_Click(object sender, EventArgs e)
        {
            AddUserControlOnBackGround(myUC_QuanLyMay);
        }

        private void btnQuanLyKho_Click(object sender, EventArgs e)
        {
            AddUserControlOnBackGround(myUC_QuanLyKho);
        }
    }
}
