/**
 Bai tap 8 chuong 4:  
  Xac dinh bien ki tu color
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
            System.Console.Write("Nhap vao 1 ky tu: ");
            char c = Convert.ToChar(Console.ReadLine());
            // processing
            if (c == 'r' || c == 'R')
            {
                Console.WriteLine("RED");
            }
            else if (c == 'g' || c == 'G')
            {
                Console.WriteLine("GREEN");
            }
            else if (c == 'b' || c == 'B')
            {
                Console.WriteLine("BLUE");
            }
            else
            {
                Console.WriteLine("BLACK");
            }
        }
    }
}