namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("FrankTheTank", "1 Mainstreet", "555-555-5555");
            Console.WriteLine($"Name of customer is {earl.Name}");
            Console.WriteLine($"Name of customer is {frankTheTank.Name}, address is {frankTheTank.Address}, and phone is {frankTheTank.ContactNumber}");
        }
    }
}
