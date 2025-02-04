// Parse a number from a string
//Console.WriteLine(int.Parse(Console.ReadLine()));

// String formatting
int num = 10;
double price = 19.95;
Console.WriteLine("The number is {0}, and the price is {1}", num, price);
string myString = $"hello {price}";

// TryParse
int result;
bool success = int.TryParse(Console.ReadLine(), out result);
// if (success) { } ...