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
        static bool SoNguyenTo(int number)
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
            int number = 0;
            System.Console.Write("Nhap vao mot so nguyen: ");
            Int32.TryParse(Console.ReadLine(), out number);

            if (SoNguyenTo(number))
            {
                System.Console.WriteLine("{0} la so nguyen to", number);
            }
            else
            {
                System.Console.WriteLine("{0} khong la so nguyen to", number);
            }
        }
    }
}