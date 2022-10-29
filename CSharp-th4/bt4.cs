/**
 Bai tap 4 chuong 4:  
   Kiem tra 1 so nhap vao co phai la so chan va chia het cho 3 khong
   (1 <= input <= 100)

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
            System.Console.Write("Nhap vao so nguyen trong khoang tu 1 - 100: ");
            int n = Convert.ToInt32(Console.ReadLine());
            // check vaid input
            if (n >= 1 && n <= 100)
            {
                // processing
                if (n % 2 == 0 && n % 3 == 0)
                {
                    Console.WriteLine("La so chan chia het cho 3");
                }
                else
                {
                    Console.WriteLine("Khong thoa dieu kien");
                }
            }
            else
            {
                Console.WriteLine("Khong thoa dieu kien");
            }
        }
    }
}