# ShRest.cs
Web-API for [shrekofficial.com](https://shrekofficial.com/) a Shrek REST API

## Example
```cs
using ShRestApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new ShRest();
            string quote = await api.GetRandomQuote();
            Console.WriteLine(quote);
        }
    }
}
```
