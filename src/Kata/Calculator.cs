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

            var numbersArray = s.Split(',');
            var sum = 0;
            foreach (var number in numbersArray)
            {
                sum += int.Parse(number);
            }
            return sum;
        }
    }
}