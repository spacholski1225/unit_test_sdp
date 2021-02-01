using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console
{
    public class SpecialClass
    {
        public bool IsPalindrome(string stringAddedByUser)
        {
            stringAddedByUser = stringAddedByUser.Replace(" ", "");
            return stringAddedByUser.SequenceEqual(stringAddedByUser.Reverse());
        }
    }
}
