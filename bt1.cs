using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://drive.google.com/drive/folders/1chJeac-mqC2NPjlIvJTwkXGuf55342WZ?usp=sharing
namespace BT
{
    class Program
    {
        static void NhapSoNguyenDuong(ref int number)
        {
            do
            {
                int.TryParse(Console.ReadLine(), out number);

            } while (number <= 0);
        }
        static void Main(string[] args)
        {
            // 
            int thamNien = 0;
            int soNgayNghi = 0;
            double heSo = 0;
            double luongCoBan = 650000;
            double luong = 0;

            Console.Write("Nhap vao tham nien cong tac: ");
            NhapSoNguyenDuong(ref thamNien);

            do
            {
                Console.Write("Nhap vao so ngay nghi: ");
                NhapSoNguyenDuong(ref soNgayNghi);
            } while (soNgayNghi < 1 || soNgayNghi > 20);

            if (thamNien < 12)
            {
                heSo = 1.92;
            }
            else if (thamNien < 36)
            {
                heSo = 2.34;
            }else
            {
                heSo = 3.0;
            }

            luong = luongCoBan * heSo;
            Console.WriteLine("Luong :" + luong);

            if (soNgayNghi < 2)
            {
                Console.WriteLine("DUOC KHEN THUONG");
            }else
            {
                Console.WriteLine("KHONG DUOC KHEN THUONG");
            }
        }
    }
}
