using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class StringMethods : IStringMethods
    {
        string IStringMethods.Reverse(string word)
        {
            char[] charatarArray = word.ToCharArray();
            Array.Reverse(charatarArray);
            return new string(charatarArray);
        }
    }
}
