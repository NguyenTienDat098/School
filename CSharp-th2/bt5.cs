/**
 Bai tap 5 chuong 2:  
   Nhap vao 1 so nguyen n in ra bang nhan cua n

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
namespace bt5
{
    class bt5
    {
        static void Main()
        {
            // input
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear(); //clear console
                             // output
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }
    }
}
