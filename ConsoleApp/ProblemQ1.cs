using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class ProblemQ1 : StringMethods
    {
        StringMethods myStringMethodds = new StringMethods();

        myStringMethodds.

        string phrase = "The quick brown fox jumps over the lazy dog.";
            
        string GreaterThan5(string phrase)
        {
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                if (word.Length >= 5)
                {
                    string reversedWord = Reverse(word);
                    return reversedWord;
                }
                else
                {
                    return word;
                }
            }

            return word;
        }

        
            
    }
}
