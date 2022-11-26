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

        static bool KiemTraSoHoanHao(int number)
        {
            int tong = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    tong += i;
                }
            }
            if (tong == number)
            {
                return true;
            }
            return false;
        }
        public static void Main()
        {
            int number = NhapSoNguyen();
            if (KiemTraSoHoanHao(number))
            {
                System.Console.WriteLine($"{number} la so hoan hao");
            }
            else
            {
                System.Console.WriteLine($"{number} khong la so hoan hao");
            }
        }
    }
}