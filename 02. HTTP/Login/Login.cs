
namespace Login
{
    using System;

    public class Login
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Content-Type: text/html\n\r");
            Console.WriteLine(
                "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <title>Login</title>\r\n</head>\r\n<body>\r\n<form action=\"Login.exe\" method=\"post\">\r\n   <p> <label>Username: </label>\r\n    <input type=\"text\" name=\"firstNumber\"></p>\r\n    <p><label>Password: </label>\r\n    <input type=\"password\" name=\"password\"><p>\r\n        <button type=\"submit\">Log in</button>\r\n</form>\r\n\r\n</body>\r\n</html>");
            string stream = Console.ReadLine();

            if (stream != null)
            {
                string[] input = stream.Split(new[] {'=', '&'}, StringSplitOptions.RemoveEmptyEntries);
                string username = input[1];
                string password = input[3];
                Console.WriteLine(@"<p>Hi {0}, your password is: {1}</p>",username,password);
            }
        }
    }
}
