namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myAudi = new Car("A3", "Audi", false);
            myAudi.Drive();

            Customer myCustomer = new Customer();
            // Calling SetDetails with default param
            myCustomer.SetDetails("Alex", "1 Main Street");
            Console.WriteLine($"Name is {myCustomer.Name} and Phone is {myCustomer.ContactNumber}");

            // Named params
            //Console.WriteLine(AddNum(2, firstNum: 25);
        }
    }
}
