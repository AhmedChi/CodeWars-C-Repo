using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class StringMethods : IStringMethods
    {
        public string Reverse(string word)
        {
            char[] charatarArray = word.ToCharArray();
            Array.Reverse(charatarArray);
            return new string(charatarArray);
        }
    }
}
