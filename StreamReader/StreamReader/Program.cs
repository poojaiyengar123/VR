namespace StreamReaderProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = "/Users/poojaraghuram/Documents/GitHub/VR/StreamReader/StreamReader/MovieQuote.txt";

            try
            {
                using(StreamReader file = new StreamReader(path))
                {
                    int count = 0;
                    string line;

                    while ((line = file.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        count++;
                    }
                    file.Close();
                }
            }
            catch (Exception e)
            {
                Console.Write("Exception found");
            }
        }
    }
}
