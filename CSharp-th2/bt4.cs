/**
 Bai tap 4 chuong 2:  
   Nhap vao hai so , thuc hien hoan vi hai so

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
namespace bt4
{
    class bt4
    {
        static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        static void Main()
        {

            Console.WriteLine(" --- Swap a, b --- ");
            //input 
            Console.Write("Enter the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Before swap a = {0}, b = {1}", a, b);
            // processing
            Swap(ref a, ref b); // ham thuc hien hoan vi hai so
            // output
            Console.WriteLine("After swap a = {0}, b = {1}", a, b);

        }
    }
}
