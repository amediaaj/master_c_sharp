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
            employees.Add(103, "Rob Smith");
            employees.Add(104, "Flob Smith");
            employees.Add(105, "Dob Smith");


            // access items in a dictionary
            string name = employees[101];
            Console.WriteLine(name);

            // update data in a dictionary
            employees[102] = "Jane Smith";

            //employees.Remove(101);
            // bool added = employees.TryAdd(102, "Cassidy Hare");

            if(!employees.ContainsKey(104))
            {
                employees.Add(104, "Mike Jike");
            }

            // Adding by checking if key exists
            int counter = 101;
            while (employees.ContainsKey(counter)) {
                counter++;
            }
            employees.Add(counter, "Alex Amedia");


            // TryAdd with incrementing counter
            counter = 101;
            while (!employees.TryAdd(counter++, "Cassidy Hare")) ;

            foreach(KeyValuePair<int, string> kvp in employees)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            
        }
    }
}
