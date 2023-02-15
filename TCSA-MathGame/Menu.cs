﻿using System;
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

            bool isGameON = true;

            do
            {
                Console.WriteLine();
                Console.WriteLine(@$"Choose the Game:
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
                    case "V":
                        Helpers.GetGames();
                        break;
                    case "Q":
                        Console.WriteLine("Goodbye");
                        isGameON = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                } 
            } while (isGameON);
        }
    }
}
