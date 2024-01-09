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
    }
    class TSKhoiB : ThiSinh
    {
        public string [] MonThi { get; set; }
        public TSKhoiB()
        {
            MonThi = new string[] { "Toan", "Hoa", "Sinh" };
        }
    }
    class TSKhoiC : ThiSinh
    {
        public string[] MonThi { get; set; }
        public TSKhoiC()
        {
            MonThi = new string[] { "Van", "Su", "Dia" };
        }
    }

}
