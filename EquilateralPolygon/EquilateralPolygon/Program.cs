namespace EquilateralPolygon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            string value = square.ToString();
            Console.WriteLine(value);
        }
    }
    public class EquilateralPolygon
    {
        public int sides = 4;
        public int sideLengths = 5;
    }
    public class Square : EquilateralPolygon
    {
        int area;
        int perimeter;

        public int GetArea()
        {
            area = sideLengths * sideLengths;
            return area;
        }
        public int GetPerimeter()
        {
            perimeter = sides * sideLengths;
            return perimeter;
        }
        public string ToString()
        {
            return "Area: " + GetArea() + ", Perimeter: " + GetPerimeter();
        }
    }
}