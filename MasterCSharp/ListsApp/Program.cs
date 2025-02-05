namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            // Array vs curly brace notation
            List<int> numbers = [10, 5, 15, 3, 9, 25, 18];

            if (numbers.Any(x => x > 20))
            {
                Console.WriteLine("There are large numbers!");
            }
            else {
                Console.WriteLine("No large numbers!");
            }
        }
    }
}
