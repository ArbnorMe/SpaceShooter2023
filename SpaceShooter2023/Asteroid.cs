using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SpaceShooter2023
{
    public class Asteroid : SpaceObject
    {
        public Asteroid()
        {
            Alive = true;
            Random rnd = new Random();
            X_Position = 800;
            Y_Position = rnd.Next(0, 400);
            X_Vector = -4;

        }
        public void SetMovingDirection()
        {
            X_Position = 20;
            Y_Position = 20;
        }
        public void Design()
        {
            PointCollection myPointCollection = new PointCollection();

            Shape.Fill = Brushes.DarkGray;

            myPointCollection.Add(new Point(0, -20));
            myPointCollection.Add(new Point(10, -10));
            myPointCollection.Add(new Point(20, -20));
            myPointCollection.Add(new Point(30, 0));
            myPointCollection.Add(new Point(20, 10));
            myPointCollection.Add(new Point(10, 20));
            myPointCollection.Add(new Point(0, 10));
            myPointCollection.Add(new Point(-10, 20));
            myPointCollection.Add(new Point(-20, 10));
            myPointCollection.Add(new Point(-30, 0));
            myPointCollection.Add(new Point(-20, -10));

            Shape.Points = myPointCollection;
        }
    }
}