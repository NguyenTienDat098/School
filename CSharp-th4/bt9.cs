/**
Bai tap 9 chuong 4:  
 Viết chương trình nhập vào 2 số thực x, y và menu cho phép người dùng lựa chọn một trong trong bốn toán tử +, -, *, /. Nếu chọn sai yêu cầu chọn lại.
 Nếu là + thì in ra kết quả x + y, nếu là – thì in ra x – y, nếu là * thì in ra x * y, nếu là / thì in ra x / y (nếu y = 0 thì thông báo không chia được) và kết thúc chương trình.

Name: Nguyen Tien Dat
Date: 29/10/2022
*/

using System;
namespace bt5
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            System.Console.Write("Nhap vao so thu 1: ");
            double x = double.Parse(Console.ReadLine());
            System.Console.Write("Nhap vao so thu 2: ");
            double y = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao phep tinh (+, -, *, /): ");
            char c = char.Parse(Console.ReadLine());
            // processing
            switch (c)
            {
                case '+':
                    Console.WriteLine(x + y);
                    break;
                case '-':
                    Console.WriteLine(x - y);
                    break;
                case '*':
                    Console.WriteLine(x * y);
                    break;
                case '/':
                    if (y == 0)
                    {
                        Console.WriteLine("Khong chia duoc");
                    }
                    else
                    {
                        Console.WriteLine("{0:0.0}", x / y);
                    }
                    break;
                default:
                    Console.WriteLine("Phep toan khong hop le");
                    break;
            }
        }
    }
}