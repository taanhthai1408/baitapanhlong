using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using baitapanhlong.C_;
using System.Security.Cryptography;

namespace baitapanhlong
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlDataAdapter bo_doc_gi;
        DataTable bang;
        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                 string mk = txtmk2.Text.Trim();
            string mkl = txtnlmk2.Text.Trim();
            if (mk != mkl)
            {
                MessageBox.Show("mật khẩu nhập lại không đúng");
                return;
            }
            else
            {
                string password;
                HashAlgorithm hassword = new MD5CryptoServiceProvider();
                byte[] hassbyte = hassword.ComputeHash(Encoding.UTF8.GetBytes(txtmk2.Text));
                password = Convert.ToBase64String(hassbyte);
                SqlConnection ketnoi = ket_noi.tao_ket_noi();
                string lenhsql = "Select * From dangkitk";
                bo_doc_gi = new SqlDataAdapter(lenhsql, ketnoi);
                SqlCommandBuilder saoluu = new SqlCommandBuilder(bo_doc_gi);
                bang = new DataTable();
                bo_doc_gi.Fill(bang);
                DataRow dongthem = bang.NewRow();
                dongthem["ID"] = txttdn2.Text.Trim();
                dongthem["MK"] = password;
                dongthem["ho_ten"] = txthoten.Text;
                dongthem["nam_sinh"] = DateTime.Parse(txtnamsinh.Text);
                dongthem["truong"] = txttruong.Text;
                dongthem["khoa"] = txtkhoa.Text;
                bang.Rows.Add(dongthem);
                bo_doc_gi.Update(bang);
                MessageBox.Show("đăng ký thành công");
               
                
            }
            }
            catch (Exception loi)
            {

                MessageBox.Show(loi.Message); ;
            }
        }

       
    }
}
