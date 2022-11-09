/**
    Chuong 5 bai 2:

    Name: Nguyen Tien Dat
    Date: 11/9/2022
*/
using System;
namespace Program
{
    class Program
    {

        public static void Main()
        {
            int number = 0;
            System.Console.Write("Nhap vao mot so nguyen: ");
            Int32.TryParse(Console.ReadLine(), out number);


            System.Console.Write("Cac uoc so cua {0} la: ", number);
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    System.Console.Write(i + " ");
                }
            }

        }
    }
}