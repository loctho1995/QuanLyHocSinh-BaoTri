using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HocKy_BUS
    {
        public HocKy_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        public List<HOCKY> LayHocky()
        {
            return SQLDataContext.SQLData.HOCKies.ToList();
        }

        public List<HOCKY> LayDuLieuHocKy()
        {
            return SQLDataContext.SQLData.HOCKies.ToList();
        }
    }
}
