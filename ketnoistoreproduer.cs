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

namespace baitapanhlong
{
    public partial class ketnoistoreproduer : Form
    {
        public ketnoistoreproduer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection ketnoi= ket_noi.tao_ket_noi1();
          
           string lenh = "chonngay";
           SqlCommand bo_lenh = new SqlCommand(lenh, ketnoi);
           bo_lenh.CommandType = CommandType.StoredProcedure;

           SqlParameter ngay = new SqlParameter();
           ngay.ParameterName = "@ngay";
           ngay.SqlDbType = SqlDbType.Date;
           ngay.Value = DateTime.Parse(textBox1.Text);
           bo_lenh.Parameters.Add(ngay);
           SqlDataReader bo_doc = bo_lenh.ExecuteReader();
           DataTable bang = new DataTable();
           bang.Load(bo_doc);
           dataGridView1.DataSource = bang;
        }
    }
}
