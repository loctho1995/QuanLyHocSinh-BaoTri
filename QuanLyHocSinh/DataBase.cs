using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using BUS;

namespace QuanLyHocSinh
{
    public class DataBase
    {
        public static BaoCao_BUS BaoCao
        { get; set; }

        public static Diem_BUS Diem
        { get; set; }

        public static GiaoVien_BUS GiaoVien
        { get; set; }

        public static HocKy_BUS HocKy
        { get; set; }

        public static HocSinh_BUS HocSinh
        { get; set; }

        public static Lop_BUS Lop
        { get; set; }

        public static MonHoc_BUS MonHoc
        { get; set; }

        public static NamHoc_BUS NamHoc
        { get; set; }

        public static User_BUS User
        { get; set; }

        public static bool IsLoaded
        { get; set; }

        public static CAIDAT CaiDat
        { get; set; }

        public static CaiDat_BUS CaiDatBus
        { get; set; }

        public static Data_BUS Data
        { get; set; }

        public static void InitDataBase()
        {
            BUS.SQLDataContext.CreateDataContext();

            BaoCao = new BaoCao_BUS();
            Diem = new Diem_BUS();
            GiaoVien = new GiaoVien_BUS();
            HocKy = new HocKy_BUS();
            HocSinh = new HocSinh_BUS();
            Lop = new Lop_BUS();
            MonHoc = new MonHoc_BUS();
            NamHoc = new NamHoc_BUS();
            User = new User_BUS();
            CaiDatBus = new CaiDat_BUS();
            Data = new Data_BUS();
            CaiDat = CaiDatBus.LoadDuLieuCaiDat();

            IsLoaded = true;
        }
    }
}
