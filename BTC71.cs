using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            int length = 0;
            Console.Write("Nhap vao do dai cua mang: ");
            int.TryParse(Console.ReadLine(), out length);
            int[] arr = new int[length];

            NhapMang(ref arr, length);
            XuatMang(ref arr);
            Console.WriteLine();
            Console.WriteLine($"Phan tu duong nho nhat cua mang la: {TimPhanTuDuongNhoNhat(ref arr)}");
            Console.WriteLine($"Phan tu lon nhat cua mang la: {TimPhanTuLonNhat(ref arr)}");
            Console.WriteLine($"Vi tri so nguyen to dau tien trong mang la: {TimViTriSoNguyenToDauTien(ref arr)}");
            Console.WriteLine($"So luong so hoan hao trong mang la: {DemSoLuongSoHoanHaoTrongMang(ref arr)}");
            Console.WriteLine($"Trung bunh cac phan tu trong mang la: {TrungBinhCacPhanTuTrongMang(ref arr)}");
            
        }
        // HAM XUAT MANG
        static void XuatMang(ref int[] arr)
        {
            Console.WriteLine("Cac phan tu cua mang la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        // HAM XUAT CAC SO CHAN MANG
        static void XuatCacSoChanTrongMang(ref int[] arr)
        {
            Console.WriteLine("Cac phan tu chan cua mang la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
        // HAM NHAP MANG
        static void NhapMang(ref int[] arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Nhap vao phan tu thu {i}: ");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
        }
        // HAM KIEM TRA SO NGUYEN TO
        static bool KiemTraSoNguyenTo(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            return false;
        }
        // HAM XUAT CAC SO NGUYEN TO CO TRONG MANG
        static void XuatCacSoNguyenToTrongMang(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraSoNguyenTo(arr[i]))
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
        }
        // HAM KIEM TRA SO HOAN HAO
        static bool KiemTraSoHoanHao(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
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
        // HAM DEM SO LUONG SO HOAN THIEN CO TRONG MANG
        static int DemSoLuongSoHoanHaoTrongMang(ref int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraSoHoanHao(arr[i]))
                {
                    count++;
                }
            }
            return count;
        }
        // HAM TINH GIA TRI TRUNG BINH CAC PHAN TU TRONG MANG
        static double TrungBinhCacPhanTuTrongMang(ref int[] arr)
        {
            double result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += 1.0 * arr[i];
            }
            return result / arr.Length;
        }
        // HAM TIM VI TRI CUOI CUNG CUA PHAN TU X TRONG MANG
        static int TimViTriXCuoiCung(ref int[] arr, int x)
        {
            int viTri = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    viTri = i;
                    break;
                }
            }
            return viTri;
        }
        // HAM TIM VI TRI SO NGUYEN TO DAU TIEN CO TRONG MANG
        static int TimViTriSoNguyenToDauTien(ref int[] arr)
        {
            int viTri = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraSoNguyenTo(arr[i]))
                {
                    viTri = i;
                    break;
                }
            }
            return viTri;
        }
        // HAM TIM PHAN TU LON NHAT TRONG MANG
        static int TimPhanTuLonNhat(ref int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                    }
                }
            }
            return max;
        }
        // HAM TIM PHAN TU DUONG NHO NHAT TRONG MANG
        static int TimPhanTuDuongNhoNhat(ref int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min && arr[j] > 0)
                    {
                        min = arr[j];
                    }
                }
            }
            return min;
        }
        // SAP XEP CAC PHAN TU CUA MANG THEO THU TU TANG DAN
        static void SapXepCacTangDan(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        // HAM KIEM TRA MANG DA DUOC SAP XEP TANG DAN HAY CHUA
        static bool MangDaSapXep(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
