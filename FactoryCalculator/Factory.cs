using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCalculator
{
    public static class Factory
    {
        
        public static double Calculate(double balance)
        {
            var interest = 0.0;
            if (balance >= 0 && balance < 1000)
            {
                interest = balance * 0.01;
            }

            if (balance >= 1000 && balance < 5000)
            {
                interest = balance * 0.015;
            }
            if (balance >= 5000 && balance < 10000)
            {
                interest = balance * 0.02;
            }
            if (balance >= 10000 && balance < 50000)
            {
                interest = balance * 0.025;
            }
            if (balance >= 50000)
            {
                interest = balance * 0.03;
            }
            //if the customer is using overdraft
            if (balance < 0)
            {
                interest = balance * 0;
            }
            return interest;
        }
    }
}
