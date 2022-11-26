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
        static bool KiemTraSoDoiXung(int number)
        {
            string strNumber = Convert.ToString(number);
            string newNumber = "";
            for (int i = strNumber.Length - 1; i >= 0; i--)
            {
                newNumber += strNumber[i];
            }
            if (newNumber == strNumber)
            {
                return true;
            }
            return false;
        }

        public static void Main()
        {
            System.Console.Write("Nhap vao mot so nguyen: ");
            int number = NhapSoNguyen();
            if (KiemTraSoDoiXung(number))
            {
                System.Console.WriteLine(number + " la so doi xung");
            }
            else
            {
                System.Console.WriteLine(number + " khong la so doi xung");
            }
        }
    }
}