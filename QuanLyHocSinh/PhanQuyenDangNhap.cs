using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    public class PhanQuyenDangNhap
    {
        private string id;
        public string ID
        {
            get{return id;}
            set{id = value;}
        }

        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string lopcn;
        public string LopCN
        {
            get { return lopcn; }
            set { lopcn = value; }
        }

        private string[] lopbomon;
        public string[] LopBM
        {
            get { return lopbomon; }
            set { lopbomon = value; }
        }

        private int phanquyen;
        public int PhanQuyen
        {
            get { return phanquyen; }
            set { phanquyen = value; }
        }
    }
}
