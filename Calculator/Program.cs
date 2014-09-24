using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {

        static int firstNumber;
        static string calculationMethod;
        static int secondNumber;
        static string restart;
        static int loop = 1;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello, I am your personal Calculator");
            Console.Write("Hit ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("to begin.");
            Console.Read();
            Console.Read();

            while (loop == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter your first number below.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;

                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("What calculation method?");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("+");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("-");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("*");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("/");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("?");

                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;

                calculationMethod = Console.ReadLine();

                Console.Clear();
                Console.Write("Please enter your second number below.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;

                secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("{0} {1} {2} =", firstNumber, calculationMethod, secondNumber);

                if (calculationMethod == "+")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" {0}", firstNumber + secondNumber);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(".");
                }
                else if (calculationMethod == "-")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" {0}", firstNumber - secondNumber);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(".");
                }
                else if (calculationMethod == "*")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" {0}", firstNumber * secondNumber);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(".");
                }
                else if (calculationMethod == "/")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" {0}", firstNumber / secondNumber);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(".");
                    Console.WriteLine();
                }
                else if (calculationMethod == "?")
                {
                    Console.WriteLine("...");
                    Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
                    Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber);
                    Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber);
                    Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber);
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("ERROR");
                }

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine();
                Console.Write("- - - - - - - - - - - - - - - - - - - - ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.Write("restart?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("[Yes / No]");
                Console.ForegroundColor = ConsoleColor.White;

                restart = (Console.ReadLine().ToLower());

                if (restart == "yes")
                {
                    loop = 1;
                }

                else if (restart == "no")
                {
                    Environment.Exit(0);
                }
            }

        }
    }
}
