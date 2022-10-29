/**
 Bai tap 2 chuong 4:  
   In hoc luc
   
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
            System.Console.Write("Nhap vao diem trung binh: ");
            double tb = Convert.ToDouble(Console.ReadLine());
            // processing and output
            System.Console.Write("Hoc luc cua ban: ");
            if (tb >= 0 && tb <= 10)
            {
                if (tb >= 0 && tb < 3)
                {
                    Console.WriteLine("Kem");
                }
                else if (tb >= 3 && tb < 5)
                {
                    Console.WriteLine("Yeu");
                }
                else if (tb >= 5 && tb < 6.5)
                {
                    Console.WriteLine("Trung binh kha");
                }
                else if (tb >= 6.5 && tb < 8)
                {
                    Console.WriteLine("Kha");
                }
                else if (tb >= 8 && tb < 9)
                {
                    Console.WriteLine("Gioi");
                }
                else if (tb >= 9 && tb <= 10)
                {
                    Console.WriteLine("Xuat sac");
                }
            }
        }
    }
}