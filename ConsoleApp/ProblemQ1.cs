using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class ProblemQ1
    {
        private readonly IStringMethods _stringMethods;

        public ProblemQ1(IStringMethods myStringMethods)
        {
            _stringMethods = myStringMethods;
        }

        public void GreaterThan5(string phrase)
        {
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            { 
                if (word.Length >= 5)
                {
                    string reversedWord = _stringMethods.Reverse(word);
                    Console.WriteLine($"{reversedWord}");
                }
                else
                {
                    Console.WriteLine($"{word}");
                }
            }
        }

        
            
    }
}
