namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a list and initializing
            List<string> colors = ["red", "blue", "green", "red"];

            //List<string> colors = new List<string>
            //{
            //    "red",
            //    "blue",
            //    "green",
            //    "red"
            //};

            foreach (string color in colors)
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

            // Array vs curly brace notation
            List<int> numbers = [10, 5, 15, 3, 9];
            //List<int> numbers = new List<int> { 10, 5, 15, 3, 9 };
            numbers.Sort();
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            numbers.Reverse();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
