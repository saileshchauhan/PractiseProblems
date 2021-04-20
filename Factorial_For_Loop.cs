using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipProblem
{
    class Factorial_For_Loop
    {
        public void FactorialForLoop()
        {
            Console.WriteLine("Enter a number For loop ");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" {0} Factorial is {1} ",number,ForLoop(number));
        }
        static long ForLoop(int number)

        {   int fact = 1;
            if (number == 0)
            {
                return 1;
            }
            for (int i = number; i > 0; i--)
            {
                  fact *= i;
            }
            return fact;
        }
    }   

}
