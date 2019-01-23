using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                EmailMethod();
                PasswordMethod();
                run = Continue();
            }
        }

       public static void EmailMethod()
        {
            bool run = true;
            
            while (run == true)
            {
                List<string> Email = new List<string>();
                Console.WriteLine("Please enter a valid email");
                string userEmail = Console.ReadLine();
                
                try
                {
                    if (Regex.IsMatch(userEmail, @"^[A-z0-9]{3,30}@[a-z]{3,10}.[a-z]{2,3}$"))
                    {
                        Console.WriteLine("Email added");
                        Email.Add(userEmail);
                        run = false;
                    }

                    else
                    {
                        Console.WriteLine("That was not a valid email, try again");
                    }

                }

                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid email, try again");               
                }
            }       
        }

        public static void PasswordMethod()
        {
            bool run = true;
            while (run == true)
            {
                List<string> Password = new List<string>();
                Console.WriteLine("Please enter your password");
                string userPassword = Console.ReadLine();
                

                try
                {
                    if (Regex.IsMatch(userPassword, @"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{5,}$"))
                    {
                        Console.WriteLine("Your password was added");
                        Password.Add(userPassword);
                        run = false;
                    }

                    else
                    {
                        Console.WriteLine("That was not a valid password, your password must ");
                    }

                }

                catch (FormatException)
                {

                }

            }
            Console.WriteLine("Your information has been\"safely\"stored");
        }

        public static bool Continue()
        {
            Console.WriteLine("Would you like to run this program agian?(y/n)");
            string input = Console.ReadLine().ToLower();
            bool stuff;
            if (input == "y")
            {
                stuff = true;
            }
            else if (input == "n")
            {
                stuff = false;
            }
            else
            {
                Console.WriteLine("Sorry I didn't catch that.");
                stuff = Continue();
            }

            return stuff;
        }

    }
}
