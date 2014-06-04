using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace baitapanhlong.C_
{
    class ket_noi
    {
        public static string  chuoi_ket_noi = @"Data Source=.\SQLEXPRESS;Initial Catalog=dang_nhap;Integrated Security=True";
        public static SqlConnection tao_ket_noi()
        {
            SqlConnection kn = new SqlConnection(chuoi_ket_noi);
            return kn;
        }
        public static string chuoi_kn = @"Data Source=.\SQLEXPRESS;Initial Catalog=quantractai;Integrated Security=True";
        public static SqlConnection tao_ket_noi1()
        {
            SqlConnection kn1 = new SqlConnection(chuoi_kn);
            kn1.Open();
            return kn1;
        }
        public static Form2 moform()
        {
            Form2 mf = new Form2();
            mf.Show();
            return mf;
        }
        public static Form2 dongform()
        {
            Form2 df = new Form2();
            df.Close();
            return df;
        }

    }
}
