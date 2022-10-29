/**
 Bai tap 6 chuong 4:  
   Viet chuong trinh nhap vao diem 3 mon: toan, ly, hoa
   - Tinh tong diem 
   - Kiem tra xem dau hay rot
    + "Dau neu khong co mon < 4 va tong >= 15"
        Neu dau ma toan, ly, hoa deu >= 5 in ra "Hoc deu cac mon" 
        Nguoc lai in ra "Hoc chua deu cac mon" 
    + Con lai in ra "Thi hong"

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
using System;

namespace c4
{
    public class bt
    {
        static void Main()
        {
            // input
            System.Console.Write("Nhap vao diem toan: ");
            double diemToan = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Nhap vao diem hoa: ");
            double diemHoa = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Nhap vao diem ly: ");
            double diemLy = Convert.ToDouble(Console.ReadLine());

            double total = diemHoa + diemToan + diemLy;

            // processing and output
            if (total >= 15 && diemToan >= 4 && diemLy >= 4 && diemHoa >= 4)
            {
                if (diemToan > 5 && diemLy > 5 && diemHoa > 5)
                {
                    System.Console.WriteLine("Hoc deu cac mon");
                }
                else
                {
                    System.Console.WriteLine("Hoc chua deu cac mon");
                }
            }
            else
            {
                System.Console.WriteLine("Thi hong");
            }

        }
    }
}