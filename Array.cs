using Mathss;
namespace Arrayss
{
    class Arrays
    {
        // HAM NHAP MANG SO NGUYEN
        public void NhapMangSoNguyen(ref int[] arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Nhap vao phan tu thu {i}: ");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
        }
        // HAM XUAT MANG SO NGUYEN
        public void XuatMang(ref int[] arr)
        {
            Console.WriteLine("Cac phan tu cua mang la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        // HAM SAP XEP MANG TANG DAN
        public void SapXepMangTangDan(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        new Maths().HoanViTri(ref arr[i], ref arr[j]);
                    }
                }
            }
        }
        // SAP XEP MANG GIAM DAN 
        public void SapXepMangGiamDan(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        new Maths().HoanViTri(ref arr[i], ref arr[j]);
                    }
                }
            }
        }
        // CHEN THEM PHAN TU VAO VI TRI X TRONG MANG
        public void ChenPhanTu(ref int[] arr, int positionAdd, int x)
        {
            if (positionAdd < arr.Length && positionAdd <= 0)
            {
                Array.Resize<int>(ref arr, arr.Length + 1);
                for (int i = arr.Length - 1; i >= positionAdd; i++)
                {
                    arr[i] = arr[i - 1];
                }
                arr[positionAdd] = x;
            }
        }
        // XOA MOT PHAN TU TAI VI TRI X TRONG MANG
        public void XoaPhanTu(ref int[] arr, int positionDel)
        {
            if (positionDel >= 0 && positionDel < arr.Length)
            {
                for (int i = positionDel; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                Array.Resize<int>(ref arr, arr.Length - 1);
            }
        }
        // TIM VI TRI CUA PHAN TU X DAU TIEN TRONG MANG
        public int TimViTriDauTienCuaPhanTu(ref int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        // HAM TIM VI TRI CUOI CUNG CUA PHAN TU X TRONG MANG
        static int TimViTriCuoiCungCuaPhanTu(ref int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
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
        // HAM XUAT CAC SO NGUYEN TO CO TRONG MANG
        static void XuatCacSoNguyenToTrongMang(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (new Maths().KiemTraSoNguyenTo(arr[i]))
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
        }
        // HAM DEM SO LUONG SO HOAN THIEN CO TRONG MANG
        static int DemSoLuongSoHoanHaoTrongMang(ref int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (new Maths().KiemTraSoHoanHao(arr[i]))
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
        // HAM KIEM TRA MANG DA DUOC SAP XEP TANG DAN HAY CHUA
        static bool MangSapXepTangDan(ref int[] arr)
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
        // HAM KIEM TRA MANG DA DUOC SAP XEP TANG DAN HAY CHUA
        static bool MangSapXepGiamDan(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
