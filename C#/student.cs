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
        public string Name
        {
            get {return "sinh viên "+this.name; }
            set { name = value; }
        }

        private string password;
        public string PASSWORD
        {
            get { return password; }
            set 
            {
                HashAlgorithm hassword = new MD5CryptoServiceProvider();
                byte[] hassbyte = hassword.ComputeHash(Encoding.UTF8.GetBytes(value));
                password = Convert.ToBase64String(hassbyte);
            }
        }

    }
}
