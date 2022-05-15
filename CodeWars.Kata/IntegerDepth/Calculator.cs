using System.Collections.Generic;

namespace CodeWars.Kata.IntegerDepth
{
    public class Calculator
    {
        public int ComputeDepth(int number)
        {
            if (number < 1)
                throw new System.ArgumentException(null, nameof(number));

            var multiplier = 1;
            var digits = new HashSet<char>();

            while (digits.Count < 10) {

                var result = (number * multiplier).ToString();

                foreach(var digit in result)
                {
                    digits.Add(digit);
                }

                multiplier++;

            }

            return multiplier - 1;
        }
    }
}
