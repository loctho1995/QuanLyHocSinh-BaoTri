using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class GiaoVien_BUS
    {
        public GiaoVien_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        public void LayGVBoMon(ref string[] malop, string id)
        {
            int m_count = 0;
            string[] malopbomon = new string[10];
            try
            {
                var malopgvbomon = SQLDataContext.SQLData.sp_LayGVBoMon(id);
                foreach (var i in malopgvbomon)
                    malopbomon[m_count++] = i.MALOP;
                malop = new string[m_count];
                for (int i = 0; i <= m_count; i++)
                    malop[i] = malopbomon[i];
                if (m_count == 0)
                    malopbomon = null;
            }
            catch
            {
                return;
            }
        }

        public DataTable LoadDuLieuGiaoVien()
        {
            DataTable dt = new DataTable();
            //dt.Clear();

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAGV", typeof(string));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("SODT", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("PASSWORD", typeof(string));
            dt.Columns.Add("PHANQUYEN", typeof(string));

            var giaovien = SQLDataContext.SQLData.sp_LoadDuLieuGV();
            int c = 1;

            foreach (var i in giaovien)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAGV"] = i.magv;
                r["HOTEN"] = i.hoten;
                r["GIOITINH"] = i.gioitinh;
                r["NGAYSINH"] = i.ngaysinh;
                r["SODT"] = i.sodt;
                r["EMAIL"] = i.email;
                r["PASSWORD"] = i.password;
                r["PHANQUYEN"] = i.phanquyen;
                dt.Rows.Add(r);
            }

            return dt;
        }
        public bool InsertDuLieuGV(GIAOVIEN giaovien, USER user, int type)
        {
            try
            {
                SQLDataContext.SQLData.sp_InsertDuLieuGV(giaovien.MAGV, giaovien.HOTEN, giaovien.NGAYSINH, giaovien.GIOITINH, giaovien.SODT, user.PASSWORD, user.EMAIL, user.PHANQUYEN, type);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteDuLieuGV(string magv)
        {
            try
            {
                SQLDataContext.SQLData.sp_DeleteDuLieuGv(magv);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateDuLieuGV(GIAOVIEN giaovien, USER user)
        {
            try
            {
                SQLDataContext.SQLData.sp_UpdateDuLieuGV(giaovien.MAGV, giaovien.HOTEN, giaovien.NGAYSINH, giaovien.GIOITINH, giaovien.SODT, user.PASSWORD, user.EMAIL, user.PHANQUYEN);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
