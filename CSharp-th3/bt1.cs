/**
 Bai tap 1 chuong 3:  
   Nhap vap hai so nguyen in ra ket qua cua phep +, -, *, / cua hai so do

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
namespace bt1
{
    class bt1
    {

        static void calculator(ref int a, ref int b)
        {
            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;

            Console.WriteLine("a + b = {0}", sum);
            Console.WriteLine("a - b = {0}", sub);
            Console.WriteLine("a * b = {0}", mul);
            Console.WriteLine("a / b = {0}", div);
        }
        static void Main()
        {
            // input 
            Console.Write("Enter the value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            // processing
            calculator(ref a, ref b);
        }
    }
}