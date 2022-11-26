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
        static int InSoDao(int number)
        {
            string strNumber = Convert.ToString(number);
            string newNumber = "";
            for (int i = strNumber.Length - 1; i >= 0; i--)
            {
                newNumber += strNumber[i];
            }
            return int.Parse(newNumber);
        }

        public static void Main()
        {
            System.Console.Write("Nhap vao mot so nguyen: ");
            int number = NhapSoNguyen();
            // in so dao nguoc cua number
            System.Console.WriteLine("So dao nguoc cua {0} la: {1}", number, InSoDao(number));
        }
    }
}