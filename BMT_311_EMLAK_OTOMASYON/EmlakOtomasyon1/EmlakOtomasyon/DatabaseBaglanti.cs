using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace EmlakOtomasyon
{
    class DatabaseBaglanti
    {
        public DatabaseBaglanti()
        {
            OracleConnection connection = new OracleConnection("User Id=EMLAK_ADMIN;Password=157893;Data Source=localhost:1521/XEPDB1;");

        }



    }
}
