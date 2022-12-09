namespace BT
{
    class Program
    {
        // MAIN
        static void Main()
        {
            Menu();
        }

        // HAM NHAP SO NGUYEN DUONG
        static void NhapSoNguyenDuong(ref int number, string message)
        {
            do
            {
                System.Console.Write(message);
                int.TryParse(Console.ReadLine(), out number);
            } while (number <= 0);
        }

        // HAM KIEM TRA SO HOAN HAO
        static bool KiemTraSoHoanHao(int number)
        {
            int count = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    count += i;
                }
            }
            if (count == number)
            {
                return true;
            }
            return false;
        }

        // HAM TINH TONG CAC CHU SO CUA MOT SO
        static int TinhTongCacChuSo(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result += (number % 10);
                number /= 10;
            }
            return result;
        }
        // REPEAT MENU
        static void Repeat()
        {
            char continute = ' ';
            System.Console.WriteLine("Ban co muon tiep tuc khong ?");
            System.Console.WriteLine("'Y'. Co");
            System.Console.WriteLine("'N'. Khong");
            System.Console.Write("Nhap vao lua chon cua ban: ");
            char.TryParse(Console.ReadLine(), out continute);

            if (continute == 'Y' || continute == 'y')
            {
                Menu();
            }
        }
        // MENU
        static void Menu()
        {
            System.Console.Clear();
            // KHAI BAO
            int number = 0;
            int choose = 0;
            // HIEN THI MENU
            System.Console.WriteLine("1.Tinh tong cac chu so cua mot so");
            System.Console.WriteLine("2.Kiem tra so hoan hao");
            System.Console.WriteLine();
            // INPUT
            NhapSoNguyenDuong(ref choose, "Nhap vao lua chon cua ban: ");
            NhapSoNguyenDuong(ref number, "Nhap vao so nguyen n: ");

            switch (choose)
            {
                case 1:
                    System.Console.WriteLine($"Tong cac chu so cua {number} la {TinhTongCacChuSo(number)}");
                    break;
                case 2:
                    if (KiemTraSoHoanHao(number))
                    {
                        System.Console.WriteLine($"{number} la so hoan hao");
                    }
                    else
                    {
                        System.Console.WriteLine($"{number} khong la so hoan hao");
                    }
                    break;
                default:
                    break;
            }
            Repeat();
        }
    }
}