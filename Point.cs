using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Point
    {
        // Properties
        public int X { get;  }
        public int Y { get;  }

        // Constructors
        public Point(int x, int y) { X = x; Y = y; }
        public Point() { X = 0; Y = 0; }

        // ToString override for easy viewing
        public override string ToString() => $"({X}, {Y})";
    }
}
