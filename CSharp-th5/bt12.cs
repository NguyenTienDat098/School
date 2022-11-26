/**
    Chuong 5 bai 3:

    Name: Nguyen Tien Dat
    Date: 11/9/2022
*/
using System;
namespace Program
{
    class Program
    {
        static int NhapSoNguyen()
        {
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);
            return number;
        }
        static bool KiemTraSoNguyenTo(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            return false;
        }
        public static void Main()
        {
            System.Console.Write("Nhap vao mot so nguyen: ");
            int number = NhapSoNguyen();
            // in cac so nguyen to tu 2 - number
            System.Console.WriteLine("Cac so nguyen to tu 2 - {0} la: ", number);
            for (int i = 2; i <= number; i++)
            {
                if (KiemTraSoNguyenTo(i))
                {
                    System.Console.Write(i + " ");
                }
            }
        }
    }
}