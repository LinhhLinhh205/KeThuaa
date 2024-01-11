using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03
{
    class Program
    {
        static void Main(string[] args)
        {
            TuyenSinh tuyensinh = new TuyenSinh();
            int chon;
            do
            {
                Console.WriteLine("Tuyen Sinh");
                Console.WriteLine("1. Them moi thi sinh");
                Console.WriteLine("2. Hien thi danh sach thi sinh");
                Console.WriteLine("3. Thoat");
                Console.Write("Ban chon:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Chon khoi thi");
                        Console.WriteLine("(A/B/C)");

                        char khoithi =char.Parse( Console.ReadLine());

                        ThiSinh thisinh;
                        switch(khoithi)
                        {
                            case 'A':
                                thisinh=new TSKhoiA();
                                break
                            case'B':
                                thisinh =new TSKhoiB();
                                break;
                            case'C':
                                thisinh=new TSKhoiC();
                                break;

                        }
                        thisinh.NhapThongTin();
                        tuyensinh.ThemMoiThiSinh(thisinh);
                        break;
                    case 2:
                        Console.WriteLine("Danh sach thisinh");
                        tuyensinh.HienThiDS();
                        break;
                    case 3:
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                }
            }while(chon!=0);

        }
    }
}
