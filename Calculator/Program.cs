using static System.Console;
using System;
namespace CalcutatorProject
{
    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            calculator.menu();
        }
        
    }
    class Calculator
    {
        public void menu()
        {
            string[] methods = { "+", "-", "*", "/"};
            Menu MainMenu = new Menu("Chose the mathematic method", methods);
            int seletedMethod = MainMenu.Run();

            switch (seletedMethod)
            {
                case 0: Sum();
                    break;
                case 1: Minus();
                    break;
                case 2: Multiplication();
                    break;
                case 3:Division();
                    break;

            }
        }
        private int[] instructions(string method)
        {
            WriteLine("Write the first number then press enter");
            WriteLine("Then Write the second number and press enter");
            int n1 = NrValidator();
            WriteLine(method);
            int n2 = NrValidator();
            WriteLine($"-----");
            return new int[]{n1, n2};
        }
        private void ReRunMenu()
        {
            WriteLine(" ");
            WriteLine("Press any key to go back to the menu");
            ReadKey();
            menu();
        }
        private void Sum()
        {
            int[] numbers = instructions("+");
            WriteLine($"{numbers[0] + numbers[1]}");
            ReRunMenu();
        }

        private void Minus()
        {
            int[]numbers = instructions("-");
            WriteLine($"{numbers[0] - numbers[1]}");
            ReRunMenu();
        }
        private void Multiplication()
        {
            int[] numbers = instructions("*");
            WriteLine($"{numbers[0] * numbers[1]}");
            ReRunMenu();
        }
        private void Division()
        {
            int[] numbers = instructions("/");
            if(numbers[0] == 0 || numbers[1] == 0)
            {
                WriteLine("0");
                WriteLine("you trying to divide by zero");
            }
            else
            {
                WriteLine($"{numbers[0]/numbers[1]}");
            }
            
            ReRunMenu();
        }

        private int NrValidator()
        {
            int checkRuns = 1;
            int numberOutput;
            string input;
            do
            {
                if (checkRuns >= 2)
                {
                    WriteLine("You can only write numbers, please try again");
                }
                input = ReadLine();
                checkRuns++;
            } while (int.TryParse(input, out numberOutput) == false);
            return numberOutput;
        }
    }
}