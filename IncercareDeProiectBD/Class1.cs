using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace IncercareDeProiectBD
{
    class Class1
    {
        public static OracleConnection GetDBConnection()
        {
            string host = "193.226.51.37";
            int port = 1521;
            string sid = "o11g";
            string user = "adriangeorgeleventiu";
            string password = "adriangeorge#21";

            return Class2.GetDBConnection(host, port, sid, user, password);
        }
    }
}
