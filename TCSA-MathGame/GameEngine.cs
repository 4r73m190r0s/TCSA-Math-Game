using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSA_MathGame;
using TCSA_MathGame.Models;
using static System.Formats.Asn1.AsnWriter;

namespace TCSA_MathGame
{
    internal class GameEngine
    {
        internal static void AdditionGame()
        {
            Console.Clear();
            Console.WriteLine("Addition Game");

            var score = 0;

            var random = new Random();

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 10);
                secondNumber= random.Next(1, 10);
                Console.WriteLine($"{firstNumber} + {secondNumber} = X");
                Console.Write("X = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Correct Answer");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect Answer");
                }
            }

            Console.WriteLine("\nGame Over");
            Console.WriteLine($"Your Final Score Is {score}.");

            games.Add(new Game() { Score = score, Type = GameType.Addition, Date = DateTime.Now });
        }
        internal static void SubtractionGame()
        {
            Console.Clear();
            Console.WriteLine("Subtraction Game");

            var score = 0;

            var random = new Random();

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 10);
                secondNumber = random.Next(1, 10);
                Console.WriteLine($"{firstNumber} - {secondNumber} = X");
                Console.Write("X = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Correct Answer");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect Answer");
                }
            }

            Console.WriteLine("\nGame Over");
            Console.WriteLine($"Your Final Score Is {score}.");

            games.Add(new Game() { Score = score, Type = GameType.Subtraction, Date = DateTime.Now });
        }
        internal static void MultiplicationGame()
        {
            Console.Clear();
            Console.WriteLine("Multiplication Game");

            var score = 0;

            var random = new Random();

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 10);
                secondNumber = random.Next(1, 10);
                Console.WriteLine($"{firstNumber} * {secondNumber} = X");
                Console.Write("X = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Correct Answer");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect Answer");
                }
            }

            Console.WriteLine("\nGame Over");
            Console.WriteLine($"Your Final Score Is {score}.");

            games.Add(new Game() { Score = score, Type = GameType.Multiplication, Date = DateTime.Now });
        }
        internal static void DivisionGame()
        {
            Console.Clear();
            Console.WriteLine("Division Game");

            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber} = X");
                Console.Write("X = ");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct Answer");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect Answer");
                }
            }

            Console.WriteLine("\nGame Over");
            Console.WriteLine($"Your Final Score Is {score}.");

            games.Add(new Game() { Score = score, Type = GameType.Division, Date = DateTime.Now });
        }

        internal static List<Game> games = new List<Game>();
    }
}
