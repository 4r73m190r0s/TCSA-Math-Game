using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSA_MathGame;
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

            Console.WriteLine("Game Over");
            Console.WriteLine($"Your Final Score Is {score}.");
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

            Console.WriteLine("Game Over");
            Console.WriteLine($"Your Final Score Is {score}.");
        }
    }
}
