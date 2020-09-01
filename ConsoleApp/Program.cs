using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IStringMethods stringMethods = new StringMethods();

            ProblemQ1 q1 = new ProblemQ1(stringMethods);
            string phrase = "The quick brown fox jumps over the lazy dog.";
            q1.GreaterThan5(phrase);

            
            
            
            Console.ReadLine();

        }
    }
}
