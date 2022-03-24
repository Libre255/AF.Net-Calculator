using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CalcutatorProject
{
    public class Menu
    {
        int selectedIndex;
        string Prompt;
        string[] Options;
        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            selectedIndex = 0;
        }
        private void DisplayOptions()
        {
            Clear();
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"<< {Options[i]} >>");
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                DisplayOptions();
                keyPressed = ReadKey(true).Key;

                if(keyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex == -1)
                    {
                        selectedIndex = Options.Length - 1;
                    }
                }else if(keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex > Options.Length - 1)
                    {
                        selectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            Clear();
            return selectedIndex;
        }


    }
}
