using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SpaceShooter2023
{
    public class PowerUp : SpaceObject
    {
        public PowerUp()
        {
            Alive = true;

            X_Position = 100;
            Y_Position = 10;
        }

        public void SetMovingDirection()
        {
            X_Vector = -10;
            Y_Vector = 0;
        }
        public void Design()
        {
            PointCollection myPointCollection = new PointCollection();

            Shape.Fill = Brushes.MediumVioletRed;

            myPointCollection.Add(new Point(0, -10));
            myPointCollection.Add(new Point(5, -10));
            myPointCollection.Add(new Point(5, -5));
            myPointCollection.Add(new Point(10, -5));
            myPointCollection.Add(new Point(10, 0));
            myPointCollection.Add(new Point(5, 0));
            myPointCollection.Add(new Point(5, 5));
            myPointCollection.Add(new Point(0, 5));
            myPointCollection.Add(new Point(0, 0));
            myPointCollection.Add(new Point(-5, 0));
            myPointCollection.Add(new Point(-5, -5));
            myPointCollection.Add(new Point(-10, -5));
            myPointCollection.Add(new Point(-10, -10));

            Shape.Points = myPointCollection;
        }

        public void OutOfLevel()
        {
            if (X_Position < 10)
            { 
                X_Position = 500;
            }
        }
    }
}