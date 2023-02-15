using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSA_MathGame.Models
{
    internal class Game
    {
        public int Score { get; set; }
        public GameType Type { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"Game: {Type,-20} Score: {Score,-10} Date: {Date,-15:f}";
        }
    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Division,
        Multiplication
    }
}
