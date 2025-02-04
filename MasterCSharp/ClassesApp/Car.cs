
namespace ClassesApp
{
    internal class Car
    {
        // member variable
        // private hides the variable from the  other classes

        //private string _model;
        private string _brand;
        private bool _isLuxury;

        // Custom Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine($"Object of type {this.GetType()} has been created");
            Console.WriteLine($"The model is : {Model} and the brand is {Brand}");
        }

        // Properties
        //public string Model { get => _model; set => _model = value; }
        public string Model { get; set; }

        public string Brand
        {
            get 
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                } else
                {
                    return _brand;
                }
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING!");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
            }
        }

        public  bool IsLuxury { get; set; }
        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        public void Drive()
        {
            Console.WriteLine("I'm driving");
        }
    }
}
