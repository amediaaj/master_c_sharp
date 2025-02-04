namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myAudi = new Car("A3", "Audi", false);
            myAudi.Drive();

            Customer customer1 = new Customer();
            customer1.GetDetails();

            Customer customer2 = new Customer();
            customer2.GetDetails();

            // Read-only
            Console.WriteLine($"customer1 Id: {customer1.Id}");
            // Write-only
            customer1.Password = "password";
        }
    }
}
