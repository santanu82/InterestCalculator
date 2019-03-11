using InterestCalculator;
using System;


namespace InterestRatesApp
{
    class Program
    {
        
        static void Main()
        {
            var myCalculatorService = new InterestCalculatorService();
            Console.Beep();
           Console.WriteLine("****************Welcome to Interest Calculator Application*************************");
           Console.WriteLine("Please provide your balance: ");
           try
           {
               var balance = Convert.ToDouble(Console.ReadLine());
               var interest = myCalculatorService.CalculateInterest(balance);
               Console.WriteLine("Your interest on your balance is :"+interest);
           }
           catch (Exception)
           {
               
              Console.WriteLine("Balance is invalid, please provide a valid balance.");
           }

           Console.ReadLine();

        }
    }
}
