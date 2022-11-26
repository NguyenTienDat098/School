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
            int.TryParse(Console.ReadLine(), out number);
            return number;
        }

        static double TongA(int number, int x)
        {
            double tong = 0;
            for (int i = 0; i <= number; i++)
            {
                tong += Math.Pow(x, i);
            }
            return tong;
        }
        static double TongB(int number, int x)
        {
            double tong = 0;
            for (int i = 0; i <= number; i++)
            {
                tong += Math.Pow(-1.0 * x, i);
            }
            return tong;
        }
        public static void Main()
        {
            System.Console.Write("Nhap vao so nguyen n: ");
            int number = NhapSoNguyen();
            System.Console.Write("Nhap vao so nguyen x: ");
            int x = NhapSoNguyen();
            System.Console.WriteLine("Tong A: " + TongA(number, x));
            System.Console.WriteLine("Tong B: " + TongB(number, x));
        }
    }
}