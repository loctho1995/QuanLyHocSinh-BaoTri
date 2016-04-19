using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BaoCao_BUS
    {
        public BaoCao_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        public DataTable InDanhSachlop(string magv, string malop, int phanquyen)
        {
            DataTable dt = new DataTable();
            //dt.Clear();

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));

            var hocsinh = SQLDataContext.SQLData.sp_BaoCaoLayDanhSachLop(magv, malop, phanquyen);
            int c = 1;

            foreach (var i in hocsinh)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAHS"] = i.MAHS;
                r["HOTEN"] = i.HOTEN;
                r["GIOITINH"] = i.GIOITINH;
                r["NGAYSINH"] = i.NGAYSINH;
                r["DIACHI"] = i.DIACHI;
                r["EMAIL"] = i.EMAIL;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public DataTable InBangDiemCuaLop(string magv, string malop, int phanquyen, int namhoc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("DIEMTBMONHKI");
            dt.Columns.Add("DIEMTBMONHKII");
            dt.Columns.Add("DIEMTBCANAM");

            var diem = SQLDataContext.SQLData.sp_BaoCaoLayBangDiemCuaLop(magv, malop, phanquyen, namhoc);
            int c = 1;

            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAHS"] = i.MAHS;
                r["HOTEN"] = i.HOTEN;
                r["DIEMTBMONHKI"] = i.DIEMTBHKI;
                r["DIEMTBMONHKII"] = i.DIEMTBHKII;
                r["DIEMTBCANAM"] = i.DIEMTBCANAM;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public DataTable InBangDiemChiTietTunghocKy(string magv, string malop, string mamon, int phanquyen, int namhoc, string hocky)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("D_MIENG_HKI", typeof(float));
            dt.Columns.Add("D_15P_HKI", typeof(float));
            dt.Columns.Add("D_1TIET_HKI", typeof(float));
            dt.Columns.Add("D_THI_HKI", typeof(float));
            dt.Columns.Add("D_TBMON_HKI", typeof(float));

            try
            {
                var diem = SQLDataContext.SQLData.sp_BaoCaoBangDiemChiTietTungHocKy(magv, malop, mamon, phanquyen, namhoc, hocky);
                int c = 1;
                foreach (var i in diem)
                {
                    DataRow r = dt.NewRow();

                    r["STT"] = c++;
                    r["MAHS"] = i.MAHS;
                    r["HOTEN"] = i.HOTEN;
                    r["D_MIENG_HKI"] = i.DIEMMIENG;
                    r["D_15P_HKI"] = i.DIEM15PHUT;
                    r["D_1TIET_HKI"] = i.DIEM1TIET;
                    r["D_THI_HKI"] = i.DIEMTHI;
                    r["D_TBMON_HKI"] = i.DIEMTBHOCKY;
                    dt.Rows.Add(r);
                }
                if (dt.Rows.Count == 0)
                    return null;
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable BaoCaoTongKetMon(string mamon, int phanquyen, string mahocki, int manamhoc)
        {
            int siso = 1, soluongdat = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("LOP", typeof(string));
            dt.Columns.Add("SISO", typeof(int));
            dt.Columns.Add("SOLUONGDAT", typeof(int));
            dt.Columns.Add("TILE");

            var diem = SQLDataContext.SQLData.sp_BaoCaoTongKetMon(mamon, phanquyen, mahocki, manamhoc);
            int c = 1;
            try
            {
                foreach (var i in diem)
                {
                    DataRow r = dt.NewRow();

                    r["STT"] = c++;
                    r["LOP"] = i.MALOP;
                    r["SISO"] = i.SISO;
                    r["SOLUONGDAT"] = i.SOLUONGDAT;
                    siso = int.Parse(i.SISO.ToString());
                    soluongdat = int.Parse(i.SOLUONGDAT.ToString());
                    r["TILE"] = ((float)soluongdat / siso * 100).ToString() + " %";
                    dt.Rows.Add(r);
                }
            }
            catch
            {

            }


            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public DataTable BaoCaoTongKetHocKy(int phanquyen, string mahocki, int manamhoc)
        {
            int siso = 1, soluongdat = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("LOP", typeof(string));
            dt.Columns.Add("SISO", typeof(int));
            dt.Columns.Add("SOLUONGDAT", typeof(int));
            dt.Columns.Add("TILE");

            var diem = SQLDataContext.SQLData.sp_BaoCaoTongKetHocKy(phanquyen, mahocki, manamhoc);
            int c = 1;
            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["LOP"] = i.MALOP;
                r["SISO"] = i.SISO;
                r["SOLUONGDAT"] = i.SOLUONGDAT;
                siso = int.Parse(i.SISO.ToString());
                soluongdat = int.Parse(i.SOLUONGDAT.ToString());
                r["TILE"] = ((float)soluongdat / siso * 100).ToString() + " %";
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
