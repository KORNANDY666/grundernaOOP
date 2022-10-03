namespace grundernaOOP                                     // Andreas Blom YH.Net-22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates 3 different circles with different radius values ​​to calculate the area and volume


            Circle circle = new Circle(5);
            Circle circle2 = new Circle(6);
            circle.getArea();
            circle2.getArea();


            Circle circle3 = new Circle(11);
            circle3.getVolume();
        }
    }
}