using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.FaultyOdometer
{
    public class OdometerCalculator
    {
        public int CalculateOdometerRealDistance(int currentMiles)
        {
            if (currentMiles < 1)
                throw new ArgumentException(null, nameof(currentMiles));

            var realCurrentMiles = 0;

            for(var x = 0; x < currentMiles; x++)
            {
                if (!x.ToString().Contains('4'))
                    realCurrentMiles++;

            }

            return realCurrentMiles;
        }
    }
}
