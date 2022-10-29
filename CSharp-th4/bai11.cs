/**
Bai tap 11 chuong 4:  
 Tinh tien dien

Name: Nguyen Tien Dat
Date: 29/10/2022
*/
using System;
namespace c4
{
    class bt
    {
        static void Main()
        {
            // input
            System.Console.Write("Nhap vao chi so cu: ");
            int chisoCu = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap vao chi so moi: ");
            int chisoMoi = Convert.ToInt32(Console.ReadLine());

            int mucDienTieuThu = chisoMoi - chisoCu; // dien muc tieu thu
            int tienDinhMuc = 0; // tien phai tra trong dinh muc 
            int tienTraVuotDinhMuc = 0; // tien phai tra vuot dinh muc
            int tongTienPhaiTra = 0; // tong tien dien phai tra
            int mucDienTieuThuConLai = 0; // so dien con lai sau khi tru di cac phan dinh muc

            mucDienTieuThuConLai = mucDienTieuThu - 50; // tru di 50 so dien dinh muc
            if (mucDienTieuThuConLai >= 0)
            {
                // phan vuot dinh muc 1
                tienDinhMuc = tienDinhMuc + (50 * 1000);
                if (mucDienTieuThuConLai - 50 >= 0)
                {
                    // phan vuot dinh muc 2
                    tienTraVuotDinhMuc = tienTraVuotDinhMuc + (1500 * 50);
                    mucDienTieuThuConLai = mucDienTieuThuConLai - 50;
                    if (mucDienTieuThuConLai - 50 >= 0)
                    {
                        // phan vuot dinh muc 3
                        tienTraVuotDinhMuc = tienTraVuotDinhMuc + (1800 * 50);
                        mucDienTieuThuConLai = mucDienTieuThuConLai - 50;
                        tienTraVuotDinhMuc = tienTraVuotDinhMuc + (2500 * mucDienTieuThuConLai);
                    }
                    else
                    {
                        tienTraVuotDinhMuc = tienTraVuotDinhMuc + (mucDienTieuThuConLai * 1800);
                    }
                }
                else
                {
                    tienTraVuotDinhMuc = tienTraVuotDinhMuc + (mucDienTieuThuConLai * 1500);
                }
            }
            else
            {
                tienDinhMuc = tienDinhMuc + (mucDienTieuThu * 1000);
            }

            // output
            tongTienPhaiTra = tienTraVuotDinhMuc + tienDinhMuc;
            Console.WriteLine("Muc dien tieu thu la: " + mucDienTieuThu);
            Console.WriteLine("So tien phai tra trong dinh muc la: " + tienDinhMuc);
            Console.WriteLine("So tien phai tra vuot dinh muc la: " + tienTraVuotDinhMuc);
            Console.WriteLine("Tong so tien phai tra la: " + tongTienPhaiTra);
        }
    }
}