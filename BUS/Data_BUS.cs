using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Threading.Tasks;

namespace BUS
{
    public class Data_BUS
    {
        private Connection conn;
        public Data_BUS()
        {
            conn = new Connection();
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        public bool BackupData(string path)
        {
            try
            {
                SQLDataContext.SQLData.sp_BackupData(path);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool RestoreData(string path)
        {
            string query = "USE master EXEC sp_Restore "+"'"+path+"'";
            return conn.ExecQuery(query);
        }
    }
}
