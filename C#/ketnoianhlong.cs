using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace baitapanhlong.C_
{
    class ketnoianhlong
    {
        private string _user;
        private string _pssword;
        private string _serverurl;
        private string _database;
        private string _connectionstring;
        public string trangthai
        {
            get;
            private set;
        }
        public string bat_loi
        {
            get;
            set;
        }

       public ketnoianhlong()
        {
            try
            {
                this._user=ConfigurationManager.AppSettings.Get("user");
           this._pssword=ConfigurationManager.AppSettings.Get("password");
           this._serverurl=ConfigurationManager.AppSettings.Get("serverurl");
           this._database=ConfigurationManager.AppSettings.Get("database");
           this._connectionstring = "user id=" + this._user + ";" +
                                  "password=" + this._pssword + ";" +
                                  "server=" + this._serverurl + ";" +
                                  "Trusted_Connection=no;" +
                                  "database=" + this._database + ";" +
                                  "connection timeout=10;";
           SqlConnection ket_noi = new SqlConnection(this._connectionstring);
           ket_noi.Open();
           this.trangthai = ket_noi.State.ToString();
            }
            catch (Exception e)
            {
                
                this.bat_loi=e.ToString();
            }
        }
    }
}
