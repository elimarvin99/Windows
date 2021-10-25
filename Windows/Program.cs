using System;

namespace Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Exercise
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color");
            var color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"My name is {name}. My favorite animal is a {animal}. He loves to eat {color} potatoes");

            // Second Exercise
            Console.WriteLine("What is your first number you would like to add?");
            var firstNumberA = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number you would like to add?");
            var secondNumberA = double.Parse(Console.ReadLine());

            var sumAnswer = Program.Sum(firstNumberA, secondNumberA);
            Console.WriteLine($"Your sum is {sumAnswer}");

            Console.WriteLine("What is your first number you would like to multiply?");
            var firstNumberM = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number you would like to multiply by?");
            var secondNumberM = double.Parse(Console.ReadLine());
;
            var multiplyAnswer = Program.Multiply(firstNumberM, secondNumberM);
            Console.WriteLine($"Your sum is {multiplyAnswer}");


            //Param Section
        }
        // declare methods that are used in Main
        public static double Sum(double x,double y)
        {
            double answer = x + y;
            return answer;
        }
        public static double Multiply(double x, double y)
        {
            double answer = x * y;
            return answer;
        }
        

    }
}
