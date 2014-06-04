using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace baitapanhlong.C_
{
    class student
    {
        private string name;
        public string mName
        {
            get {return "sinh viên "+this.name; }
            set { name = value; }
        }
        private int tuoi;
        public string mTuoi
        {
            get { return tuoi.ToString()+" Tuổi"; }
            set { tuoi = int.Parse(value); }
        }
        private string khoa;
        public string mkhoa
        {
            get { return "khoa " + khoa; }
            set { khoa = value;}
        }
        private string truong;
        public string mtruong
        {
            get { return "trường " + truong; }
            set { truong = value; }
        }
        private int mssv;
        public string mmssv
        {
            get { return "MSSV " + mssv.ToString(); }
            set { mssv =int.Parse( value); }
        }
           

       

    }
}
