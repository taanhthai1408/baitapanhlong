using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using baitapanhlong.C_;

namespace baitapanhlong
{
    public partial class thuchanhkn : Form
    {
        public thuchanhkn()
        {
            InitializeComponent();
        }

        private void thuchanhkn_Load(object sender, EventArgs e)
        {
            
             ketnoianhlong ketnoisql = new ketnoianhlong();
            MessageBox.Show(ketnoisql.trangthai+"____"+ketnoisql.bat_loi);
            
        }
    }
}
