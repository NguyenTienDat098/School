/**
 Bai tap 3 chuong 4:  
   Giai phuong trinh bac nhat ax + b = 0
   
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
            System.Console.WriteLine("\tGiai phuong trinh bac nhat ax + b = 0");
            System.Console.Write("Nhap vao he so a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Nhap vao he so b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // processing
            if (a == 0)
            {
                if (b == 0)
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
                Console.WriteLine($"{-b / a:0.00}");
            }
            Console.ReadKey();
        }
    }
}