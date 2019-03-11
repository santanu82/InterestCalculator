using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryCalculator;

namespace InterestCalculator
{
    public class InterestCalculatorService: InterestCalculatorServiceBase
    {
        /// <summary>
        /// Calculates the interest.
        /// </summary>
        /// <param name="balance">The balance.</param>
        /// <returns></returns>
        public override double CalculateInterest(double balance)
        {
            return Factory.Calculate(balance);
        }

      
    }
}
