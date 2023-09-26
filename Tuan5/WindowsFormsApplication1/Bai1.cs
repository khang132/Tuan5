﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_2033216444_DoPhucKhang
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();

        }

        private void a_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }
        private void b_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void Bai01_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn thoát ứng dụng?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        public double Cong(double a, double b)
        {
            return a + b;
        }
        public double Tru(double a, double b)
        {
            return a - b;
        }
        public double Nhan(double a, double b)
        {
            return a * b;
        }
        public double Chia(double a, double b)
        {
            return a / b;
        }
        private void cong_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = (Convert.ToDouble(txtA.Text)).ToString();
                txtB.Text = (Convert.ToDouble(txtB.Text)).ToString();
                ketqua.Text = (Convert.ToDouble(txtA.Text) + Convert.ToDouble(txtB.Text)).ToString();

            }
            catch
            {
                MessageBox.Show("Dữ Liệu Không Đúng Vui Lòng Nhập Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = (Convert.ToDouble(txtA.Text)).ToString();
                txtB.Text = (Convert.ToDouble(txtB.Text)).ToString();
                ketqua.Text = (Convert.ToDouble(txtA.Text) - Convert.ToDouble(txtB.Text)).ToString();

            }
            catch
            {
                MessageBox.Show("Bạn Đã Nhập Sai Dữ Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = (Convert.ToDouble(txtA.Text)).ToString();
                txtB.Text = (Convert.ToDouble(txtB.Text)).ToString();
                ketqua.Text = (Convert.ToDouble(txtA.Text) * Convert.ToDouble(txtB.Text)).ToString();

            }
            catch
            {
                MessageBox.Show("Bạn Đã Nhập Sai Dữ Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = (Convert.ToDouble(txtA.Text)).ToString();
                txtB.Text = (Convert.ToDouble(txtB.Text)).ToString();
                ketqua.Text = (Convert.ToDouble(txtA.Text) / Convert.ToDouble(txtB.Text)).ToString();

            }
            catch
            {
                MessageBox.Show("Bạn Đã Nhập Sai Dữ Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            ketqua.Text = "";
        }

        private void Bai01_Load(object sender, EventArgs e)
        {

        }




    }
}
