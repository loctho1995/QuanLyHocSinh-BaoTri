using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NamHoc_BUS
    {
        public NamHoc_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        public List<NAMHOC> LayNamHoc()
        {
            return SQLDataContext.SQLData.NAMHOCs.ToList();
        }
    }
}
