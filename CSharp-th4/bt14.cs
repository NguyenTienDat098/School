/**
Bai tap 14 chuong 4:  
   Tro choi keo, bua, bao
Name: Nguyen Tien Dat
Date: 29/10/2022
*/
using System;
namespace bt5
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            System.Console.Write("Nguoi choi 1 nhap vao ki tu: ");
            char ng1 = char.Parse(Console.ReadLine());
            System.Console.Write("Nguoi choi 2 nhap vao ki tu: ");
            char ng2 = char.Parse(Console.ReadLine());
            // processing
            switch (ng1)
            {
                case 'B':
                    switch (ng2)
                    {
                        case 'K':
                            Console.WriteLine("NGUOI THU 1 THANG");
                            break;
                        case 'G':
                            Console.WriteLine("NGUOI THU 2 THANG");
                            break;
                        case 'B':
                            Console.WriteLine("HOA NHAU");
                            break;
                        default:
                            Console.WriteLine("KHONG HOP LE");
                            break;
                    }
                    break;
                case 'K':
                    switch (ng2)
                    {
                        case 'B':
                            Console.WriteLine("NGUOI THU 2 THANG");
                            break;
                        case 'G':
                            Console.WriteLine("NGUOI THU 1 THANG");
                            break;
                        case 'K':
                            Console.WriteLine("HOA NHAU");
                            break;
                        default:
                            Console.WriteLine("KHONG HOP LE");
                            break;
                    }
                    break;
                case 'G':
                    switch (ng2)
                    {
                        case 'B':
                            Console.WriteLine("NGUOI THU 1 THANG");
                            break;
                        case 'K':
                            Console.WriteLine("NGUOI THU 2 THANG");
                            break;
                        case 'G':
                            Console.WriteLine("HOA NHAU");
                            break;
                        default:
                            Console.WriteLine("KHONG HOP LE");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("KHONG HOP LE");
                    break;
            }
        }
    }
}