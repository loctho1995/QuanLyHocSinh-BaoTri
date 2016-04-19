using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MonHoc_BUS
    {
        public MonHoc_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        public List<MONHOC> LayMonHoc()
        {
            return SQLDataContext.SQLData.MONHOCs.ToList();
        }

        public List<MONHOC> LayDuLieuMonHoc()
        {
            return SQLDataContext.SQLData.MONHOCs.ToList();
        }
    }
}
