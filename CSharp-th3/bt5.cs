/**
 Bai tap 5 chuong 3:  
    Tim so nhat giua 2 so

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
namespace bt2
{
    class bt2
    {
        static int Max(int a, int b)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            return max;
        }
        static void Main()
        {
            // declare variable
            int num1 = 0;
            int num2 = 0;
            // input
            System.Console.Write("Nhap vao so thu 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap vao so thu 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            // processing and output
            System.Console.WriteLine("so lon nhat la: " + Max(num1, num2));
        }
    }
}