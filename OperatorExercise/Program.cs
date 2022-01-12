using System;

namespace OperatorExercise
{
    class Program
    {
        private static object quoutient;

        static void Main(string[] args)
        {



            int a = 17;
            int b = 4;

            //Addition

            int answer = a + b;

            Console.WriteLine($"Addition:{answer}");


            //Subtraction

            int answer2 = a - b;

            Console.WriteLine($"Subtraction: {answer2}");


            //Multipication

            int answer3 = a * b;

            Console.WriteLine($"Multiplication:{answer3}");



            //Division

            int answer4 = a / b;
            var remainder = a % b; //17 / 4 = R1

            


            Console.WriteLine($"The quotient is {answer4} with a remainder of {remainder}");

            Console.WriteLine();

            AreaOfCircle();
            
            
         }


        public static void AreaOfCircle()
        {
            Console.WriteLine("what is the radius of your circle ?");
            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * radius * radius;

            Console.WriteLine(area);

           

        }

    }

}