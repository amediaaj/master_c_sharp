using System.Collections.Concurrent;
using System.Diagnostics;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int result = 0;

            Debug.WriteLine("A message hidden from the user");

            try
            {
                int num1, num2;
                Console.Write("Please enter a number: ");
                num1 = int.Parse(Console.ReadLine());
                num2 = 10;
                result = num2 / num1;
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.ToString());
                Console.WriteLine("Error: " + ex.Message);
                // Message hidden from user
                Debug.WriteLine(ex.ToString());
            }
            finally {
                // Useful for cleaning up, i.e. database connections, file streams, etc.
                Console.WriteLine("This alwasy executes");
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
