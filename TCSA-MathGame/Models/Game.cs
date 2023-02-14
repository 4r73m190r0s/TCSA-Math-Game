using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSA_MathGame.Models
{
    internal class Game
    {
        public int SCore { get; set; }
        public GameType Type { get; set; }
        public DateTime Date { get; set; }
    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Division,
        Multiplication
    }
}
