/**
 Bai tap 2 chuong 3:  
  Chuyen doi tu do F sang do C

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
namespace bt2
{
    class bt2
    {
        static void Main()
        {
            // input
            Console.Write("Nhap vao do F: ");
            double temperatureF = Convert.ToDouble(Console.ReadLine());

            // convert from degrees Fahrenheit to degrees Celsius
            double temperatureC = ((temperatureF - 32) * 5) / 9;
            // output 
            Console.WriteLine("{0} do F = {1} do C ", temperatureF, Math.Round(temperatureC, 2));
        }
    }
}