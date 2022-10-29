/**
 Bai tap 10 chuong 3:  
   Tinh khoang cach giua 2 diem 

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
namespace bt10
{
    class bt10
    {
        static void Main()
        {
            // declare variable
            double x1 = 0;
            double x2 = 0;
            double y1 = 0;
            double y2 = 0;
            // input
            Console.Write("Nhap vao toa do x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao toa do y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao toa do x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao toa do y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            // processing
            double distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
            // output
            Console.WriteLine("Khoang cach tu diem a toa do ({0},{1}) toi diem b toa do ({2},{3}) la: {4}", x1, y1, x2, y2, distance);
            Console.ReadKey();
        }
    }
}