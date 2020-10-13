using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Josephus
{
    public class JosephusSolver
    {
        public int Solve(int numberOfPeople, int killingInterval)
        {
            if (killingInterval == 1) return numberOfPeople;
            if (killingInterval == 2)
            {
                return Enumerable.Range(1, numberOfPeople).Where(number => number % 2 > 0).Max();
            }
            

            return numberOfPeople;
        }
    }
}
