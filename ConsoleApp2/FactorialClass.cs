using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FactorialClass
    {
        public int CalculateFact(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
