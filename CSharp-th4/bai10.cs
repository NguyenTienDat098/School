/**
Bai tap 10 chuong 4:  
 Giai phuong trinh bac 2 ax^2 + bx + c = 0

Name: Nguyen Tien Dat
Date: 29/10/2022
*/

using System;
namespace c4
{
    class bt
    {
        static void Main(string[] args)
        {
            // declare variable
            double a = 0;
            double b = 0;
            double Delta = 0;
            double x = 0;
            double x1 = 0;
            double x2 = 0;

            // input
            System.Console.WriteLine("\t Giai phuong trinh ax^2 + bx + c = 0");
            Console.Write("Nhap vao he so a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao he so b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao he so c: ");
            c = double.Parse(Console.ReadLine());

            // processing , output
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("VSN");
                    }
                    else
                    {
                        Console.WriteLine("VN");
                    }
                }
                else
                {
                    x = -1.0 * c / b;
                    Console.WriteLine($"{x:0.00}");
                }

            }
            else
            {
                Delta = b * b - 4 * a * c;
                if (Delta < 0)
                {
                    Console.WriteLine("VN");
                }
                if (Delta == 0)
                {
                    x = -b / 2 * a;
                    Console.WriteLine($"{x:0.00}");
                }
                if (Delta > 0)
                {
                    x1 = (-b - Math.Sqrt(Delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(Delta)) / (2 * a);
                    Console.WriteLine($"{x1:0.00}");
                    Console.WriteLine($"{x2:0.00}");
                }
            }
        }
    }
}


