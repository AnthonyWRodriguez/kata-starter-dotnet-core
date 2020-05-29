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

            var numbersArray = s.Split(',').Select(int.Parse);
            return numbersArray.Sum();
            
        }
    }
}