/**
 Bai tap 9 chuong 3:  
   In so dao nguoc

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
namespace bt9
{
    class bt9
    {
        static void Main()
        {
            // declare variable
            string? a = "";
            string ch = "";

            // input
            Console.Write("Nhap vao gia tri cua mot so nguyen duong: ");
            a = Console.ReadLine();

            // processing
            int arrLength = a.Length;
            for (int i = 0; i < arrLength; i++)
            {
                ch += Convert.ToString(a[arrLength - i - 1]);
            }

            // output
            System.Console.WriteLine("So dao nguoc: ");
            int num = Convert.ToInt32(ch);
            Console.WriteLine(num);
            Console.ReadKey();

        }
    }
}