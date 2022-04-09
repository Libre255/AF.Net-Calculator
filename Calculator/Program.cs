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
    public class Calculator
    {
        double Result;
        double [] inputsByUser = new double[2];
        public void menu()
        {
            string[] methods = { "+", "-", "*", "/"};
            Menu MainMenu = new Menu("Chose the mathematic method", methods);
            int seletedMethod = MainMenu.Run();

            instructions(methods[seletedMethod]);

            switch (seletedMethod)
            {
                case 0: 
                    Result = Sum(inputsByUser[0], inputsByUser[1]);
                    break;
                case 1:
                    Result = Minus(inputsByUser);
                    break;
                case 2:
                    Result = Multiplication(inputsByUser);
                    break;
                case 3:
                    Result = Division(inputsByUser);
                    break;

            }
            WriteLine(Result);
            ReRunMenu();
        }
        private void instructions(string MetodSymbol)
        {
            WriteLine("Write the first number then press enter");
            WriteLine("Then Write the second number and press enter");
            inputsByUser[0] = NrValidator();
            WriteLine(MetodSymbol);
            inputsByUser[1] = NrValidator();
            WriteLine($"-----");
        }
        private void ReRunMenu()
        {
            WriteLine(" ");
            WriteLine("Press any key to go back to the menu");
            ReadKey();
            menu();
        }
        public double Sum(double FirstNr, double SecondNr)
        {
           return FirstNr + SecondNr;
        }
        public double Sum(double [] Inputs)
        {
            return Inputs.Sum();
        }
        public double Minus(double FirstNr, double SecondNr)
        {
            return FirstNr- SecondNr;
        }
        public double Minus(double[] Inputs)
        {
            double startNr = Inputs[0];
            for(int i = 1; i< Inputs.Length; i++)
            {
                startNr -= Inputs[i];
            }
            return startNr;
        }
        public double Multiplication(double[] Inputs)
        {
            return Inputs[0] * Inputs[1];
        }
        public double Division(double[] Inputs)
        {
            if(Inputs[0] == 0 || Inputs[1] == 0)
            {
                WriteLine("you trying to divide by zero");
                return 0;
            }
            else
            {
                return Inputs[0] / Inputs[1];
            }
            
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