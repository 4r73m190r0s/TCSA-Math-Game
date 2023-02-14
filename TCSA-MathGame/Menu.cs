using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSA_MathGame
{
    internal class Menu
    {
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}.");
            Console.WriteLine(@$"Choose the game:
            A - Addition
            B - Subtraction
            C - Multiplication
            D - Division
            V - View Previous Games
            Q - Quit");
            Console.WriteLine("--------------------------");

            string gameSelected = Console.ReadLine();

            switch (gameSelected.Trim().ToUpper())
            {
                case "A":
                    GameEngine.AdditionGame();
                    break;
                case "B":
                    GameEngine.SubtractionGame();
                    break;
                case "C":
                    GameEngine.MultiplicationGame();
                    break;
                case "D":
                    GameEngine.DivisionGame();
                    break;
            }
        }
    }
}
