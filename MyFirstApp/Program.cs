using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);
            
            // readline = reads the line
            Console.ReadLine();

            // in c# it's already type safe, so double equal signs are equivalent to triple equals in js because can't compare different types of strings
            if (userEntry == "poo")
            {
                Console.WriteLine("you are poo");
            }
            else
            {
                Console.WriteLine("you are not poo");
            }

            var i = 0;
            while (i < 10)
            {
                Console.WriteLine($"Current value of i is {i++}...");
            }

            for (var j = 0; j < 10; j++)
            {
                Console.WriteLine($"Current value of j is {j}...");
            }

            // it will loop over what thing is made of. 'continue' means move iterate the next thing in the loop
            foreach (var currentChar in userEntry)
            {
                if (currentChar == 'p' || currentChar == 'P')
                {
                    continue;
                }
                Console.WriteLine($"the current character is {currentChar}");
            }

            //  goes to default if it does not match anything else. Case are like 'ifs' and default like 'else'. Can have multiple cases if want to do the same thing 
            switch (userEntry)
            {
                case "poo":
                    Console.WriteLine("poo poo");
                    break;
                default:
                    Console.WriteLine("not poo");
                    break;
            }

            var isPoo = userEntry == "poo" ? true : false;

            // to catch errors. Problem will happen in try and will be caught in 'catch'. throw will re-throw Exception to console. If try to keep going without resolving, will crash entire application
            try
            {
                var y = 0;
                var x = 1 / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
