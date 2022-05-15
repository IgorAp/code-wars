using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.TribonacciSequence
{
    public class Xbonacci
    {
        public double[] CaculateTribonacci(double[] input, int numberOfElements)
        {
            var result = new List<double>(input);

            for(var x = result.Count; x<numberOfElements; x++)
            {
                var value = result[x-1] + result[x - 2] + result[x - 3];
                result.Add(value);
            }

            return result.ToArray();
        }

    }
}
