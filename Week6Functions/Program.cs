using System;

namespace Week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //call a function
            SumOf2Numbers();
        }

        public static void HelloUser() //create a function 
        {
            Console.WriteLine("Enter your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }

        public static void SumOf2Numbers()
        {
            Console.WriteLine("Enter a number: ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int number2 = Int32.Parse(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine(sum);
        }
    }
}
