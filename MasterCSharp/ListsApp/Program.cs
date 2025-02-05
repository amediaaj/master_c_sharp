

namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array can also call Where() and return IEnumerable
            //int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            //List<int> lessThanSix = numArray.Where(p  => p <= 5).ToList();
            //foreach (int num in lessThanSix) {
            //    Console.WriteLine(num);
            //}
            
            List<Product> products = new List<Product>
            {
                new Product { Name = "Apple", Price = 0.90},
                new Product { Name = "Banana", Price = 0.30 },
                new Product { Name = "Cherry", Price = 3.80 },
            };

            products.Add(new Product { Name = "Berries", Price = 2.99 });

            Console.WriteLine("Available Products: ");
            foreach (Product product in products) {
                Console.WriteLine($"{product.Name}: {product.Price}");
            }

            // Returns IEnumerable so we convert to List
            // Where() is from 
            List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();
        }
    }
}
