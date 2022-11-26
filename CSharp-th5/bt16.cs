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

        public static void Main()
        {
            int tich = 1;
            int tong = 0;
            int chuc = 0;
            int donvi = 0;
            for (int i = 10; i <= 99; i++)
            {
                chuc = i / 10;
                donvi = i % 10;
                tong = chuc + donvi;
                tich = chuc * donvi;
                if (tich == 2 * tong)
                {
                    System.Console.Write(i + " ");
                }
            }
        }
    }
}