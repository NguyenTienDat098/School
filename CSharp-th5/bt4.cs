/**
    Chuong 5 bai 13:

    Name: Nguyen Tien Dat
    Date: 26/11/2022
*/
using System;
namespace Program
{
    class Program
    {
        static int NhapSoNguyen()
        {
            int number = 0;
            System.Console.Write("Nhap vao mot so nguyen: ");
            int.TryParse(Console.ReadLine(), out number);
            return number;
        }

        static bool KiemTraSoChinhPhuong(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                if (i * i == number)
                {
                    return true;
                }
            }
            return false;
        }
        public static void Main()
        {
            int number = NhapSoNguyen();
            if (KiemTraSoChinhPhuong(number))
            {
                System.Console.WriteLine($"{number} la so chinh phuong");
            }
            else
            {
                System.Console.WriteLine($"{number} khong la so chinh phuong");
            }
        }
    }
}