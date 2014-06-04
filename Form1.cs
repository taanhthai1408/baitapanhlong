using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using baitapanhlong.C_;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace baitapanhlong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //student sv = new student();
            //sv.PASSWORD = "ta anh thai";
            //MessageBox.Show(sv.PASSWORD);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            ket_noi.moform();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string password;
            HashAlgorithm hassword = new MD5CryptoServiceProvider();
            byte[] hassbyte = hassword.ComputeHash(Encoding.UTF8.GetBytes(txtmk.Text));
            password = Convert.ToBase64String(hassbyte);
            SqlConnection ketnoiform = ket_noi.tao_ket_noi();
            string lenh_sql = "Select * From dangkitk";
            SqlDataAdapter bo_docgi = new SqlDataAdapter(lenh_sql, ketnoiform);
            DataTable bang = new DataTable();
            bo_docgi.FillSchema(bang, SchemaType.Source);
            bo_docgi.Fill(bang);
            DataRow kqtim = bang.Rows.Find(txttendangnhap.Text);
            if (kqtim == null)
            {
                MessageBox.Show("tên đăng nhâp của bạn không đúng");
                
            }
            else
            {
                string idnhap = txttendangnhap.Text.Trim();
                string mknhap = password.ToString();
                string id = kqtim[0].ToString();
                string pass = kqtim[1].ToString();
                if (idnhap == id && mknhap == pass)
                {
                    formchinh mofc = new formchinh();
                    mofc.Show();
                }
                else
                {
                    MessageBox.Show("mật khẩu bạn bị sai");
                }
            }
        }

        private void txttendangnhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
