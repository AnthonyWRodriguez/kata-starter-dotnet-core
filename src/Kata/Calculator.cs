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
            return int.Parse(s);
        }
    }
}