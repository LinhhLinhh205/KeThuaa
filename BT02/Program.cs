using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLySach quanlysach = new QuanLySach();
            int chon;
            do
            {
                Console.WriteLine("***QUANLYSACH***");
                Console.WriteLine("1. Them moi ai lieu");
                Console.WriteLine("2. Xoa tai lieu theo ma tai lieu");
                Console.WriteLine("3. Hien thi thong tin ve tai lieu");
                Console.WriteLine("4. Tim kiem tai lieu");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("-----------");
                Console.Write("Ban chon:");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        ThemMoiTaiLieu(quanlysach);
                        break;
                    case 2:
                        XoaTaiLieu(quanlysach);
                        break;
                    case 3:
                        HienThiTHongTinTaiLieu(quanlysach);
                        break;
                    case 4:
                        TimKiemTheoLoai(quanlysach);
                        break;
                    case 5:
                        Console.WriteLine("Da thoat chuong trinh");
                        break;
                }
            } while (chon != 0);
        }
        static void ThemMoiTaiLieu(QuanLySach quanlysach)
        {
            int loai;
            do
            {


                Console.WriteLine("---THEM MOI TAI LIEU---");
                Console.WriteLine("Nhap loai tai lieu");
                Console.WriteLine("1. Sach");
                Console.WriteLine("2. Tap chi");
                Console.WriteLine("3. Bao");
                Console.Write("Ban chon loai nao");
                loai = int.Parse(Console.ReadLine());

                switch (loai)
                {
                    case 1:
                        ThemMoiSach(quanlysach);
                        break;
                    case 2:
                        ThemMoiTapChi(quanlysach);
                        break;
                    case 3:
                        ThemMoiBao(quanlysach);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong phu hop");
                        break;
                }
            } while (loai != 0);


        }
        static void ThemMoiSach(QuanLySach quanlysach)
        { 
            Console.Write("Nhap ma tai lieu:");
            string matailieu = Console.ReadLine();

            Console.Write("Nhap ten nha xuat ban:");
            string tennhaxuatban = Console.ReadLine();

            Console.Write("Nhap so phat hanh:");
            int sobanphathanh = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten tac gia:");
            string tentacgia = Console.ReadLine();

            Console.Write("Nhap so trang:");
            int sotrang = int.Parse(Console.ReadLine());

            Sach sach = new Sach(matailieu, tennhaxuatban, sobanphathanh, tentacgia, sotrang);
            Console.WriteLine("Them sach thanh cong");
        }

        static void ThemMoiTapChi(QuanLySach quanlysach)
        {
            Console.Write("Nhap ma tai lieu:");
            string matailieu = Console.ReadLine();

            Console.Write("Nhap ten nha xuat ban:");
            string tennhaxuatban = Console.ReadLine();

            Console.Write("Nhap so phat hanh:");
            int sobanphathanh = int.Parse(Console.ReadLine());

            Console.Write("Nhap so phat hanh:");
            int sophathanh = int.Parse(Console.ReadLine());

            Console.Write("Nhap thang phat hanh:");
            int thangphathanh = int.Parse(Console.ReadLine());
            TapChi tapchi = new TapChi(matailieu, tennhaxuatban, sobanphathanh, sophathanh, thangphathanh);

            Console.WriteLine("Them tap chi thanh cong");
        }


        static void ThemMoiBao(QuanLySach quanlysach)
        {
            Console.Write("Nhap ma tai lieu:");
            string matailieu = Console.ReadLine();

            Console.Write("Nhap ten nha xuat ban:");
            string tennhaxuatban = Console.ReadLine();

            Console.Write("Nhap so phat hanh:");
            int sobanphathanh = int.Parse(Console.ReadLine());

            Console.Write("Nhap ngay phat hanh:");
            int ngayphathanh = int.Parse(Console.ReadLine());

            Bao bao = new Bao(matailieu, tennhaxuatban, sobanphathanh, ngayphathanh);
            Console.WriteLine("Them tap chi thanh cong");
        }
        static void XoaTaiLieu(QuanLySach quanlysach)
        {
            Console.WriteLine("---XOA TAI LIEU THEO MA TAI LIEU---");
            Console.Write("Nhap tai lieu can xoa:");
            string matailieu = Console.ReadLine();
            quanlysach.XoaTaiLieu(matailieu);
        }
        static void HienThiTHongTinTaiLieu(QuanLySach quanlysach)
        {
            Console.WriteLine("---HIEN THI THONG TIN TAI LIEU---");
            Console.WriteLine("Nhap tai lieu can hien thi:");
            string matailieu = Console.ReadLine();
            quanlysach.HienThiTHongTinTaiLieu(matailieu);
        }
        static void TimKiemTheoLoai(QuanLySach quanlysach)
        {
            Console.WriteLine("----- TIM KIEM TAI LIEU THEO LOAI -----");

            Console.WriteLine("Nhap tai lieu can tim kiem:");
            Console.WriteLine("1. Sach");
            Console.WriteLine("2. Tap chi");
            Console.WriteLine("3. Bao");
            Console.Write("Ban chon loai nao:");
            int tim = int.Parse(Console.ReadLine());
            switch (tim)
            {
                case 1:
                    quanlysach.TimKiemTheoLoai<Sach>();
                    break;
                case 2:
                    quanlysach.TimKiemTheoLoai<TapChi>();
                    break;
                case 3:
                    quanlysach.TimKiemTheoLoai<Bao>();
                    break;
                default:
                    Console.WriteLine("Lua chon khong phu hop");
                    break;
            }


        }
    }
}
