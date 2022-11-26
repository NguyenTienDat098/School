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
        static void InBangCuuChuong()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    System.Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
        public static void Main()
        {
            InBangCuuChuong();
        }
    }
}