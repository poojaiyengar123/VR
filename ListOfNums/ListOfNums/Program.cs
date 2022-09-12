using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ListOfNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = BuildList();
 
            foreach(var y in list)
                Console.WriteLine(y);

            Tuple<double,int> myTuple = FindAvg_Total(list);
            Console.WriteLine();
            Console.WriteLine("Average: " + myTuple.Item1);
            Console.WriteLine("Total Number of Values: " + myTuple.Item2);
            Console.WriteLine();

            string s1, s2, s3, s4;
            Console.WriteLine("Enter a string: ");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter another string: ");
            s2 = Console.ReadLine();
            Console.WriteLine("Enter a third string: ");
            s3 = Console.ReadLine();
            Console.WriteLine("Enter a fourth string: ");
            s4 = Console.ReadLine();
            Console.WriteLine(s1 + "," + s2 + "," + s3 + "," + s4);

            List<Tuple<string, int>> strings = FindLongestStrings(s1, s2, s3, s4);
            foreach(var x in strings)
            {
                Console.WriteLine(x.Item1 + ", " + x.Item2);
            }

        }

        static List<int> BuildList()
        {
            List<int> list = new List<int>();
            int x = 1;
            while (list.Count < 500)
            {
                if (FindNum(x) == true)
                {
                    list.Add(x);
                }
                x++;
            }
            return list;
        }

        static bool FindNum(int x)
        {
            if (x % 2 == 0 && x % 3 == 0 && x % 10 != 0)
            {
                return true;
            }
            return false;
        }

        static Tuple<double, int> FindAvg_Total(List<int> list)
        {
            double avg = 0;
            int nums = 0;
            foreach (int x in list)
            {
                nums++;
                avg += x;
            }
            avg /= nums;
            Tuple<double, int> myTuple = new Tuple<double, int>(avg, nums);
            return myTuple;
        }
        static List<Tuple<string, int>> FindLongestStrings(string s1, string s2, string s3, string s4)
        {
            string longest;
            string longest2;
            int s1Len = s1.Length;
            int s2Len = s2.Length;
            int s3Len = s3.Length;
            int s4Len = s4.Length;

            if (s1Len > s2Len)
            {
                longest = s1;
                longest2 = s2;
            }
            else
            {
                longest = s2;
                longest2 = s1;
            }

            if (s3Len > s1Len)
            {
                longest2 = longest;
                longest = s3;
            }
            else
            {
                if (s3Len > s2Len)
                    longest2 = s3;
            }

            if (s4Len > longest.Length)
            {
                longest2 = longest;
                longest = s4;
            }
            else
            {
                if (s4Len > longest2.Length)
                    longest2 = s4;
            }
            Tuple<string, int> tup1 = new Tuple<string, int>(longest, longest.Length);
            Tuple<string, int> tup2 = new Tuple<string, int>(longest2, longest2.Length);
            List<Tuple<string, int>> strings = new List<Tuple<string, int>>();
            return strings;
        }
    }
}