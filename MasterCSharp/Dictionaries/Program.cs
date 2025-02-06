using System.Net.Http.Headers;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // key - value
            // Declaring and initializing a Dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>();

            employees.Add(101, "John Doe");
            employees.Add(102, "Bob Smith");

            // access items ini a dictionary
            string name = employees[101];
            Console.WriteLine(name);
            
        }
    }
}
