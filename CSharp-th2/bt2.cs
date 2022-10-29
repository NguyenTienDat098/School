/**
 Bai tap 2 chuong 2:  
    input : sale1, sale2, commissionRate
    output: comission = (sale1 + sale2) * commissionRate

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/


namespace bt2_Commission
{
    class bt2
    {
        static void Main()
        {
            // input
            Console.Write("Enter the value of sale1: ");
            double sale1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of sale2: ");
            double sale2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of commission Rate: ");
            double commissionRate = Convert.ToDouble(Console.ReadLine());

            // processing
            double totalSale = sale1 + sale2;
            double commission = totalSale * commissionRate;
            // output
            Console.WriteLine("Commistion: {0}", commission);
        }
    }
}
