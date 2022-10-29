/**
 Bai tap 3 chuong 3:  
  Nhap vao diem toan, ly, hoa 
  tinh diem trung binh

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
namespace bt3
{
    class bt3
    {
        static void Main()
        {
            // input
            Console.Write("Enter value of chemistry score: ");
            // diem hoa
            double chemistryScore = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of math score: ");
            // diem toan
            double mathScore = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of physical score: ");
            // diem ly
            double physicalScore = Convert.ToDouble(Console.ReadLine());

            // output diem trung binh
            double mediumScore = (chemistryScore + mathScore + physicalScore) / 3;
            Console.WriteLine("Medium Score: {0}", Math.Round(mediumScore, 2));
        }
    }
}