/**
 Bai tap 8 chuong 3:  
   Kiem tra mot so nhap vao la so chan hay so le
   - Neu chan tang so do len 1 don vi
   - Neu so le giam so do di 1 don vi

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
using System;

namespace bt7
{
    class bt8
    {

        static void Main()
        {

            // input
            Console.Write("Nhap vao gia tri cua mot so nguyen duong: ");
            int a = Convert.ToInt32(Console.ReadLine());
            // processing
            if (a % 2 == 0)
            {
                a++;
            }
            else
            {
                a--;
            }
            // ouput
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}