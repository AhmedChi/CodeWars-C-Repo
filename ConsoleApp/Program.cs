using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IStringMethods stringMethods = new StringMethods();

            /* ProblemQ1 q1 = new ProblemQ1(stringMethods);
            string q1_phrase = "The quick brown fox jumps over the lazy dog.";
            q1.GreaterThan5(q1_phrase);*/

            ProblemQ2 q2 = new ProblemQ2();
            string q2_phrase = "Two words";
            q2.MexicanWave(q2_phrase);
            
            
            Console.ReadLine();

        }
    }
}
