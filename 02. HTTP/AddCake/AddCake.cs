namespace AddCake
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class AddCake
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Content-Type: text/html\n\r");
            Console.WriteLine("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <title>AddCake</title>\r\n</head>\r\n<body>\r\n<p><a href=\"ByTheCake.exe\">Back to Home</a></p>\r\n    <form action=\"AddCake.exe\" method=\"post\">\r\n        <label>Cake Name</label>\r\n        <input  type=\"text\" name=\"name\">\r\n        <label>Price</label>\r\n        <input type=\"text\" name=\"price\">\r\n        <input type=\"submit\">\r\n    </form>\r\n\r\n\r\n</body>\r\n</html>");
            
            string[] input = Console.ReadLine().Split(new[] {'=', '&'}, StringSplitOptions.RemoveEmptyEntries);
            string name = input[1].Replace("+", " ");
            string price = input[3];
            Console.WriteLine("<p>Name:{0} <p>",name);
            Console.WriteLine("<p>Price:{0} <p>" ,price);
            var cake=new Cake(name,decimal.Parse(price));
            File.AppendAllText("database.csv", $"{cake.Name},{cake.Price}{Environment.NewLine}");


        }
    }
}
