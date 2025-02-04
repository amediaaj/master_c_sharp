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
            Console.WriteLine();

            // Array vs curly brace notation
            List<int> numbers = [10, 5, 15, 3, 9, 25, 18];
            //List<int> numbers = new List<int> { 10, 5, 15, 3, 9 };

            // THis will return a list of numbers that are 10 an higher
            List<int> greaterThanEqualTen =  numbers.FindAll(x => x >= 10);
            Console.WriteLine("All number 10 or greater: ");
            foreach(int number in greaterThanEqualTen) { Console.WriteLine(number); }
            Console.WriteLine();
        }
    }
}
