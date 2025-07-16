using System;
using System.Drawing;
using TicTacToe;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 3);
            Point point2 = new Point(-4, 0);

            Console.WriteLine($"Point 1: {point1}");
            Console.WriteLine($"Point 2: {point2}");

            Color cyan = new Color(0, 255, 255);
            Color red = Color.Red;

            Console.WriteLine($"Cyan: {cyan}");
            Console.WriteLine($"Red: {red}");

            var colors = Enum.GetValues<CardColor>();
            var ranks = Enum.GetValues<CardRank>();

            Card[] deck = new Card[colors.Length * ranks.Length];
            int index = 0;
            foreach (var color in colors)
            {
                foreach (var rank in ranks)
                {
                    deck[index++] = new Card(color, rank);
                }
            }

            foreach (var card in deck)
            {
                Console.WriteLine(card);
            }

        }
    }
}