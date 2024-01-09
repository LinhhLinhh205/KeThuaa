using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Sach:TaiLieu
    {
        private string tentacgia;
        private int sotrang;
        public Sach()
        {

        }
        public Sach(string matailieu, string tennhaxuatban, int sobanphathanh, string tentacgia, int sotrang) : base(matailieu, tennhaxuatban, sobanphathanh)
        {
            this.tentacgia = tentacgia;
            this.sotrang = sotrang;
        }
        public new void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ten tac gia:{tentacgia}");
            Console.WriteLine($"So trang:{sotrang}");
        }
        public string Tentacgia
        {
            get { return tentacgia; }
            set { tentacgia = value; }
        }
        public int Sotrang
        {
            get { return sotrang; }
            set { sotrang = value; }
        }

    }
}
