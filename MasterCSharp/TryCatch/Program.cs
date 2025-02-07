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
                int denominator = int.Parse(Console.ReadLine());
                double result = ThrowDemo.Divide(1, denominator);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DON'T DIVIDE BY ZERO!!! : " + e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("THAT NUMBER WAS WAY TOO BIG!!! " + e.Message);
            }
            catch (Exception e) 
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
         }
    }
}
