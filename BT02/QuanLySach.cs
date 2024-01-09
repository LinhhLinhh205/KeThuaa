using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class QuanLySach
    {
        private TaiLieu[] quanly;
        private int n;


        public QuanLySach()
        {
            quanly=new TaiLieu[100];
            n = 0;
        }
        public QuanLySach(int sophantu)
        {
            quanly = new TaiLieu[sophantu];
            n = 0;
        }
        public void ThemMoiTaiLieu(TaiLieu tailieu)
        {
            if (n < quanly.Length)
            {
                quanly[n++] = tailieu;
            }
            else
                Console.WriteLine("Danh sach da day");
        }
        public void XoaTaiLieu(string matailieu)
        {
            for(int i = 0; i < n; i++)
            {
                if (quanly[i].Matailieu == matailieu)
                {
                    for(int j = i; j < n - 1; j++)
                    {
                        quanly[j] = quanly[j + 1];

                    }
                    quanly[--n] = null;
                    Console.WriteLine($"Da xoa tai lieu co ma tai lieu{matailieu}");
                    return;
                }
            }
        }
        public void HienThiTHongTinTaiLieu(string mataiLieu)
        {
            for(int i = 0; i < n; i++)
            {
                if (quanly[i].Matailieu == mataiLieu)
                {
                    quanly[i].HienThiThongTin();
                }
            }
        }
        public void TimKiemTheoLoai<T>() where T : TaiLieu
        {
            for(int i = 0; i < n; i++)
            {
                if(quanly[i] is T)
                {
                    quanly[i].HienThiThongTin();
                }
            }
        }
    }
}
