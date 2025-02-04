namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a list and initializing
            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            colors.Add("red");

            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();

            // Rmove() returns bool
            Console.WriteLine(colors.Remove("red"));

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
