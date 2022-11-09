/**
    Chuong 5 bai 10:

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
            int length = 0;
            // System.Console.Write("Nhap vao mot do dai canh cua tam giac: ");
            Int32.TryParse(Console.ReadLine(), out length);


            for (int i = 0; i < length; i++)
            {
                for (int k = length - 1; k >= i; k--)
                {
                    System.Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
            }
        }
    }
}