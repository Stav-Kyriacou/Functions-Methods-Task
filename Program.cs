using System;

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
            
        }
        public static void Task5()
        {

        }
        public static void Task6()
        {

        }
        public static void Task7()
        {

        }
        public static void Task8()
        {

        }
        public static void Task9()
        {

        }
        public static void Task10()
        {

        }
        public static void Task11()
        {

        }
        public static void Task12()
        {

        }
    }
}
