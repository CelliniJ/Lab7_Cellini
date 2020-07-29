using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;

namespace Lab7_Cellini
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeater = true;
            while (repeater == true)
            {
                Console.WriteLine("Please enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine(RegexName(name));

                Console.WriteLine("Please enter your e-mail:");
                string email = Console.ReadLine();
                Console.WriteLine(RegexEmail(email));

                Console.WriteLine("Please enter your phone number in the following format - xxx-xxx-xxxx:");
                string phonenumber = Console.ReadLine();
                Console.WriteLine(RegexPhoneNumber(phonenumber));

                Console.WriteLine("Please write a date based on the following format - dd/mm/yyyy:");
                string date = Console.ReadLine();
                Console.WriteLine(RegexDate(date));

                Console.WriteLine("Please enter HTML elements:");
                string HTML = Console.ReadLine();
                Console.WriteLine(RegexHTML(HTML));
            }

        }

        public static string RegexName(string name)
        {
            if (Regex.IsMatch(name, @"\b[A-Z]{0,29}[A-z]{0,29}\b"))
            {
                string namereturn = "Good name.";
                return namereturn;
            }
            else
            {
                string namereturn = "Bad name.";
                return namereturn;
            }
        }

        public static string RegexEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[0-z]{5,30}[@][0-z]{5,10}[.][0-z]{2,3}$"))
            {
                string emailreturn = "Good e-mail.";
                return emailreturn;
            }
            else
            {
                string emailreturn = "Bad e-mal.";
                return emailreturn;
            }
        }

        public static string RegexPhoneNumber(string phonenumber)
        {
            if(Regex.IsMatch(phonenumber, @"^[0-9]{3}[-][0-9]{3}[-][0-9]{4}$"))
            {
                string numreturn = "Good phone number.";
                return numreturn;
            }
            else
            {
                string numreturn = "Bad phone number.";
                return numreturn;
            }
        }

        public static string RegexDate(string date)
        {
            if (Regex.IsMatch(date, @"^[0-9]{2}[/][0-9]{2}[/][0-9]{4}$"))
            {
                string datereturn = "You're good.";
                return datereturn;
            }
            else
            {
                string datereturn = "Bad input, buddy.";
                return datereturn;
            }
        }

        public static string RegexHTML(string HTML)
        {
            if (Regex.IsMatch(HTML, "<div.*?>(.*?)<\\/div>"))
            {
                string HTMLreturn = "Good HTML.";
                return HTMLreturn;
            }
            else
            {
                string HTMLreturn = "Bad HTML.";
                return HTMLreturn;
            }

        }
    }
}
