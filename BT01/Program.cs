using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ban kinh:");
            double bankinh = double.Parse(Console.ReadLine());
            HinhTron A = new HinhTron(bankinh);
            Console.WriteLine("***Thong tin Hinh Tron");
            Console.WriteLine($"Hinh Tron A co ban kinh:{bankinh} Dien Tich:{A.TinhDienTich()} Chu Vi:{A.TinhChuVi()}");

            Console.Write("Nhap chieu cao:");
            double chieucao = double.Parse(Console.ReadLine());
            HinhTru B = new HinhTru(bankinh, chieucao);
            Console.WriteLine("***Thong tin Hinh Tru");
            Console.WriteLine($"Hinh Tru co ban kinh:{bankinh} Chieu cao:{chieucao} Dien tich:{B.TinhDienTich()} The Tich:{B.TinhTheTich()}");


            Console.ReadLine();

        }
    }
}
