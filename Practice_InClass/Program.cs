using System;

namespace Practice_InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");

            try
            {
                string input = Console.ReadLine();
                Console.WriteLine("Hello " + input + ".");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey(true);
            }//end of try

            catch
            {
                Console.WriteLine("Please enter a valid name!");
                Console.WriteLine("Pelase exit and try again.");
                Console.ReadKey(true);
            }//end of catch
                ;
        }
    }
}
