/**
 Bai tap 5 chuong 4:  
   Viet chuong trinh nhap vao gio , phut, giay, so giay them vao
   In ra ket qua sau khi cong them so giay them vao (hh:mm:ss)
   
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
            System.Console.Write("Nhap vao diem toan: ");
            int h = Convert.ToInt32(Console.ReadLine()); // gio
            System.Console.Write("Nhap vao phut: ");
            int m = Convert.ToInt32(Console.ReadLine()); // phut
            System.Console.Write("Nhap vao giay: ");
            int s = Convert.ToInt32(Console.ReadLine()); // giay 
            System.Console.Write("Nhap vao giay them vao: ");
            int sAdd = Convert.ToInt32(Console.ReadLine()); // so giay them vao

            // processing
            s += sAdd;
            while (s >= 60)
            {
                s -= 60;
                m += 1;
                if (m >= 60)
                {
                    m -= 60;
                    h += 1;
                    if (h >= 24)
                    {
                        h -= 24;
                    }
                }
            }
            // output
            Console.WriteLine($"{h:00}:{m:00}:{s:00}");
        }
    }
}