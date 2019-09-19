using System;

namespace Methods_Deliv3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your First and Last name: ");
            Console.WriteLine("");
            Console.Write("Example: 'John Smith' ");
            Console.WriteLine("");
            Console.WriteLine("_____________________________________________________");
            try
            {
                //This variable will gather data from user input
                string input = Console.ReadLine();
                //Execute void method
                user(input);                
            }
            catch
            {
                Console.WriteLine("There was an error, please enter valid characters");
                Console.ReadKey(true);
            } //End of catch
        }

        private static void user(string input)
        {
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("Hello " + input + "!");
            Console.ReadKey(true);

        }
    }
}
