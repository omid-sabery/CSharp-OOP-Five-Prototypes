using System;

namespace FivePrototypes
{
    // Represents a 2D point with integer coordinates
    internal class Point
    {
        // X coordinate (read-only)
        public int X { get; }
        // Y coordinate (read-only)
        public int Y { get; }

        // Constructor with coordinates
        public Point(int x, int y) { X = x; Y = y; }
        // Default constructor (origin)
        public Point() { X = 0; Y = 0; }

        // String representation for easy display
        public override string ToString() => $"({X}, {Y})";
    }
}
