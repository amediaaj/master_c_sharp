using System.Collections.Concurrent;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int result = 0;

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
            }
            finally {
                
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
