/**
 Bai tap 6 chuong 2:  
   Quy doi tien te

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
namespace bt6
{
    class bt6
    {
        static void TranferMoney(int type, double amountOfMoney)
        {

            const double FEES_POUND = 0.8144;
            const double FEES_YEN = 105.407;
            const double FEES_VN = 23160;
            //
            switch (type)
            {
                case 1:
                    {
                        Console.WriteLine("Tranfer from USD -> Pound: ");
                        Console.Write("{0} USD = {1} Pound", amountOfMoney, amountOfMoney * FEES_POUND);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Tranfer from USD -> Yen: ");
                        Console.Write("{0} USD = {1} YEN", amountOfMoney, amountOfMoney * FEES_YEN);
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Tranfer from USD -> VN: ");
                        Console.Write("{0} USD = {1} VND", amountOfMoney, amountOfMoney * FEES_VN);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        static void Main()
        {

            Console.WriteLine("---- Tranfer Service ----");
            Console.WriteLine("1. Tranfer from USD to POUND");
            Console.WriteLine("2. Tranfer from USD to YEN");
            Console.WriteLine("3. Tranfer from USD to VND");

            // input
            Console.Write(">> Please Chose service: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write(">> Enter your amount of money: ");
            double money = Convert.ToDouble(Console.ReadLine());

            // procssing and output
            TranferMoney(choose, money);
        }
    }
}
