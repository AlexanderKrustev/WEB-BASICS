namespace SendMail
{
    using System;
    using System.CodeDom;
    using System.Net.Http;
    using System.Runtime.Remoting.Messaging;

    public class SendMail
    {
        static void Main(string[] args)
        {
            string givenUserName = "suAdmin";
            string givenPassowrd = "aDmInPw17";
            Console.WriteLine("Content-Type: text/html\n\r");
            Console.WriteLine(
                "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <title>Login</title>\r\n</head>\r\n<body>\r\n<form action=\"SendMail.exe\" method=\"post\">\r\n   <p> <label>Username: </label>\r\n    <input type=\"text\" name=\"firstNumber\"></p>\r\n    <p><label>Password: </label>\r\n    <input type=\"password\" name=\"password\"><p>\r\n        <button type=\"submit\">Log in</button>\r\n</form>\r\n\r\n</body>\r\n</html>");
            string stream = Console.ReadLine();

            if (stream != null)
            {
                string[] input = stream.Split(new[] {'=', '&'}, StringSplitOptions.RemoveEmptyEntries);
                string username = input[1].Replace("+","");
                string password = input[3];
                if (username.Equals(givenUserName) && password.Equals(givenPassowrd))
                {
                    Console.WriteLine("<META HTTP-EQUIV=refresh CONTENT=\"1;URL=http://localhost:8080/cgi-bin/SendMailAuthorized.exe\">\n");

                }
                else
                {
                    Console.WriteLine("<p style=\"color:red;\">Incorrect username or password</p>\r\n</");
                }
            }
        }
    }
}
