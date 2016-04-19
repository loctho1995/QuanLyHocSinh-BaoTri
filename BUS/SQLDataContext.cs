using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SQLDataContext
    {
        static SQL_QUANLYHOCSINHDataContext m_db;
        public static SQL_QUANLYHOCSINHDataContext SQLData
        {
            get { return m_db; }
            set { m_db = value; }
        }

        public static bool IsLoaded
        { get; set; }

        public static void CreateDataContext(string connectionString)
        {
            m_db = new SQL_QUANLYHOCSINHDataContext(connectionString);
            IsLoaded = true;
        }

        public static void CreateDataContext()
        {
            m_db = new SQL_QUANLYHOCSINHDataContext();
            IsLoaded = true;
        }
    }
}
