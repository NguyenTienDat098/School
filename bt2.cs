using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Program
    {

        static void NhapSoNguyenDuong(ref int number , string message)
        {
            do
            {
                Console.Write(message);
                int.TryParse(Console.ReadLine(), out number);

            } while (number <= 0);
        }
        static void Main(string[] args)
        {
            // 
            double tongTien = 0;
            double tienTraTruocBaGio = 0;
            double tienTraSauBaGio = 0;
            int gioBatDau = 0;
            int gioKetThuc = 0;
            int tongThoiGian = 0;
            double giamGia = 0;

            NhapSoNguyenDuong(ref gioBatDau, "Nhap vao gio bat dau: ");
            NhapSoNguyenDuong(ref gioKetThuc, "Nhap vao gio ket thuc: ");
            tongThoiGian = gioKetThuc - gioBatDau;
            if (tongThoiGian >= 8)
            {
                giamGia = 1.0 * 10 / 100;
            }

            if (tongThoiGian > 3)
            {
                tienTraTruocBaGio = 3 * 30000;
                tongThoiGian -= 3;
                tienTraSauBaGio = tongThoiGian * (1.0 * 30 / 100) * (tienTraTruocBaGio);
            }
            else
            {
                tienTraTruocBaGio = tongThoiGian * 30000;
            }
            
            tongTien = tienTraTruocBaGio + tienTraSauBaGio - ((tienTraTruocBaGio + tienTraSauBaGio) * giamGia);
            Console.WriteLine("Tong tien phai tra: " + tongTien + "VND");
        }
    }
}
