namespace Calculator
{
    using System;
    using System.Runtime.InteropServices;

    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Content-Type: text/html\n\r");
            Console.WriteLine("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <title>Calculator</title>\r\n</head>\r\n<body>\r\n  <form action=\"Calculator.exe\" method=\"post\">\r\n      <input type=\"text\" name=\"firstNumber\">\r\n      <input type=\"text\" name=\"sing\">\r\n      <input type=\"text\" name=\"secondNumber\">\r\n      <button type=\"submit\">Calculate</button>\r\n  </form>\r\n\r\n</body>\r\n</html>");
            string stream = Console.ReadLine();

            if (stream != null)
            {
                string[] input = stream.Split(new[] {'=', '&'}, StringSplitOptions.RemoveEmptyEntries);
                double num1 = double.Parse(input[1]);
                string sing = input[3];
                double num2 = double.Parse(input[5]);
             
                switch (sing)
                {
                    case "%2B":
                        Console.WriteLine(num1+num2);
                        break;
                    case "-":
                        Console.WriteLine(num1-num2);
                        break;
                    case "*":
                        Console.WriteLine(num1* num2);
                        break;
                    case "%2F":
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Incorrect Sing");
                        break;
                }
              
            }
            
        }
    }
}
