using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Threading.Tasks;

namespace baitapanhlong.baitap { }
//{
//    public partial class printthu : Form
//    {
//        public printthu()
//        {
//            InitializeComponent();
//        }
//        int t = 0;
//        private void button1_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                PrintDocument print1 = new PrintDocument();
//                print1.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
//                print1.PrintPage += new PrintPageEventHandler(this.pd);
//                print1.Print();
//            }
//            catch (Exception)
//            {
                
//                throw;
//            }
//        }
//        private void pd(object sender, PrintPageEventArgs ev)
//        {
//            //if (t < 2)
//            //{
//                ev.Graphics.DrawString(textBox1.Text.ToString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 20, 100);
//                //t++;
//                //if (t < 2)
//                //{
//                //    ev.HasMorePages = true;
//                //}
//                //else
//                //{
//                //    ev.HasMorePages = false;
//                //}
//            }
//        }
//    }
//}
