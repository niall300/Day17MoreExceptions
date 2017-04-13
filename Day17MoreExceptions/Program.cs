using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Task
//Write a Calculator class with a single method: 
//    int power(int, int). 
//The power method takes two integers n, and p , as parameters 
//    and returns the integer result of n to the power of p.
//    If either n or p is negative,
//    then the method must throw an exception 
//    with the message: n and p should be non-negative.
namespace Day17MoreExceptions
{
    class NegativeNumberException: Exception
    {
       

         public NegativeNumberException()
        {
            
        }

    }    
        
        
        
        
        class Calculator
    {
        public int power(int n, int p)
        {
            if(n < 0 || p<0)
            {
                throw new Exception("n and p should be non - negative.");
            }
            
            double dn = (double)n;
            double dp = (double)p;
            double result = Math.Pow(n, p);
            int r = (int)result;
            return r;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
               
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                Console.ReadLine();
            }
        }
    }
}
