using System;


namespace BT
{
    class Program
    {
        // MAIN
        static void Main(string[] args)
        {
            Menu();
        }
        // HAM NHAP SO NGUYEN DUONG
        static void NhapSoNguyenDuong(ref int number, string message)
        {
            do
            {
                Console.Write(message);
                int.TryParse(Console.ReadLine(), out number);
            } while (number <= 0);
        }
        // HAM NHAP SO THUC DUONG
        static void NhapSoThucDuong(ref double number, string message)
        {
            do
            {
                Console.Write(message);
                double.TryParse(Console.ReadLine(), out number);
            } while (number <= 0);
        }
        // HAM NHAP MANG
        static void NhapMang(ref double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Nhap vao phan tu thu {i}: ");
                double.TryParse(Console.ReadLine(), out arr[i]);
            }
        }
        // HAM XUAT MANG
        static void XuatMang(ref double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        // HAM XOA PHAN TU TRONG MANG 
        static void Xoa(ref double[] arr, int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                for (int i = index; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                // RESIZE LENGTH OF ARRAY
                Array.Resize<double>(ref arr, arr.Length - 1);
            }
        }
        // HAM THEM PHAN TU VAO TRONG MANG 
        static void Them(ref double[] arr, int index, double valueAdd)
        {
            if (index >= 0 && index < arr.Length)
            {
                // RESIZE LENGTH OF ARRAY
                Array.Resize<double>(ref arr, arr.Length + 1);
                for (int i = arr.Length - 1; i >= index; i--)
                {
                    arr[i] = arr[i - 1];

                }
                arr[index] = valueAdd;
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
        // HAM KIEM TRA SO CHINH PHUONG
        static bool KiemTraSoChinhPhuong(double number)
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
        // HAM CHEN SO THUC VAO VI TRI SAU SO AM DAU TIEN TRONG MANG
        static void ChenSoThucSauSoAmDauTien(ref double[] arr, double valueAdd)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Them(ref arr, i + 1, valueAdd);
                    break;
                }
            }
        }
        // HAM CHEN SO THUC VAO VI TRI SAU SO CHINH PHUONG DAU TIEN CO TRONG MANG
        static void ChenSoThucSauSoChinhPhuongDauTien(ref double[] arr, double valueAdd)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraSoChinhPhuong(arr[i]))
                {
                    Them(ref arr, i + 1, valueAdd);
                    break;
                }
            }
        }
        // HAM XOA TOAN BO SO CHAN CO TRONG MANG
        static void XoaToanBoSoChan(ref double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i]) % 2 == 0)
                {
                    Xoa(ref arr, i);
                }
            }
        }
        // HAM TIM SO DUONG NHO NHAT CO TRONG MANG
        static double TimSoDuongNhoNhat(ref double[] arr)
        {
            double min = arr[0];
            foreach (var item in arr)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        // HAM XOA SO DUONG NHO NHAT CO TRONG MANG
        static void XoaSoDuongNhoNhat(ref double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (TimSoDuongNhoNhat(ref arr) == arr[i])
                {
                    Xoa(ref arr, i);
                }
            }
        }
        // SAP XEP MANG TANG DAN
        static void SapXepMangTangDan(ref double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        double temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        // HAM LAP LAI MENU
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
            int choose = 0;
            int number = 0;
            double value = 0;

            // HIEN THI MENU
            System.Console.WriteLine("1.Dem so luong so am co trong mang");
            System.Console.WriteLine("2.Liet ke cac so duong xuat hien o vi tri chan");
            System.Console.WriteLine("3.Tim vi tri so duong nho nhat co trong mang");
            System.Console.WriteLine("4.Chen phan tu x sau vi tri so am dau tien co trong mang");
            System.Console.WriteLine("5.Chen phan tu x sau vi tri so chinh phuong dau tien co trong mang");
            System.Console.WriteLine("6.Xoa toan bo so chan co trong mang");
            System.Console.WriteLine("7.Xoa so duong nho nhat co trong mang");
            System.Console.WriteLine("8.Sap xep mang tang dan");

            System.Console.WriteLine();
            // INPUT
            NhapSoNguyenDuong(ref choose, "Nhap vao lua chon cua ban: ");
            NhapSoNguyenDuong(ref number, "Nhap vao do dai cua mang: ");
            double[] arr = new double[number];
            NhapMang(ref arr);

            if (choose == 4 || choose == 5)
            {
                NhapSoThucDuong(ref value, "Nhap vao gia tri can chen: ");
            }

            switch (choose)
            {
                case 1:
                    Console.WriteLine($"So luong so am co trong mang la: {DemSoAmTrongMang(ref arr)}");
                    break;
                case 2:
                    Console.WriteLine($"Cac so duong xuat hien o vi tri chan la: ");
                    LietKeSoDuongTaiViTriChan(ref arr);
                    break;
                case 3:
                    Console.WriteLine($"Vi tri so duong nho nhat co trong mang: {TimViTriSoDuongNhoNhat(ref arr)}");
                    break;
                case 4:
                    Console.WriteLine($"Chen phan tu x sau vi tri so am dau tien co trong mang: ");
                    Console.WriteLine("Mang ban dau : ");
                    XuatMang(ref arr);
                    ChenSoThucSauSoAmDauTien(ref arr, value);
                    Console.WriteLine();
                    Console.WriteLine("Mang sau khi Chen: ");
                    XuatMang(ref arr);
                    break;
                case 5:
                    Console.WriteLine($"Chen phan tu x sau vi tri so chinh phuong dau tien co trong mang: ");
                    Console.WriteLine("Mang ban dau : ");
                    XuatMang(ref arr);
                    ChenSoThucSauSoChinhPhuongDauTien(ref arr, value);
                    Console.WriteLine();
                    Console.WriteLine("Mang sau khi Chen: ");
                    XuatMang(ref arr);
                    break;
                case 6:
                    Console.WriteLine($"Xoa toan bo so chan co trong mang: ");
                    Console.WriteLine("Mang ban dau : ");
                    XuatMang(ref arr);
                    XoaToanBoSoChan(ref arr);
                    Console.WriteLine();
                    Console.WriteLine("Mang sau khi xoa: ");
                    XuatMang(ref arr);
                    break;
                case 7:
                    Console.WriteLine($"Xoa so duong nho nhat co trong mang: ");
                    Console.WriteLine("Mang ban dau : ");
                    XuatMang(ref arr);
                    XoaSoDuongNhoNhat(ref arr);
                    Console.WriteLine();
                    Console.WriteLine("Mang sau khi xoa: ");
                    XuatMang(ref arr);
                    break;
                case 8:
                    Console.WriteLine($"Sap xep mang tang dan: ");
                    Console.WriteLine("Mang ban dau : ");
                    XuatMang(ref arr);
                    Console.WriteLine();
                    Console.WriteLine("Mang sau khi sap xep: ");
                    XuatMang(ref arr);
                    break;

                default:
                    break;
            }
            Repeat();
        }
    }
}
