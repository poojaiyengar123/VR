namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> teachers = new Dictionary<string, string>();
            teachers.Add("Data Structures", "Dentler");
            teachers.Add("VR", "Trainor");
            teachers.Add("Psychology", "McGinley");
            teachers.Add("Artificial Intelligence", "Schiff");
            teachers.Add("Gym", "Boehm");
            teachers.Add("Math", "King");
            teachers.Add("French", "Ghobrial");
            teachers.Add("English", "Noebels");
            teachers.Add("Science", "Burnett");
            teachers.Add("Art", "Castaldo");

            FindSubjects(teachers, "Science");
            FindSubjects(teachers, "Math");
            FindSubjects(teachers, "Art");
        }
        static void FindSubjects(Dictionary<string, string> teachers, string subject)
        {
            foreach(KeyValuePair<string, string> kvp in teachers)
            {
                if (kvp.Key == subject)
                    Console.WriteLine(subject + ": " + kvp.Value);
            }
        }
    }
}