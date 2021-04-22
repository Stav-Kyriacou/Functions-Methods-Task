using System;
using System.Collections.Generic;

namespace FunctionsMethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which exercise to run? (1-12): ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    LineBreak();
                    Task1();
                    break;
                case 2:
                    LineBreak();
                    Task2();
                    break;
                case 3:
                    LineBreak();
                    Task3();
                    break;
                case 4:
                    LineBreak();
                    Task4();
                    break;
                case 5:
                    LineBreak();
                    Task5();
                    break;
                case 6:
                    LineBreak();
                    Task6();
                    break;
                case 7:
                    LineBreak();
                    Task7();
                    break;
                case 8:
                    LineBreak();
                    Task8();
                    break;
                case 9:
                    LineBreak();
                    Task9();
                    break;
                case 10:
                    LineBreak();
                    Task10();
                    break;
                case 11:
                    LineBreak();
                    Task11();
                    break;
                case 12:
                    LineBreak();
                    Task12();
                    break;
                default:
                    break;
            }
        }
        public static void LineBreak()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine();
        }
        public static void Task1()
        {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!");
        }
        public static void Task2()
        {
            Console.Write("Please input a name: ");
            Greetings(Console.ReadLine());
        }
        public static void Greetings(string name)
        {
            Console.WriteLine("Welcome friend {0}!", name);
            Console.WriteLine("Have a nice day!");
        }
        public static void Task3()
        {
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of the two numbers is: {0}", AddTwoNums(num1, num2));

        }
        public static int AddTwoNums(int num1, int num2)
        {
            int answer = num1 + num2;
            return answer;
        }
        public static void Task4()
        {
            Console.Write("Please enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("\"{0}\" contains {1} spaces", input, CountSpaces(input));
        }
        public static int CountSpaces(string input)
        {
            int spaces = 0;
            foreach (char i in input)
            {
                if (i == ' ')
                {
                    spaces++;
                }
            }
            return spaces;
        }
        public static void Task5()
        {
            int[] nums = new int[5];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the elements of the array is {0}", SumArray(nums));
        }
        public static int SumArray(int[] nums)
        {
            int answer = 0;

            foreach (int i in nums)
            {
                answer += i;
            }
            return answer;
        }
        public static void Task6()
        {
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            SwapTwoNumbers(num1, num2);
        }
        public static void SwapTwoNumbers(int num1, int num2)
        {
            int num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("Now the first number is: {0}, and the second number is: {1}", num1, num2);
        }
        public static void Task7()
        {
            Console.Write("Input base number: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Input the exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            Console.WriteLine("The number {0} ^ {1} = {2}", baseNum, exponent, CalcPower(baseNum, exponent));

        }
        public static int CalcPower(int baseNum, int exponent)
        {
            int answer = baseNum;

            for (int i = 1; i < exponent; i++)
            {
                answer *= baseNum;
            }

            return answer;
        }
        public static void Task8()
        {
            Console.Write("Input the n number of Fibonacci Series: ");
            int input = int.Parse(Console.ReadLine());

            WriteFibonacci(input);
        }
        public static void WriteFibonacci(int length)
        {
            List<int> fibonacci = new List<int>();

            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    fibonacci.Add(i);
                    Console.Write(i);
                }
                else if (i == 1)
                {
                    fibonacci.Add(i);
                    Console.Write(i);
                }
                else
                {
                    fibonacci.Add((fibonacci[i - 1] + fibonacci[i - 2]));
                    Console.Write(fibonacci[i]);
                }
                Console.Write(" ");
            }
        }
        public static void Task9()
        {
            Console.Write("Input a number: ");
            float input = float.Parse(Console.ReadLine());

            if (CheckPrimeNum(input))
            {
                Console.WriteLine("{0} is a prime number", input);
            }
            else
            {
                Console.WriteLine("{0} is NOT a prime number", input);
            }

        }
        public static bool CheckPrimeNum(float number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static void Task10()
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of the digits of the number {0} is: {1}", input, SumDigits(input));
        }
        public static int SumDigits(int number)
        {
            int answer = 0;

            string something = number.ToString();
            foreach (char i in something)
            {
                answer += int.Parse(i.ToString());
            }

            return answer;
        }
        public static void Task11()
        {
            Console.Write("Enter a number: ");
            long input = long.Parse(Console.ReadLine());

            Console.WriteLine("The factorial of {0}! is {1}", input, CalcFactorial(input));
        }
        public static long CalcFactorial(long number)
        {
            long answer = number;

            for (long i = number - 1; i > 0; i--)
            {
                answer *= i;
            }

            return answer;
        }
        public static void Task12()
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("The Fibonacci of the {0} th term is {1}", input, CalcFibonacci(input));
        }
        public static int CalcFibonacci(int length)
        {
            List<int> fibonacci = new List<int>();

            for (int i = 0; i <= length; i++)
            {
                if (i == 0)
                {
                    fibonacci.Add(i);
                }
                else if (i == 1)
                {
                    fibonacci.Add(i);
                }
                else
                {
                    fibonacci.Add((fibonacci[i - 1] + fibonacci[i - 2]));
                }
            }
            return fibonacci[fibonacci.Count - 1];
        }
    }
}
