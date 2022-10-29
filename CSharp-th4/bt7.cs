/**
 Bai tap 7 chuong 4:  
  Kiem tra thang nhap vao thuoc quy may trong nam

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
            System.Console.Write("Nhap vao thang: ");
            int c = Convert.ToInt32(Console.ReadLine()); // thang trong nam
            // check valid input
            if (c > 0 && c < 13)
            {
                // processing
                if (c == 1 || c == 2 || c == 3)
                {
                    Console.WriteLine("Quy 1");
                }
                else if (c == 4 || c == 5 || c == 6)
                {
                    Console.WriteLine("Quy 2");
                }
                else if (c == 7 || c == 8 || c == 9)
                {
                    Console.WriteLine("Quy 3");
                }
                else
                {
                    Console.WriteLine("Quy 4");
                }
            }
            else
            {
                Console.WriteLine("Khong hop le");
            }
        }
    }
}