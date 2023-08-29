using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace SpaceShooter2023
{
    public static class Global
    {
        public static Canvas GamingArea { get; set; }
        public static TextBlock TextBlockScore { get; set; }
        public static TextBlock LoseScreen { get; set; }

        public static int Score { get; set; }
        public static bool GameOver { get; set; }

        public const int ElementEdgeSize = 50; // Feldergröße
        public const int StartSpeed = 200; // The Game Speed in ms
    }
}