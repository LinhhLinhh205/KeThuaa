using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03
{
    class TuyenSinh
    {
        private ThiSinh[] thisinh;
        private int n;


        public TuyenSinh()
        {
            thisinh = new ThiSinh[100];
            n = 0;
        }
        public TuyenSinh(int sophantu)
        {
            thisinh = new ThiSinh[sophantu];
            n = 0;
        }
        public void ThemMoiThiSinh(ThiSinh them)
        {
            if (n < thisinh.Length)
            {
                thisinh[n++] = them;
            }
            else
                Console.WriteLine("Danh sach da day");
        }
    }
}
