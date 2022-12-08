using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Program
    {
        static void NhapSoNguyenDuong(ref int number, string message)
        {
            do
            {
                Console.Write(message);
                int.TryParse(Console.ReadLine(), out number);

            } while (number <= 0);
        }

        static int UCLN(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return UCLN(b, a % b);
        }

        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            NhapSoNguyenDuong(ref a, "Nhap vao tu so: ");
            NhapSoNguyenDuong(ref b, "Nhap vao mau so: ");

            if (UCLN(a, b) == 1)
            {
                Console.WriteLine("Phan so toi gian");
            }else
            {
                Console.WriteLine(a / UCLN(a, b) + "/" + b / UCLN(a, b));
            }
        }
    }
}
