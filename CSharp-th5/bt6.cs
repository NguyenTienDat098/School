/**
    Chuong 5 bai 6:

    Name: Nguyen Tien Dat
    Date: 11/9/2022
*/
using System;
namespace Program
{
    class Program
    {
        static int Fib(int number)
        {
            if (number == 1 || number == 0)
            {
                return 1;
            }
            return Fib(number - 1) + Fib(number - 2);
        }
        public static void Main()
        {
            int number = 0;
            System.Console.Write("Nhap vao mot so nguyen: ");
            Int32.TryParse(Console.ReadLine(), out number);

            // in day fibonaci tu fn0 -> fnN
            for (int i = 0; i <= number; i++)
            {
                System.Console.Write(Fib(i) + " ");
            }

            // tim so hang thu n cua day fibonaci
            System.Console.WriteLine();
            System.Console.WriteLine(Fib(number));
        }
    }
}