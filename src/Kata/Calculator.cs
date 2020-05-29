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

            var numbersArray = s.Split('\n');
            var allNumbers = 0;
            foreach (var element in numbersArray)
            {
                allNumbers += element.Split(',').Select(int.Parse).Sum();
            }

            return (allNumbers);
            
        }
    }
}