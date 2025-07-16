using FivePrototypes;

namespace FivePrototypes
{
    // Represents an RGB color
    internal class Color
    {
        // Red, Green, Blue components
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        // Predefined static colors
        public static Color Red { get; } = new Color(255, 0, 0);
        public static Color Green { get; } = new Color(0, 255, 0);
        public static Color Blue { get; } = new Color(0, 0, 255);
        public static Color White { get; } = new Color(255, 255, 255);
        public static Color Black { get; } = new Color(0, 0, 0);
        public static Color Orange { get; } = new Color(255, 165, 0);
        public static Color Yellow { get; } = new Color(255, 255, 0);
        public static Color Purple { get; } = new Color(128, 0, 128);


        // Constructor with RGB values
        public Color(byte red, byte green, byte blue)
        {
            R = red;
            G = green;
            B = blue;
        }
        // Default constructor (black)
        public Color() : this(0, 0, 0) { }

        // String representation for easy display
        public override string ToString() => $"RGB({R}, {G}, {B})";
    }
}
