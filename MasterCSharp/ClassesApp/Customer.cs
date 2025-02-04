
using System.ComponentModel;
using System.Reflection;

namespace ClassesApp
{
    internal class Customer
    {
        private static int nextId = 0;
        // Read-only instance field initialized from the constructor
        private readonly int _id;

        // Backing field for write-only property
        private string _password;

        // Compile time
        public const int numberOfSomething = 4;


        // Read-only property
        public int Id { get { return _id; } }
        // Write-only property
        public string Password { set => _password = value; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
     

        // Default Constructor
        public Customer()
        {
            _id = nextId++;
            Name = "New Customer";
            Address = "Unknown";
            ContactNumber = "None";
        }

        // Custom Constructor
        public Customer(string name, string address, string contactNumber)
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer(string name) 
        {
            _id = nextId++;
            Name = name;
        }

        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer: id:{_id}");
        }
    }
}
