﻿using QuanLyQuanNet.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberManagementProject.NhanVien
{
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();

            //khởi tạo text mặc định cho các ô textbox

            txtTaiKhoan.Text = "Tài khoản";
            txtTaiKhoan.ForeColor = Color.Gray;


            txtMatKhau.PasswordChar = '\0';
            txtMatKhau.Text = "Mật khẩu";
            txtMatKhau.ForeColor = Color.Gray;
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Tài khoản")
            {
                txtTaiKhoan.Text = ""; // Xóa nội dung mặc định
                txtTaiKhoan.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text)) //Kiểm tra ô textbox rỗng
            {
                txtTaiKhoan.Text = "Tài khoản"; // Hiển thị lại nội dung mặc định
                txtTaiKhoan.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.PasswordChar = '*';
                txtMatKhau.Text = ""; // Xóa nội dung mặc định
                txtMatKhau.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text)) //Kiểm tra ô textbox rỗng
            {
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.Text = "Mật khẩu"; // Hiển thị lại nội dung mặc định
                txtMatKhau.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Main f = new frmKhachHang_Main();
            DialogResult dialog = MessageBox.Show("Ban co muon thoat?",
                            "Thong Bao",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
