/**
Bai tap 13 chuong 4:  
    Nhap vao thang , nam
    In ra so ngay co trong thang cua nam do
Name: Nguyen Tien Dat
Date: 29/10/2022
*/
using System;
namespace c4
{
    class bt
    {
        static void Main()
        {
            // input 
            System.Console.Write("Nhap vao thang: ");
            int month = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap vao nam: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // processing
            switch (month)
            {
                case 1:
                    Console.WriteLine(31);
                    break;
                case 3:
                    Console.WriteLine(31);
                    break;
                case 5:
                    Console.WriteLine(31);
                    break;
                case 7:
                    Console.WriteLine(31);
                    break;
                case 8:
                    Console.WriteLine(31);
                    break;
                case 10:
                    Console.WriteLine(31);
                    break;
                case 12:
                    Console.WriteLine(31);
                    break;
                case 4:
                    Console.WriteLine(30);
                    break;
                case 6:
                    Console.WriteLine(30);
                    break;
                case 9:
                    Console.WriteLine(30);
                    break;
                case 11:
                    Console.WriteLine(30);
                    break;
                case 2:

                    if (year % 4 == 0)
                    {
                        Console.WriteLine(29);
                    }
                    else
                    {
                        Console.WriteLine(28);
                    }
                    break;

                default:
                    break;

            }
        }
    }
}