using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FormDangnhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{8,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9]{3,}@gmail.com(.vn|)$");
        }
        public bool CheckMatkhau (string cmk)
        {
            return Regex.IsMatch(cmk, @"^(?=.*[!@#$%^&*(),.?""{}|<>])[A-Za-z\d!@#$%^&*(),.?""{}|<>]{8,}$");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string matkhau = textMatkhau.Text;
            String email = textEmail.Text;
            string xacnhanmk = textMatkhau2.Text;
            if (!CheckEmail (email)) { MessageBox.Show("vui long nhap lai email"); return; }
            if (!CheckMatkhau(matkhau)) { MessageBox.Show("vui long chon lai mat khau hop le"); return; }
            if(xacnhanmk != matkhau) { MessageBox.Show("vui long nhap lai mat khau"); return; }
            MessageBox.Show("dang ky thanh cong!");
        }

        private void textMatkhau_TextChanged(object sender, EventArgs e)
        {
            this.textMatkhau.PasswordChar = '*';
        }

        private void textMatkhau2_TextChanged(object sender, EventArgs e)
        {
            this.textMatkhau2.PasswordChar = '*';
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("ban co muon thoat khong?", "thong bao", MessageBoxButtons.OKCancel);
            if(DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
