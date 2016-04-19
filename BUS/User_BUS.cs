using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class User_BUS
    {
        public User_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        //phân quyền đăng nhập
        public int DangNhap(string user, string pass, ref string name, ref string malop, ref int phanquyen)
        {
            int? m_check = 0, m_temp = 0;
            try
            {
                SQLDataContext.SQLData.sp_DangNhap(user, pass, ref m_check, ref name, ref malop, ref m_temp);
                phanquyen = int.Parse(m_temp.ToString());
                return int.Parse(m_check.ToString());
            }
            catch
            {
                return int.Parse(m_check.ToString());
            }
        }
    }
}
