using System.Collections.Concurrent;
using System.Diagnostics;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double result = ThrowDemo.Divide(1, 0);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
         }
    }
}
