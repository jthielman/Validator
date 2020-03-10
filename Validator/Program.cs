using System;
using System.Text.RegularExpressions;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whatcha got for me?");
            var input = Console.ReadLine();
            var pinRegex = new Regex(@"^\d{4,8}$");
            var phoneRegex = new Regex(@"^(\+0?1\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$");
            var emailRegex = new Regex(@"^(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@)(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            var sbRegex = new Regex(@"^(([a-z][A-Z]|[a-z])+|([A-Z][a-z]|[A-Z])+)$");
            Console.WriteLine("{0} {1} a valid pin.", input, pinRegex.IsMatch(input) ? "is" : "is not");
            Console.WriteLine("{0} {1} a valid phone number.", input, phoneRegex.IsMatch(input) ? "is" : "is not");
            Console.WriteLine("{0} {1} a valid email address.", input, emailRegex.IsMatch(input) ? "is" : "is not");
            Console.WriteLine("{0} {1} a valid Spongebob mock.", input, sbRegex.IsMatch(input.Replace(" ", "")) ? "is" : "is not");

            switch (input)
            {
                case "Jason Lee Scott":
                    Console.WriteLine($"{input} is a valid Power Ranger.");
                    break;
                case "Zack Taylor":
                    Console.WriteLine($"{input} is a valid Power Ranger.");
                    break;
                case "Trini Kwan":
                    Console.WriteLine($"{input} is a valid Power Ranger.");
                    break;
                case "Kimberly Ann Hart":
                    Console.WriteLine($"{input} is a valid Power Ranger.");
                    break;
                case "Billy Cranston":
                    Console.WriteLine($"{input} is a valid Power Ranger.");
                    break;
                case "Tommy Oliver":
                    Console.WriteLine($"{input} is a valid Power Ranger.");
                    break;
                case "Rocky DeSantos":
                    Console.WriteLine($"{input} is a valid Power Ranger.");
                    break;
                case "Aisha Campbell":
                    Console.WriteLine($"{input} is a valid Power Ranger.");
                    break;
                case "Adam Park":
                    Console.WriteLine($"{input} is a valid Power Ranger.");
                    break;
                case "Tom Oliver":
                    Console.WriteLine($"{input} is a valid Power Ranger.");
                    break;
                case "Katherine Hillard":
                    Console.WriteLine($"{input} is a valid Power Ranger.");
                    break;
                default:
                    Console.WriteLine($"{input} is not a valid Power Ranger.");
                    break;
            }

            //input.ToLower();
            char[] charArray = input.ToLower().ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new string(charArray);
            Console.WriteLine("{0} {1} a valid palindrome.", input, reversedInput == input.ToLower() ? "is" : "is not");
            Console.ReadLine();
        }
    }
}
