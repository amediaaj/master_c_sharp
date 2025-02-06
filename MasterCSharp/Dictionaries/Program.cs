using System.Net.Http.Headers;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };

            if (codes.TryGetValue("NY", out string state)) {
                Console.WriteLine(state);
            }
        }
    }
}
