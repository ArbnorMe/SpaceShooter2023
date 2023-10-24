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
        public void SetMovingDirection()
        {
            X_Position = 280;
            Y_Position = 280;
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
    }
}