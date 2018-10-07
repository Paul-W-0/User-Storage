using System;
using System.Linq;
using System.Collections.Generic;

namespace userstorage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>names = new List<string> {  };
            Console.WriteLine("User Names (seperated by commas w/ space): ");
            string input_names = Console.ReadLine();
            names.Add(input_names);
            if (input_names.Contains(",")) // If input contains multiple users: 
            {  
                names = input_names.Split(", ").ToList();
                Console.WriteLine("Who are you looking for: ");
                string search = Console.ReadLine();
                 if (names.Contains(search)) // If the user specified does exist: 
                {
                    Console.WriteLine("Yes, the user exists....");
                }
                 else // If the user specified does not exist: 
                {
                    Console.WriteLine("No such user in the current directory....");
                }
            }
            else // If the list only contains one user: 
            {
                Console.Write(names);
            }
        }
    }
}