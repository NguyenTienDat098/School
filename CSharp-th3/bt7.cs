/**
 Bai tap 7 chuong 3:  
    Quy doi giay ve gio:phut:giay

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
using System;

namespace bt7
{
    class bt7
    {
        static void Main()
        {
            // declare variable
            const double MINVALUE = 0, MAXVALUE = 86399;
            double hours = 0, seconds = 0, minutes = 0;
            // input
            Console.Write("Nhap vao so giay: ");
            double second = Convert.ToDouble(Console.ReadLine());

            // check valid input
            if (second < MINVALUE || second > MAXVALUE)
            {
                Console.WriteLine("So nhap vao khong hop le !!!");
                Console.ReadKey();
                return;
            }
            else
            {
                // processing
                hours = Math.Round(second / 3600);
                minutes = Math.Round((second % 3600) / 60);
                seconds = Math.Round((second % 3600) % 60);
                Console.WriteLine("{0} gio, {1} phut, {2} giay", hours, minutes, seconds);
            }

            Console.ReadKey();
        }
    }
}