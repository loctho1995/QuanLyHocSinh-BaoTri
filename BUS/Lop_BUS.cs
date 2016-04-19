using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Lop_BUS
    {
        public Lop_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        public List<LOP> LayDuLieuLop(string magvcn, int phanquyen)
        {
            List<LOP> l = new List<LOP>();
            if (phanquyen == 0)
            {
                try
                {
                        string b = SQLDataContext.SQLData.LOPs.Where(a => a.MAGVCN == magvcn).FirstOrDefault().MAGVCN.ToString();
                        return SQLDataContext.SQLData.LOPs.Where(a => a.MAGVCN == magvcn).ToList();
                }
                catch
                {
                    return null;
                }
            }
            else return SQLDataContext.SQLData.LOPs.ToList();
        }


    }
}
