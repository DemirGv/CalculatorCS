using System;

namespace Assignment1
{
    class Program
    {

        static void Main(string[] args)
        {

            bool keepLooping = true;

            do
            {

                try
                {
                    Console.Clear();
                    PrintMenu();
                    int selection = AskUserForSelection("menu slection");
                    double number1 = AskUserForNumber1(" first ");
                    double number2 = AskUserForNumber2(" second ");

                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("Addition:" + Addition(number1, number2));
                            break;

                        case 2:
                            Console.WriteLine("Subtraction:" + Subtraction(number1, number2));
                            break;

                        case 3:
                            Console.WriteLine("Multiplication:" + Multiplication(number1, number2));
                            break;

                        case 4:
                            Console.WriteLine("Division:" + Division(number1, number2));
                            break;

                        case 9:
                            keepLooping = false;
                            break;

                        default:
                            break;
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);
                    Console.Clear();
                }

                catch
                {
                    Console.WriteLine("Exception!!!");
                }

            }
            while (keepLooping);
        }
        private static double Division(double number1, double number2)
        {


            if (number2 == 0)
            {
                Console.Write("DivideByZeroException");
                //throw DivideByZeroException;
            }
            return number1 / number2;
        }
        private static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
            //Console.Write(number1 * number2);
        }
        private static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }
        private static double Addition(double number1, double number2)
        {
            return number1 + number2;
        }
        static string? AskUserFor(string ms)
        {
            Console.Write("Please enter " + ms + ": ");
            return Console.ReadLine();
        }
        static int AskUserForSelection(string ms)
        {
            string? result = AskUserFor(ms);
            int number = Convert.ToInt32(result);
            return number;
        }
        static string? AskUserForNum(string num)
        {
            Console.Write("Please enter the" + num + "number: ");
            return Console.ReadLine();
        }

        static double AskUserForNumber1(string num)
        {
            string? num1 = AskUserForNum(num);
            double number1 = Convert.ToDouble(num1);
            //double number1 = double.Parse(num1 ?? "");
            return number1;
        }
        static double AskUserForNumber2(string num)
        {
            string? num2 = AskUserForNum(num);
            //double number2 = Convert.ToDouble(num2);
            double number2 = double.Parse(num2 ?? "");
            return number2;
        }
        static void PrintMenu()
        {
            Console.WriteLine("------ Calculator ------");
            Console.WriteLine("Enter the slection you want to do");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction ");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine();
            Console.WriteLine("Press 9 to exit the calculator");
        }
    }
}