using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class CaiDat_BUS
    {
        public CaiDat_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }
        public CAIDAT LoadDuLieuCaiDat()
        {
            return SQLDataContext.SQLData.CAIDATs.ToList().FirstOrDefault();
        }
        public bool insertDuLieuCatDat(CAIDAT caidat)
        {
            try
            {
                SQLDataContext.SQLData.sp_InsertDuLieuCaiDat(caidat.MAIN_BACKCOLOR, caidat.TOPBUTTONCOLOR, caidat.TABBUTTONCOLOR, caidat.SEACHCONTROL_BACKGOUND, caidat.TABPANEL_COLOR);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
