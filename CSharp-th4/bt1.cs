/**
 Bai tap 1 chuong 4:  
   Tim max 4 so
   
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
            // declare variable
            int[] arr = new int[4];
            // input
            for (int i = 0; i < 4; i++)
            {
                System.Console.Write("Nhap vao so thu {0}: ", i + 1);
                arr[i] = (Convert.ToInt32(Console.ReadLine()));
            }
            // processing
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            // output
            Console.WriteLine(max);
        }
    }
}