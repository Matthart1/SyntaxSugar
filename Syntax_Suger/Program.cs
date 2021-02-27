using System;

namespace Syntax_Suger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");
            var input = int.Parse(Console.ReadLine());
            var responce = (input < 9)? " is less than nine.":
                " is greater than or equal to nine.";
            Console.WriteLine($"{ input}{ responce}");


        }
    }
}
