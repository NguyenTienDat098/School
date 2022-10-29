/**
 Bai tap 6 chuong 3:  
    In so dao nguoc

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/

using System;

namespace bt6
{
    class bt6
    {
        static void Main()
        {
            // declare variable
            int number = 0;
            string? str = "";

            // input 
            Console.Write("Nhap vao mot so co hai chu so: ");
            str = Convert.ToString(Console.ReadLine());

            // check valid input
            if (str == null || str?.Length > 2)
            {
                Console.WriteLine("So nhap vao khong hop le !!!");
                return;
            }

            // processing
            string first = Convert.ToString(str[0]);
            string end = Convert.ToString(str[1]);
            number = Convert.ToInt32(end + first);

            // output
            Console.WriteLine("So ban dau la: {0}", str);
            Console.WriteLine("So sau khi hoan doi vi tri la: {0}", number);
            Console.ReadKey();
        }
    }
}