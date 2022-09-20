using System.Collections.Generic;

namespace EquilateralPolygon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Square shape1 = new Square(4, 5);
            Square shape2 = new Square(4, 7);
            Square shape3 = new Square(4, 2);
            List<Square> list = new List<Square>();
            list.Add(shape1);
            list.Add(shape2);
            list.Add(shape3);

            int perimeter = 0;
            int area = 0;
            int count = 0;
            int index = 0;
            foreach (var x in list)
            {
                perimeter += x.GetPerimeter();
                if (x.GetArea() > area)
                {
                    area = x.GetArea();
                    index = count;
                }
                count++;
            }

            Console.WriteLine("Sum of Perimeters: " + perimeter);
            Console.WriteLine("Index of Polygon with Largest Area: " + index + ", Area: " + area);
        }
    }
    public class EquilateralPolygon
    {
        public int sides;
        public int sideLengths;

        public EquilateralPolygon(int s, int sl)
        {
            sides = s;
            sideLengths = sl;
        }
    }
    public class Square : EquilateralPolygon
    {
        int area;
        int perimeter;

        public Square(int sides, int sideLengths) : base(4, sideLengths)
        {
            GetArea();
            GetPerimeter();
        }
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