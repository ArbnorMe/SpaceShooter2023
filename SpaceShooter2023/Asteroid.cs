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
        Random rnd = new Random();
        public Asteroid()
        {
            Alive = true;
            //Random rnd = new Random();
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

            myPointCollection.Add(new Point(rnd.Next(0, 5), -rnd.Next(10, 20)));
            myPointCollection.Add(new Point(rnd.Next(5, 10), -10));
            myPointCollection.Add(new Point(rnd.Next(10, 20), -rnd.Next(10, 20)));
            myPointCollection.Add(new Point(rnd.Next(15, 30), rnd.Next(0, 5)));
            myPointCollection.Add(new Point(rnd.Next(10, 20), rnd.Next(5, 10)));
            myPointCollection.Add(new Point(rnd.Next(5, 10), rnd.Next(10, 20)));
            myPointCollection.Add(new Point(rnd.Next(2, 5), rnd.Next(5, 10)));
            myPointCollection.Add(new Point(-rnd.Next(5, 10), rnd.Next(10, 20)));
            myPointCollection.Add(new Point(-rnd.Next(10, 20), rnd.Next(5, 10)));
            myPointCollection.Add(new Point(-rnd.Next(15, 30), rnd.Next(2, 5)));
            myPointCollection.Add(new Point(-rnd.Next(10, 20), -10));

            //for (int i = 0; i < 5; i++)
            //{
            //    myPointCollection.Add(new Point(rnd.Next(0, 50), -rnd.Next(10, 50)));
            //    myPointCollection.Add(new Point(rnd.Next(50, 100), -rnd.Next(50, 100)));
            //    myPointCollection.Add(new Point(rnd.Next(100, 150), -rnd.Next(100, 150)));
            //    myPointCollection.Add(new Point(rnd.Next(150, 200), -rnd.Next(150, 200)));
            //}


            Shape.Points = myPointCollection;
        }
        internal bool OutOfGame()
        {
            return X_Position <= 0;
        }
    }
}