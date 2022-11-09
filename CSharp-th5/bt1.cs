/**
    Chuong 5 bai 1:

    Name: Nguyen Tien Dat
    Date: 11/9/2022
*/
using System;
namespace Program
{

    class Program
    {
        static int A(int number)
        {
            int tong = 0;
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    tong += i;
                }
            }
            return tong;
        }
        static int B(int number)
        {
            int tich = 1;
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    tich *= i;
                }
            }
            return tich;
        }
        static double C(int number)
        {
            double tong = 0;
            for (int i = 1; i < number; i++)
            {
                tong += (1.0 / i);
            }
            return Math.Round(tong, 2);
        }
        static double D(int number)
        {
            int tich = 1;
            for (int i = 1; i <= number; i++)
            {
                tich *= (2 * i);
            }
            return tich;
        }
        static int E(int number)
        {
            int tich = 1;
            for (int i = 1; i <= number; i++)
            {
                tich *= i;
            }
            return tich;
        }

        static void Menu(ref int number)
        {
            Console.Clear();
            System.Console.WriteLine("A = Tong cac so le nho hon hay bang n.");
            System.Console.WriteLine("B = Tich cac boi so cua 3 nho hon hay bang n.");
            System.Console.WriteLine("C = 1 + 1/2 + 1/3 + ... + 1/n-1.");
            System.Console.WriteLine("D = 2 * 4 * 6 * ... 2n.");
            System.Console.WriteLine("E = 1 * 2 * 3 * ... n.");
            System.Console.WriteLine();

            char choose = 'X';
            System.Console.Write("Nhap vao lua chon cua ban: ");
            Char.TryParse(Console.ReadLine(), out choose);
            switch (choose)
            {
                case 'A':
                    System.Console.WriteLine(A(number));
                    break;
                case 'B':
                    System.Console.WriteLine(B(number));
                    break;
                case 'C':
                    System.Console.WriteLine(C(number));
                    break;
                case 'D':
                    System.Console.WriteLine(D(number));
                    break;
                case 'E':
                    System.Console.WriteLine(E(number));
                    break;
                default:
                    System.Console.WriteLine("Khong hop le !!!");
                    break;
            }
        }
        public static void Main()
        {
            int number = 0;
            System.Console.Write("Nhap vao mot so nguyen: ");
            Int32.TryParse(Console.ReadLine(), out number);
            Menu(ref number);

        }
    }
}