/**
 Bai tap 3 chuong 2:  
   Viet chuong trinh cho phep nguoi dung nhap vao nam sinh
   - Tinh tuoi hien tai
   - Tinh nam ve huu (biet tuoi ve huu la 60 tuoi)

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/


namespace bt3
{
    class bt3
    {
        static void Main()
        {
            // declare variable
            const double CURRENT_YEAR = 2022; // bien luu nam hien tai
            const double RETIRED_AGE = 60; // bien luu tuoi ve huu
            // input
            Console.Write("Enter your year of birth: ");
            double yearOfBirth = Convert.ToDouble(Console.ReadLine());
            // processing
            double currentAge = CURRENT_YEAR - yearOfBirth; // tuoi hien tai
            double yearToRetire = CURRENT_YEAR + (RETIRED_AGE - currentAge); // nam ve huu

            // output
            Console.WriteLine("Current Age: {0}", currentAge);
            Console.WriteLine("Year to retire: {0}", yearToRetire);

        }
    }
}
