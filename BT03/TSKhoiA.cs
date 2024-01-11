using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03
{
    class TSKhoiA:ThiSinh
    {
        public string[] MonThi { get; set; }
        public TSKhoiA()
        {
            MonThi = new string[] { "Toan", "Ly", "Hoa" };
        }
        public new void NhapThongTin()
        {
            base.NhapThongTin();
        }
        public new void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Khoi A. Mon thi:{string.Join(",",MonThi)}");
        }
    }
    class TSKhoiB : ThiSinh
    {
        public string [] MonThi { get; set; }
        public TSKhoiB()
        {
            MonThi = new string[] { "Toan", "Hoa", "Sinh" };
        }
        public new void NhapThongTin()
        {
            base.NhapThongTin();
        }
        public new void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Khoi B. Mon thi:{string.Join(",", MonThi)}");
        }

    }
    class TSKhoiC : ThiSinh
    {
        public string[] MonThi { get; set; }
        public TSKhoiC()
        {
            MonThi = new string[] { "Van", "Su", "Dia" };
        }
        public new void NhapThongTin()
        {
            base.NhapThongTin();
        }
        public new void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Khoi C. Mon thi:{string.Join(",", MonThi)}");
        }
    }

}
