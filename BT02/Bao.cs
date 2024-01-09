using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Bao:TaiLieu
    {
        private int ngayphathanh;

        public Bao()
        {

        }
        public Bao(string matailieu, string tennhaxuatban, int sobanphathanh, int ngayphathanh) : base(matailieu, tennhaxuatban, sobanphathanh)
        {
            this.ngayphathanh = ngayphathanh;
        }
        public new void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ngay phat hanh:{ngayphathanh}");

        }
        public int Ngayphathanh
        {
            get { return ngayphathanh; }
            set { ngayphathanh = value; }
        }
    }
}
