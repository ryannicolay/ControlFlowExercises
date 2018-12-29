using System;

namespace ControlFlowExercises
{
    class Exercise1
    {
        public int CountNumbers()
        {
            var count = 0;
            var max = 100;

            for (var i = 1; i <= max; i++)
            {
                if (i % 3 == 0) count++;
            }

            return count;
        }
    }

    class Exercise2
    {
        public int AddNumbers()
        {
            var sum = 0;
            var input = "";

            do
            {
                Console.WriteLine("Please enter a number or 'ok' to exit");
                input = Console.ReadLine();

                if (Int32.TryParse(input, out int result))
                    sum = sum + Int32.Parse(input);
            } while (input != "ok");

            return sum;
        }
    }

    class Exercise3
    {

        public int Factorial(int num)
        {
            if (num > 1)
            {
                return num * Factorial(num - 1);
            }
            if (num < 1)    
                return num;

            return num;
        }

        public int GetNumber()
        {
            Console.WriteLine("Please Enter a Number to find the factorial of that number.");
            var number = Console.ReadLine();

            return Int32.Parse(number);
        }

        public string FormatFactorialDisplay(int number, int num)
        {
            return (number.ToString() + "! =" + num.ToString());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var exercise1 = new Exercise1();
            var exercise2 = new Exercise2();
            var exercise3 = new Exercise3();

            Console.WriteLine("Exercise 1");
            Console.WriteLine(exercise1.CountNumbers() + "\n");
            Console.WriteLine("Exercise 2");
            Console.WriteLine("Total Sum of Numbers: " + exercise2.AddNumbers() + "\n");
            Console.WriteLine("Exercise 3");
            var number = exercise3.GetNumber();
            Console.WriteLine(exercise3.FormatFactorialDisplay(number, exercise3.Factorial(number)));
        }
        
    }
}
