/**
    Chuong 5 bai 7:

    Name: Nguyen Tien Dat
    Date: 11/9/2022
*/
using System;
namespace Program
{
    class Program
    {
        static int UCLN(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return UCLN(b, a % b);
        }
        static int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }

        public static void Main()
        {
            int a = 0;
            int b = 0;

            System.Console.Write("Nhap vao mot so nguyen a: ");
            Int32.TryParse(Console.ReadLine(), out a);
            System.Console.Write("Nhap vao mot so nguyen b: ");
            Int32.TryParse(Console.ReadLine(), out b);
            System.Console.WriteLine("UCLN cua {0} va {1} la: {2}", a, b, UCLN(a, b));
            System.Console.WriteLine("BCNN cua {0} va {1} la: {2}", a, b, BCNN(a, b));
        }
    }
}