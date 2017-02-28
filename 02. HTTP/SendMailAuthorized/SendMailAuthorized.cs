namespace SendMailAuthorized
{
    using System;

    public class SendMailAuthorized
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Content-Type: text/html\n\r");
            Console.WriteLine("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <title>Welcome</title>\r\n</head>\r\n<body>\r\n <h1>Hello suAdmin</h1>\r\n\r\n <form action=\"SendMailAuthorized\" method=\"post\">\r\n     <p>\r\n         <label>To:</label>\r\n         <input type=\"text\" name=\"to\">\r\n\r\n     </p>\r\n     <p>\r\n         <label>Subject:</label>\r\n         <input type=\"text\" name=\"subject\">\r\n\r\n     </p>\r\n     <p>\r\n         <label>Message:</label>\r\n         <textarea name=\"message\"></textarea>\r\n     </p>\r\n         <button type=\"submit\">Send</button>\r\n </form>\r\n</body>\r\n</html>");
            string input = Console.ReadLine();

            if (input != null)
            {
                string[] data = input.Split(new[] {'=', '&'}, StringSplitOptions.RemoveEmptyEntries);
                string to = data[1].Replace("+", "");
                string subjec= data[3];
                string message = data[5];
            }
        }
    }
}
