using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    class HinhTron
    {
        private double bankinh;
        public HinhTron()
        {
            bankinh = 1.0;
        }
        public HinhTron(double bankinh)
        {
            this.bankinh = bankinh;
        }
        public double BanKinh
        {
            get { return bankinh; }
            set { bankinh = Math.Abs(bankinh); }
        }
        public double TinhDienTich()
        {
            return bankinh * bankinh * Math.PI;
        }
        public double TinhChuVi()
        {
            return 2 * bankinh * Math.PI;
        }
    }
}
