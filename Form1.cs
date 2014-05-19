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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            student sv = new student();
            sv.PASSWORD = "ta anh thai";
            MessageBox.Show(sv.PASSWORD);
        }
    }
}
