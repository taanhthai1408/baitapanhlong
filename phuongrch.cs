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
    public partial class phuongrch : Form
    {
        public phuongrch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection ketnoi = ket_noi.tao_ket_noi1();
            string lenh = string.Format("exec phuongech '{0}','{1}'",textBox1.Text,textBox2.Text);
            SqlCommand bolenh = new SqlCommand(lenh, ketnoi);
            SqlDataReader bo_doc = bolenh.ExecuteReader();
            StringBuilder kq = new StringBuilder();
            if (bo_doc.HasRows)
            {
                while (bo_doc.Read())
                {
                    for (int i = 0; i < bo_doc.FieldCount; i++)
                    {
                        kq.Append(bo_doc[i].ToString() + (i == bo_doc.FieldCount - 1 ? "" : ":"));
                    }
                    kq.AppendLine();
                }
                textBox3.Text = kq.ToString();
            }
        }
    }
}
