using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipProblem
{
    class Factorial_Recursive
    {
        public void Factorial()
        {
         
                Console.WriteLine("Enter a number");
                int number = Convert.ToInt32(Console.ReadLine());
                long numberFactorial = Recursive(number);
                Console.WriteLine("{0} factorial is {1}", number, numberFactorial);
                Console.ReadKey();

                static long Recursive(int number)
                {
                    if (number == 0)
                    {
                        return 1;
                    }
                    return number * Recursive(number - 1);
                }
           
        }
    }
}
