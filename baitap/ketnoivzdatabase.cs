using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using baitapanhlong.C_;

namespace baitapanhlong.baitap
{
    public partial class ketnoivzdatabase : Form
    {
        public ketnoivzdatabase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chuoi_ket_noi = string.Format(@"Server={0};Database={1};user={2};password={3}", txtserver.Text, txtdatabase.Text, txtuser.Text, txtpass.Text);
            SqlConnection ketnoi = new SqlConnection(chuoi_ket_noi);
            ketnoi.Open();
            if (ketnoi.State == ConnectionState.Open)
            {
                MessageBox.Show("kết nối ok");
            }
            else
            {
                MessageBox.Show("ket noi that bai");
            }
        }
    }
}
