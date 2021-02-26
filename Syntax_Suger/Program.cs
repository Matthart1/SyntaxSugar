using System;

namespace Syntax_Suger
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var responce = (answer < 9)? " is less than nine.":
                " is greater than or equal to nine.";
            Console.WriteLine($"{ answer}{ responce}");


        }
    }
}
