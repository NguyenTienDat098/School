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
        // HAM NHAP MANG SO THUC
        static void NhapMangSoThuc(ref double[] arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                System.Console.Write($"Nhap vao phan tu thu {i} cua mang: ");
                double.TryParse(Console.ReadLine(), out arr[i]);
            }
        }
        // HAM XUAT MANG
        static void XuatMang(ref double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i] + " ");
            }
        }
        // HAM DEM SO LUONG SO AM CO TRONG MANG
        static int DemSoAmTrongMang(ref double[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    result++;
                }
            }
            return result;
        }
        // HAM LIET KE CAC SO DUONG TAI CAC VI TRI CHAN CO TRONG MANG
        static void LietKeSoDuongTaiViTriChan(ref double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0 && arr[i] > 0)
                {
                    System.Console.Write(arr[i] + " ");
                }
            }
        }
        // HAM VI TRI SO DUONG NHO NHAT TRONG MANG
        static double TimViTriSoDuongNhoNhat(ref double[] arr)
        {
            double min = arr[0];
            int viTri = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] < min)
                {
                    min = arr[i];
                    viTri = i;
                }
            }
            return viTri;
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
                    break;
                case 2:

                    break;
                default:
                    break;
            }
            Repeat();
        }
    }
}