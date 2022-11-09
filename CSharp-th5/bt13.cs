/**
    Chuong 5 bai 13:

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
            int n = 0;
            System.Console.Write("Nhap vao mot do dai canh cua tam giac: ");
            Int32.TryParse(Console.ReadLine(), out n);
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = result * (i - j + 1) / j;
                    }
                    Console.Write(result + " ");
                }
                Console.WriteLine();
            }
        }
    }
}