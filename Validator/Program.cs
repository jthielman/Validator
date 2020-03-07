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
            var sbRegex = new Regex(@"^(?([a-z])([a-z]\W*[A-Z]\W*)+|([A-Z]\W*[a-z]\W*)+)+$");
            var rangerRegex = new Regex(@"^$");
            var palindromeRegex = new Regex(@"^$");
            Console.WriteLine("{0} {1} a valid pin.", input, pinRegex.IsMatch(input) ? "is" : "is not");
            Console.WriteLine("{0} {1} a valid phone number.", input, phoneRegex.IsMatch(input) ? "is" : "is not");
            Console.WriteLine("{0} {1} a valid email address.", input, emailRegex.IsMatch(input) ? "is" : "is not");
            Console.WriteLine("{0} {1} a valid Spongebob mock.", input, sbRegex.IsMatch(input) ? "is" : "is not");
            Console.WriteLine("{0} {1} a valid Power Ranger.", input, rangerRegex.IsMatch(input) ? "is" : "is not");
            Console.WriteLine("{0} {1} a valid palindrome.", input, palindromeRegex.IsMatch(input) ? "is" : "is not");
            Console.ReadLine();
        }
    }
}
