using static System.Console;
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
        private double[] instructions(string method)
        {
            WriteLine("Write the first number then press enter");
            WriteLine("Then Write the second number and press enter");
            double n1 = NrValidator();
            WriteLine(method);
            double n2 = NrValidator();
            WriteLine($"-----");
            return new double[]{n1, n2};
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
            double[] numbers = instructions("+");
            WriteLine($"{numbers[0] + numbers[1]}");
            ReRunMenu();
        }

        private void Minus()
        {
            double[]numbers = instructions("-");
            WriteLine($"{numbers[0] - numbers[1]}");
            ReRunMenu();
        }
        private void Multiplication()
        {
            double[] numbers = instructions("*");
            WriteLine($"{numbers[0] * numbers[1]}");
            ReRunMenu();
        }
        private void Division()
        {
            double[] numbers = instructions("/");
            if(numbers[0] == 0 || numbers[1] == 0)
            {
                WriteLine("0");
                WriteLine("you trying to divide by zero");
            }
            else
            {
                WriteLine($"{numbers[0] / numbers[1]}");
            }
            
            ReRunMenu();
        }

        private double NrValidator()
        {
            double checkRuns = 1;
            double numberOutput;
            string input;
            do
            {
                if (checkRuns >= 2)
                {
                    WriteLine("You can only write numbers, please try again");
                }
                input = ReadLine();
                checkRuns++;
            } while (double.TryParse(input, out numberOutput) == false);
            return numberOutput;
        }
    }
}