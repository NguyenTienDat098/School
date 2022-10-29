/**
 Bai tap 4 chuong 3:  
   Kiem tra so chan le

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
namespace bt2
{
    class bt2
    {
        static void Main()
        {
            // declare variable
            int num = 0;
            do
            {
                // input
                System.Console.Write("Nhap vao 1 so nguyen: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num <= 0);


            // processing and output
            if (num % 2 == 0)
            {
                System.Console.WriteLine("So chan");
            }
            else
            {
                System.Console.WriteLine("So le");
            }
        }
    }
}