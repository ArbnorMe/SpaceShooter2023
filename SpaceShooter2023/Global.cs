﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SpaceShooter2023
{
    public static class Global
    {
        public static Canvas SpaceCanvas { get; set; }
        public static int GameSpeed = 10;

        // Player
        public static Key LastButton { get; set; }

        // Asteroide
        public static List<Asteroid> ListWithAsteroids = new List<Asteroid>();
        public static int NumberOfAsteroids = 4;

        // PewPew
        public static List<PewPew> ListWithPewPews = new List<PewPew>();

        public static double WindowWidth = Application.Current.MainWindow.ActualWidth;
        public static double WindowHeight = Application.Current.MainWindow.ActualHeight;
    }
}