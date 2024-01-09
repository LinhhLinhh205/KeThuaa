using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    class HinhTru:HinhTron
    {
        private double chieucao;
        public HinhTru() : base()
        {
            chieucao = 1.0;
        }
        public HinhTru(double bankinh, double chieucao) : base(bankinh)
        {
            this.chieucao = chieucao;
        }
        public double Chieucao
        {
            get { return chieucao; }
            set { chieucao = Math.Abs(chieucao); }
        }
        public double TinhDienTich()
        {
            return 2 * base.TinhDienTich() + TinhChuVi() * chieucao;
        }
        public new double TinhTheTich()
        {
            return base.TinhDienTich() * chieucao;
        }
    }
}
