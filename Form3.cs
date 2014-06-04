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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
            student sv = new student();
            sv.mName = txthoten.Text;
            sv.mTuoi = txttuoi.Text;
            sv.mkhoa = txtkhoa.Text;
            sv.mtruong = txttruong.Text;
            sv.mmssv = txtmasosv.Text;
            MessageBox.Show(sv.mName + "\r\n" + sv.mTuoi + "\r\n" + sv.mtruong + "\r\n" + sv.mkhoa + "\r\n" + sv.mmssv);
            }
            catch (Exception loi)
            {
                
                MessageBox.Show(loi.Message);
            }
        }
    }
}
