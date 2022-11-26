/**
 Bai tap 1 chuong 2: Tinh chu vi , dien tich cua hinh tron
 Name: Nguyen Tien Dat
 Date: 29/10/2022
 https://slidesgo.com/theme/social-issues-thesis-poverty-and-homelessness#search-famous+people&position-1&results-67&rs=search
 https://slidesgo.com/theme/people-diversity-website-design#search-famous+people&position-42&results-67&rs=search
*/


namespace bt1
{
    class Circle
    {

        // khai bao bien
        const double PI = 3.14;
        // ham tinh chu vi 
        public double perimeter(double R)
        {
            return 2 * R * PI;
        }
        // ham tinh dien tich
        public double area(double R)
        {
            return R * R * PI;
        }
    }
    class bt1
    {
        static void Main()
        {
            // input
            Console.Write("Nhap vao ban kinh cua hinh tron: ");
            double radius = Convert.ToDouble((Console.ReadLine()));
            // output
            Console.Write("Chu vi cua hinh tron la: {0} \n", Math.Round(new Circle().perimeter(radius), 2));
            Console.Write("Dien tich cua hinh tron la: {0}", Math.Round(new Circle().area(radius), 2));
        }
    }
}
