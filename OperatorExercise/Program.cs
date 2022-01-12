using System;

namespace OperatorExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            double johnsVariable = 1.1;


            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder})"); 
            }                
             


        }
    }
}
