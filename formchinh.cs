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
    public partial class formchinh : Form
    {
        public formchinh()
        {
            InitializeComponent();
        }

        private void formchinh_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = Application.StartupPath + "//baithi.swf";
            SqlConnection ketnoi = ket_noi.tao_ket_noi1();
            string lenh_sql = "select distinct NgayDo from ThongTinQT;select distinct YEAR(NgayDo) as nam from ThongTinQT";
            SqlDataAdapter bo_doc_gi = new SqlDataAdapter(lenh_sql, ketnoi);
            DataSet du_lieu = new DataSet();
            bo_doc_gi.Fill(du_lieu);
            comboBoxEx1.DataSource = du_lieu.Tables[0];
            comboBoxEx1.DisplayMember = "NgayDo";
            comboBoxEx3.DataSource = du_lieu.Tables[1];
            comboBoxEx3.DisplayMember = "nam";
        }
        SqlDataAdapter bo_doc_gi;
        DataTable bang;

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngay = DateTime.Parse(comboBoxEx1.Text);
                SqlConnection ketnoi = ket_noi.tao_ket_noi1();
                string lenh_sql = string.Format("select TenTQT from ThongTinQT,QuanTrac,TQT where ThongTinQT.MaTTQT=QuanTrac.MaTTQT and QuanTrac.MaTQT=TQT.MaTQT and NgayDo='{0}'", comboBoxEx1.Text);
                SqlCommand bo_lenh = new SqlCommand(lenh_sql, ketnoi);
                SqlDataReader bo_doc = bo_lenh.ExecuteReader();
                StringBuilder kq = new StringBuilder();
                if (bo_doc.HasRows)
                {
                    while (bo_doc.Read())
                    {
                        for (int i = 0; i < bo_doc.FieldCount; i++)
                        {
                            kq.Append(bo_doc[i] + (i == bo_doc.FieldCount - 1 ? "" : ":"));
                        }
                        kq.AppendLine();
                    }
                    textBoxX2.Text = "Những trạm quan trắc trong ngày " + comboBoxEx1.Text + "\r\n" + kq.ToString();
                }
                else
                {
                    textBoxX2.Text = "không có trạm quan trắc nào quan trắc trong ngày " + comboBoxEx1.Text;
                }
            }
            catch (Exception loi)
            {
                textBoxX2.Text = "";
                MessageBox.Show("bạn nhập ngày sai");
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            int nam = int.Parse(comboBoxEx3.Text.Trim());
            int nho = int.Parse(textBoxX1.Text);
            int lon = int.Parse(textBoxX3.Text.Trim());
            SqlConnection ketnoi = ket_noi.tao_ket_noi1();
            string lenh = string.Format("exec bai112 {0},{1},{2}", nam, lon, nho);
            SqlCommand bo_lenh = new SqlCommand(lenh, ketnoi);
            SqlDataReader bo_doc = bo_lenh.ExecuteReader();
            StringBuilder kq = new StringBuilder();
            if (bo_doc.HasRows)
            {
                while (bo_doc.Read())
                {
                    for (int i = 0; i < bo_doc.FieldCount; i++)
                    {
                        if ((int)bo_doc[1] < 10)
                        {
                            kq.Append((i == 0 ? "trạm  " : "") + bo_doc[i].ToString() + (i == bo_doc.FieldCount - 1 ? "" : " có số lần quan trắc là: ") + (i == bo_doc.FieldCount - 1 ? " ( trạm quan trắc it)" : ""));
                        }
                        if ((int)bo_doc[1] > 10 && (int)bo_doc[1] < 50)
                        {
                            kq.Append((i == 0 ? "trạm  " : "") + bo_doc[i].ToString() + (i == bo_doc.FieldCount - 1 ? "" : " có số lần quan trắc là: ") + (i == bo_doc.FieldCount - 1 ? "(trạm quan trắc trung bình)" : ""));
                        }
                        if ((int)bo_doc[1] > 50)
                        {
                            kq.Append((i == 0 ? "trạm  " : "") + bo_doc[i].ToString() + (i == bo_doc.FieldCount - 1 ? "" : " có số lần quan trắc là: ") + (i == bo_doc.FieldCount - 1 ? "(trạm quan trắc nhiều)" : ""));
                        }
                    }
                    kq.AppendLine();
                }
                txtkq.Text = kq.ToString();
            }
            else
            {
                txtkq.Text = "không tìm được trạm quan trắc quan trắc trong năm " + comboBoxEx3.Text + " và có số lần quan trắc từ " + textBoxX1.Text + " đến " + textBoxX3.Text;
            }
        }

        
    }
}
