using System;

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
