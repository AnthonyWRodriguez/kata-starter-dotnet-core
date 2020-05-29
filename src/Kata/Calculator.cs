using System;
using System.Linq;

namespace Kata.Spec
{
    public class Calculator
    {
        public int Add(string s=null)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var delimiter = "";
            var separator = new[]{",","\n"};
            var numbers = s;
            if (s.StartsWith("//"))
            {
                var parts = s.Split("\n");
                delimiter = parts[0].Replace("//", "");
                separator = new[] {delimiter};
                numbers = parts[1];
            }
            var numbersArray = numbers.Split(separator, StringSplitOptions.None).Select(int.Parse);
            
            return numbersArray.Sum();
            
        }
    }
}