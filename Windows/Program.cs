using System;

namespace Windows
{
    class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color");
            var color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"My name is {name}. My favorite animal is a {animal}. He loves to eat {color} potatoes");
        }
       
        
        

        static void Main(string[] args)
        {
            // First Exercise
            MadLib();

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
        public static double Sum(params double [] arr)
        {
            //placeholder value. by addition we start from zero
            double totalSum = 0.0;

            foreach (int i in arr)
            {
                totalSum += i;
            }
            return totalSum ;
        }
        public static int Subtraction(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }
        public static double Multiply(params double[] arr)
        {
            // by multiplacation we start from 1, otherwise our value will always be 0
            double totalSum = 1.00;
            
            foreach (int i in arr)
            {
                totalSum *= i;
            }
            return totalSum;
        }

        public static double Division(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;
        }
        

    }
}
