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

        // HAM KIEM TRA HOP SO
        static bool KiemTraHopSo(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                return true;
            }
            return false;
        }

        // HAM TINH TONG CAC CHU SO CUA MOT SO
        static int DemHopSo(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (KiemTraHopSo(i))
                {
                    count++;
                }
            }
            return count;
        }
        // REPEAT MENU
        static void Repeat()
        {
            char continute = ' ';
            System.Console.WriteLine();
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
            System.Console.WriteLine("1.Dem so hop so nho hon n");
            System.Console.WriteLine("2.Kiem tra hop so");
            System.Console.WriteLine();
            // INPUT
            NhapSoNguyenDuong(ref choose, "Nhap vao lua chon cua ban: ");
            NhapSoNguyenDuong(ref number, "Nhap vao so nguyen n: ");

            switch (choose)
            {
                case 1:
                    System.Console.WriteLine($"so luong hop so nho hon {number} la: {DemHopSo(number)}");
                    break;
                case 2:
                    if (KiemTraHopSo(number))
                    {
                        System.Console.WriteLine($"{number} la hop so");
                    }
                    else
                    {
                        System.Console.WriteLine($"{number} khong la hop so");
                    }
                    break;
                default:
                    break;
            }
            Repeat();
        }
    }
}