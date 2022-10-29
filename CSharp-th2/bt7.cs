// ASCII => https://globalcastingresources.com/wp-content/uploads/2019/05/bang-ma-ascii_050045.png
/**
 Bai tap 7 chuong 2:  
   Ascii

 Name: Nguyen Tien Dat
 Date: 29/10/2022
*/
namespace bt7
{
    class bt7
    {
        static void Main()
        {
            // input
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());
            int number = 0;
            number = (int)ch;

            // output
            Console.WriteLine("Ascii of {0}: {1}", ch, number); // Ascii of current character
            char newChar = (char)(number + 1); // Get ascii of next character
            Console.WriteLine("Next charecter: {0}", newChar); // Next character
        }
    }
}
