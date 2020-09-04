using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class ProblemQ2
    {
        public List<string> MexicanWave(string word)
        {
            List<string> mexWaveList = new List<string>() { };

            if (word.Length == 0)
            {
                Console.WriteLine("No phrase entered");

                return mexWaveList;
            }
            else
            {

                for (var i = 0; i < word.Length; i++)
                {
                    string capLetter = word[i].ToString().ToUpper();

                    if (capLetter != " ")
                    {
                        mexWaveList.Add(word.Remove(i, 1).Insert(i, capLetter));
                    }
                        
                }

                mexWaveList.ForEach(a =>
                {
                    Console.WriteLine(a);
                });

                return mexWaveList;
            }
                           
        }
    }
}

