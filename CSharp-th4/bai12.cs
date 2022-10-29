/**
Bai tap 12 chuong 4:  
 Kiem tra ki tu in hoa , in thuong hay la so

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
            System.Console.Write("Nhap vao 1 ki tu: ");
            char ch = Convert.ToChar(Console.ReadLine());

            // processing, output
            if (Char.IsLetter(ch)) // kiem tra neu la chu
            {
                if (Char.IsUpper(ch)) // kiem tra neu in hoa
                {
                    Console.WriteLine("IN HOA");
                }
                else
                {
                    Console.WriteLine("IN THUONG");
                }
            }
            else if (Char.IsDigit(ch)) // kiem tra neu la so
            {
                Console.WriteLine("SO");
            }
            else
            {
                Console.WriteLine("KHAC");
            }
        }
    }
}