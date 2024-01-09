using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class TaiLieu
    {
        private string matailieu;
        private string tennhaxuatban;
        private int sobanphathanh;

        public TaiLieu()
        {

        }
        public TaiLieu(string matailieu, string tennhaxuatban, int sobanphathanh)
        {
            this.matailieu = matailieu;
            this.tennhaxuatban = tennhaxuatban;
            this.sobanphathanh = sobanphathanh;
        }
        public void HienThiThongTin()
        {
            Console.WriteLine($"Ma tai lieu:{matailieu}");
            Console.WriteLine($"Ten nha xuat ban:{tennhaxuatban}");
            Console.WriteLine($"So ban phat hanh:{sobanphathanh}");


        }
        public string Matailieu
        {
            get { return matailieu; }
            set { matailieu = value; }
        }
        public string Tennhaxuatban
        {
            get { return tennhaxuatban; }
            set { tennhaxuatban = value; }
        }
        public int Sobanphathanh
        {
            get { return sobanphathanh; }
            set { sobanphathanh = value; }
        }
    }
}
