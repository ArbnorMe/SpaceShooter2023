using System;
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
        public static Key LastButton { get; set; }

        public static double WindowWidth = Application.Current.MainWindow.ActualWidth;
        public static double WindowHeight = Application.Current.MainWindow.ActualHeight;
    }
}