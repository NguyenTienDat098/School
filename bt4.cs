namespace BT
{
    class BT4
    {
        static void NhapSoNguyenDuong(ref int number, string message)
        {
            do
            {
                System.Console.Write(message);
                int.TryParse(Console.ReadLine(), out number);
            } while (number <= 0);
        }
        static void Main()
        {
            // KHAI BAO

            // CONST VAR
            const double GIADIENDUOI50 = 1500;
            const double GIADIENDUOI100 = 1700;
            const double GIADIENDUOI200 = 2000;
            const double GIADIENDUOI300 = 2500;
            const double GIADIENTREN300 = 3000;



            // VARIABLE
            int chiSoCu = 0;
            int chiSoMoi = 0;
            int soDien = 0;
            double tongTienDien = 0;
            double tienDien = 0;
            double thueVat = 0.1;

            // INPUT
            NhapSoNguyenDuong(ref chiSoCu, "Nhap vao chi so cu: ");
            NhapSoNguyenDuong(ref chiSoMoi, "Nhap vao chi so moi: ");
            // PROCESSING
            soDien = chiSoMoi - chiSoCu;
            if (soDien <= 50)
            {
                tienDien = soDien * GIADIENDUOI50;
            }
            else
            {
                tienDien = 50 * GIADIENDUOI50;
                soDien -= 50;
                if (soDien >= 50)
                {
                    tienDien += 50 * GIADIENDUOI100;
                    soDien -= 50;
                    if (soDien >= 100)
                    {
                        tienDien += 100 * GIADIENDUOI200;
                        soDien -= 100;
                        if (soDien >= 100)
                        {
                            tienDien += 100 * GIADIENDUOI300;
                            soDien -= 100;
                            tienDien += soDien * GIADIENTREN300;
                        }
                        else
                        {
                            tienDien += soDien * GIADIENDUOI300;
                        }
                    }
                    else
                    {
                        tienDien += soDien * GIADIENDUOI200;
                    }
                }
                else
                {
                    tienDien += soDien * GIADIENDUOI100;
                }
            }
            tongTienDien = tienDien * thueVat + tienDien;
            System.Console.WriteLine("Tong tien dien phai tra la: " + tongTienDien + "VND");
        }
    }
}