using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
     public abstract class InterestCalculatorServiceBase
     {
         public abstract double CalculateInterest(double balance);
     }
}
