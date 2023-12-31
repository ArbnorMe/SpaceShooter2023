﻿using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SpaceShooter2023
{
    public class Player : Ship
    {
        public int height = 20;
        public Player()
        {
            Alive = true;
        }
        public void SetMovingDirection()
        {
            switch (Global.LastButton)
            {
                case Key.Left:
                    X_Vector = -Global.GameSpeed;
                    Y_Vector = 0;
                    break;
                case Key.Right:
                    X_Vector = Global.GameSpeed;
                    Y_Vector = 0;
                    break;
                case Key.Down:
                    X_Vector = 0;
                    Y_Vector = +Global.GameSpeed;
                    break;
                case Key.Up:
                    X_Vector = 0;
                    Y_Vector = -Global.GameSpeed;
                    break;
                case Key.Space:
                    Global.ListWithPewPews.Add(new PewPew());
                    Global.ListWithPewPews[Global.ListWithPewPews.Count - 1].Design();
                    Global.ListWithPewPews[Global.ListWithPewPews.Count - 1].SetStartPosition(X_Position + 15, Y_Position + 15);
                    Global.LastButton = Key.Back;
                    break;
            }
        }
        public void CornerCheck()
        {
            if (X_Position <= 0)
            {
                X_Position = 5;
            }

            if (Y_Position <= 0)
            {
                Y_Position = 5;
            }

            if (X_Position >= Global.WindowWidth - 50)
            {
                X_Position = Convert.ToInt32(Global.WindowWidth) - 55;
            }

            if (Y_Position >= Global.WindowHeight - 20)
            {
                Y_Position = Convert.ToInt32(Global.WindowHeight) - 25;
            }
        }
        public void Design()
        {
            PointCollection myPointCollection = new PointCollection();

            Shape.Fill = Brushes.Yellow;

            Point Point0 = new Point(0, 0);
            Point Point1 = new Point(50, 10);
            Point Point2 = new Point(0, 20);
            Point Point3 = new Point(10, 10);

            myPointCollection.Add(Point0);
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);

            Shape.Points = myPointCollection;
        }
    }
}