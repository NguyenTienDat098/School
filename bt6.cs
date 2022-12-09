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

        // HAM KIEM TRA SO CHINH PHUONG
        static bool KiemTraSoChinhPhuong(int number)
        {
            for (int i = 1; i < number; i++)
            {
                if (i * i == number)
                {
                    return true;
                }
            }
            return false;
        }

        // HAM TINH TONG CAC CHU SO CUA MOT SO
        static void LietKeSoChinhPhuong(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (KiemTraSoChinhPhuong(i))
                {
                    if (i % 10 == 6)
                    {
                        System.Console.Write(i + " ");
                    }
                }
            }
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
            System.Console.WriteLine("1.Cac so chinh phuong tan cung bang 6 va nho hon n");
            System.Console.WriteLine("2.Kiem tra so chinh phuong");
            System.Console.WriteLine();
            // INPUT
            NhapSoNguyenDuong(ref choose, "Nhap vao lua chon cua ban: ");
            NhapSoNguyenDuong(ref number, "Nhap vao so nguyen n: ");

            switch (choose)
            {
                case 1:
                    System.Console.WriteLine($"Cac so chinh phuong tan cung bang 6 va nho hon {number} la: ");
                    LietKeSoChinhPhuong(number);
                    break;
                case 2:
                    if (KiemTraSoChinhPhuong(number))
                    {
                        System.Console.WriteLine($"{number} la so chinh phuong");
                    }
                    else
                    {
                        System.Console.WriteLine($"{number} khong la so chinh phuong");
                    }
                    break;
                default:
                    break;
            }
            Repeat();
        }
    }
}