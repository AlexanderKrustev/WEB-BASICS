namespace BrowseCakes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using AddCake;

    public class BrowseCakes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Content-Type: text/html\n\r");
            Console.WriteLine("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <title>Browse Cakes</title>\r\n</head>\r\n<body>\r\n<p><a href=\"ByTheCake.exe\">Back to home</a></p>\r\n    <form action=\"BrowseCakes.exe\" method=\"get\">\r\n        <label>Name</label>\r\n        <input type=\"text\" name=\"search\">\r\n        <button type=\"submit\">Search</button>\r\n    </form>\r\n</body>\r\n</html>");
            List<Cake> cakes=new List<Cake>();
            var query = Environment.GetEnvironmentVariable("QUERY_STRING");
            string[] input = query.Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries);
            string searchCriteria = input[1];
           

            using (var reader = new StreamReader("database.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] cakeInfo = line.Split(',');
                    string name = cakeInfo[0];
                    decimal price = decimal.Parse(cakeInfo[1]);
                    var cake = new Cake(name, price);
                    
                    cakes.Add(cake);
                }
            }

            var result = cakes.Where(c => c.Name.ToLower().Contains(searchCriteria));

            foreach (var cake in result)
            {
                Console.WriteLine(@"<p>{0} {1}</p>", cake.Name, cake.Price);
            }
        }
    }
}
