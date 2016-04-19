using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Diem_BUS
    {
        public Diem_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        //Lay diem hoc sinh theo lop chu nhiem
        public DataTable LayDiemHocSinh_LopChuNhiem(string malop, int namhoc, string magvcn, int phanquyen)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("DIEMTBHKI", typeof(float));
            dt.Columns.Add("DIEMTBHKII", typeof(float));
            dt.Columns.Add("DIEMTBCANAM", typeof(float));
            dt.Columns.Add("MANAMHOC", typeof(int));

            var hocsinh = SQLDataContext.SQLData.sp_DiemHocSinhTheoLopChuNhiem(malop, namhoc, magvcn, phanquyen);
            int c = 1;

            foreach (var i in hocsinh)
            {
                try
                {
                    DataRow r = dt.NewRow();
                    r["STT"] = c++;

                    if(i.MAHS != null)
                        r["MAHS"] = i.MAHS;
                    if (i.HOTEN != null)
                        r["HOTEN"] = i.HOTEN;
                    if (i.DIEMTBHKI != null)
                        r["DIEMTBHKI"] = i.DIEMTBHKI;
                    if (i.DIEMTBHKII != null)
                        r["DIEMTBHKII"] = i.DIEMTBHKII;
                    if (i.DIEMTBCANAM != null)
                        r["DIEMTBCANAM"] = i.DIEMTBCANAM;
                    dt.Rows.Add(r);
                }
                catch
                {
                    
                }
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;

        }

        //Tim kiem thong tin diem hoc sinh theo lop chu nhiem
        public DataTable TimThongTinDiem_LopChuNhiem(string ten, int namhoc, string magvcn, int phanquyen)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("LOP", typeof(string));
            dt.Columns.Add("DIEMTBHKI", typeof(float));
            dt.Columns.Add("DIEMTBHKII", typeof(float));
            dt.Columns.Add("DIEMTBCANAM", typeof(float));
            dt.Columns.Add("MANAMHOC", typeof(int));

            var hocsinh = SQLDataContext.SQLData.sp_TimKiemThongTinDiemHocSinhTheoLopChuNhiem(ten, namhoc, magvcn, phanquyen);
            int c = 1;

            foreach (var i in hocsinh)
            {
                try
                {
                    DataRow r = dt.NewRow();
                    r["STT"] = c++;

                    if (i.MAHS != null)
                        r["MAHS"] = i.MAHS;
                    if (i.HOTEN != null)
                        r["HOTEN"] = i.HOTEN;
                    if (i.HOTEN != null)
                        r["LOP"] = i.MALOP;
                    if (i.DIEMTBHKI != null)
                        r["DIEMTBHKI"] = i.DIEMTBHKI;
                    if (i.DIEMTBHKII != null)
                        r["DIEMTBHKII"] = i.DIEMTBHKII;
                    if (i.DIEMTBCANAM != null)
                        r["DIEMTBCANAM"] = i.DIEMTBCANAM;
                    dt.Rows.Add(r);
                }
                catch
                {

                }
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;

        }

        //Lay diem hoc sinh theo khoi
        public DataTable LayDiemHocSinh_Khoi(string makhoi, int namhoc, string magvcn, int phanquyen)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("DIEMTBHKI", typeof(float));
            dt.Columns.Add("DIEMTBHKII", typeof(float));
            dt.Columns.Add("DIEMTBCANAM", typeof(float));
            dt.Columns.Add("MANAMHOC", typeof(int));

            var hocsinh = SQLDataContext.SQLData.sp_DiemHocSinhTheoKhoi(makhoi, namhoc, magvcn, phanquyen);
            int c = 1;

            foreach (var i in hocsinh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = c++;

                if (i.MAHS != null)
                    r["MAHS"] = i.MAHS;
                if (i.HOTEN != null)
                    r["HOTEN"] = i.HOTEN;
                if (i.DIEMTBHKI != null)
                    r["DIEMTBHKI"] = i.DIEMTBHKI;
                if (i.DIEMTBHKII != null)
                    r["DIEMTBHKII"] = i.DIEMTBHKII;
                if (i.DIEMTBCANAM != null)
                    r["DIEMTBCANAM"] = i.DIEMTBCANAM;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;

        }

        //lay diem 1 hoc sinh tren tat ca cac mon
        public DataTable LayDiemHocSinh_AllMon(int mahs, int namhoc, string hocky)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MON", typeof(string));
            dt.Columns.Add("DIEMMIENG", typeof(float));
            dt.Columns.Add("DIEM15P", typeof(float));
            dt.Columns.Add("DIEM1TIET", typeof(float));
            dt.Columns.Add("DIEMTHI", typeof(float));
            dt.Columns.Add("DIEMTBMON", typeof(float));

            var diem = SQLDataContext.SQLData.sp_DiemHocSinh(mahs, namhoc, hocky);

            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                if (i.TENMONHOC != null)
                    r["MON"] = i.TENMONHOC;
                if (i.DIEMMIENG != null)
                    r["DIEMMIENG"] = i.DIEMMIENG;
                if (i.DIEM15P != null)
                    r["DIEM15P"] = i.DIEM15P;
                if (i.DIEM1TIET != null)
                    r["DIEM1TIET"] = i.DIEM1TIET;
                if (i.DIEMTHI != null)
                    r["DIEMTHI"] = i.DIEMTHI;
                if (i.DIEMTBMON != null)
                    r["DIEMTBMON"] = i.DIEMTBMON;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //lay diem theo tung mon (lop)
        public DataTable LayDiemHocSinh_Mon(string malop, string mamon, int namhoc, string magv, int phanquyen)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("MAHS");
            dt.Columns.Add("HOTEN");
            dt.Columns.Add("DIEMTBMONHKI");
            dt.Columns.Add("DIEMTBMONHKII");

            var diem = SQLDataContext.SQLData.sp_DiemHocSinhTheoLopBoMon(malop, mamon, namhoc, magv, phanquyen);
            int c = 1;

            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;

                if (i.MAHS != null)
                    r["MAHS"] = i.MAHS;
                if (i.HOTEN != null)
                    r["HOTEN"] = i.HOTEN;
                if (i.DIEMTBMONHKI != null)
                    r["DIEMTBMONHKI"] = i.DIEMTBMONHKI;
                if (i.DIEMTBMONHKII != null)
                    r["DIEMTBMONHKII"] = i.DIEMTBMONHKII;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //Tim kiem thong tin diem hoc sinh theo lop bo mon
        public DataTable TimThongTinDiemHocSinh_Mon(string ten, string mamon, int namhoc, string magv, int phanquyen)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("MAHS");
            dt.Columns.Add("HOTEN");
            dt.Columns.Add("LOP");
            dt.Columns.Add("DIEMTBMONHKI");
            dt.Columns.Add("DIEMTBMONHKII");

            var diem = SQLDataContext.SQLData.sp_TimKiemThongTinDiemHocSinhTheoLopBoMon(ten, mamon, namhoc, magv, phanquyen);
            int c = 1;

            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;

                if (i.MAHS != null)
                    r["MAHS"] = i.MAHS;
                if (i.HOTEN != null)
                    r["HOTEN"] = i.HOTEN;
                if (i.HOTEN != null)
                    r["LOP"] = i.MALOP;
                if (i.DIEMTBMONHKI != null)
                    r["DIEMTBMONHKI"] = i.DIEMTBMONHKI;
                if (i.DIEMTBMONHKII != null)
                    r["DIEMTBMONHKII"] = i.DIEMTBMONHKII;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //lay diem theo tung mon (khoi)
        public DataTable LayDiemHocSinh_Mon_Khoi(string makhoi, string mamon, int namhoc, string magv, int phanquyen)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("MAHS");
            dt.Columns.Add("HOTEN");
            dt.Columns.Add("DIEMTBMONHKI");
            dt.Columns.Add("DIEMTBMONHKII");

            var diem = SQLDataContext.SQLData.sp_DiemHocSinhTheoKhoi_LopBoMon(makhoi, mamon, namhoc, magv, phanquyen);
            int c = 1;

            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;

                if (i.MAHS != null)
                    r["MAHS"] = i.MAHS;
                if (i.HOTEN != null)
                    r["HOTEN"] = i.HOTEN;
                if (i.DIEMTBMONHKI != null)
                    r["DIEMTBMONHKI"] = i.DIEMTBMONHKI;
                if (i.DIEMTBMONHKII != null)
                    r["DIEMTBMONHKII"] = i.DIEMTBMONHKII;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //Lay diem 1 hoc sinh theo mon
        public DataTable LayDiem1HocSinh_Mon(int mahs, string mamon, int namhoc, string magv, int phanquyen)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("D_MIENG_HKI", typeof(float));
            dt.Columns.Add("D_15P_HKI", typeof(float));
            dt.Columns.Add("D_1TIET_HKI", typeof(float));
            dt.Columns.Add("D_THI_HKI", typeof(float));
            dt.Columns.Add("D_TBMON_HKI", typeof(float));
            dt.Columns.Add("D_MIENG_HKII", typeof(float));
            dt.Columns.Add("D_15P_HKII", typeof(float));
            dt.Columns.Add("D_1TIET_HKII", typeof(float));
            dt.Columns.Add("D_THI_HKII", typeof(float));
            dt.Columns.Add("D_TBMON_HKII", typeof(float));

            var diem = SQLDataContext.SQLData.sp_Diem1HocSinhTheoBoMon(mahs, mamon, namhoc, magv, phanquyen);
            //var diem = DB.sp_Diem1HocSinhTheoBoMon("1", "MH0001", "2014", "gv001", 0);
            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                if (i.D_MIENGHKI != null)
                r["D_MIENG_HKI"] = i.D_MIENGHKI;
                if (i.D_15PHKI != null)
                r["D_15P_HKI"] = i.D_15PHKI;
                if (i.D_1TIETHKI != null)
                r["D_1TIET_HKI"] = i.D_1TIETHKI;
                if (i.D_THIHKI != null)
                r["D_THI_HKI"] = i.D_THIHKI;
                if (i.D_TBMONHKI != null)
                r["D_TBMON_HKI"] = i.D_TBMONHKI;

                if (i.D_MIENGHKII != null)
                r["D_MIENG_HKII"] = i.D_MIENGHKII;
                if (i.D_15PHKII != null)
                r["D_15P_HKII"] = i.D_15PHKII;
                if (i.D_1TIETHKII != null)
                r["D_1TIET_HKII"] = i.D_1TIETHKII;
                if (i.D_THIHKII != null)
                r["D_THI_HKII"] = i.D_THIHKII;
                if (i.D_TBMONHKII != null)
                r["D_TBMON_HKII"] = i.D_TBMONHKII;


                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public bool SuaDiem(int mahs, string malop, string mamon, int namhoc, float d_mieng_hkI, float d_15p_hkI, float d_1tiet_hkI, float d_thi_hkI, float d_mieng_hkII, float d_15p_hkII, float d_1tiet_hkII, float d_thi_hkII)
        {
            try
            {
                SQLDataContext.SQLData.sp_SuaDiem(mahs, malop, mamon, namhoc, d_mieng_hkI, d_15p_hkI, d_1tiet_hkI, d_thi_hkI, d_mieng_hkII, d_15p_hkII, d_1tiet_hkII, d_thi_hkII);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
