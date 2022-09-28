using System.Net.Security;

namespace BasicsQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, string> t1 = new Tuple<string, string>("Mario", "plumber");
            Character c1 = new Character(t1);
            Console.WriteLine("1st Experience: " + c1.UpdateExperience());
            Console.WriteLine("Updated Experience: " + c1.UpdateExperience());
            Console.WriteLine(c1.ToString());
        }
    }

    class Character
    {
        string name;
        string status;
        int experience;
        public Character(Tuple<string, string> attributes)
        {
            name = attributes.Item1;
            status = attributes.Item2;
            experience = 0;
        }
        public int UpdateExperience()
        {
            return experience += 1800;
        }

        //property
        public int Level
        {
            get
            {
                return (experience / 1000) + 1;
            }
        }

        public string ToString()
        {
            return "Name: " + name + ", Class: " + status + ", Level: " + Level;
        }

    }
}