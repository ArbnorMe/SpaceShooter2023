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
        internal bool OutOfGame()
        {
            return X_Position <= 0;
        }

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
        public void PewPewCol()
        {
            var pewPewHitBox = new EllipseGeometry();
            pewPewHitBox.RadiusX = 10;
            pewPewHitBox.RadiusY = 10;

            var asteroidHitBox = new EllipseGeometry();
            asteroidHitBox.RadiusX = 10;
            asteroidHitBox.RadiusY = 10;

            for (int i = 0; i < Global.ListWithAsteroids.Count; i++)
            {
                asteroidHitBox.Center = new Point(Global.ListWithAsteroids[i].X_Position, Global.ListWithAsteroids[i].Y_Position);

                for (int j = 0; j < Global.ListWithPewPews.Count; j++)
                {
                    pewPewHitBox.Center = new Point(Global.ListWithPewPews[j].X_Position, Global.ListWithPewPews[j].Y_Position);
                    var pewHit = pewPewHitBox.FillContainsWithDetail(asteroidHitBox);

                    if (pewHit == IntersectionDetail.Intersects)
                    {
                        Global.ListWithAsteroids[i].RemoveFromCanvas();
                        Global.ListWithPewPews[j].RemoveFromCanvas();
                        Global.ListWithAsteroids.RemoveAt(i);
                        Global.ListWithPewPews.RemoveAt(j);
                    }
                }
            }
        }

        // Design
        public void Design()
        {
            PointCollection myPointCollection = new PointCollection
            {
                new Point(rnd.Next(0, 5), -rnd.Next(10, 20)),
                new Point(rnd.Next(5, 10), -10),
                new Point(rnd.Next(10, 20), -rnd.Next(10, 20)),
                new Point(rnd.Next(15, 30), rnd.Next(0, 5)),
                new Point(rnd.Next(10, 20), rnd.Next(5, 10)),
                new Point(rnd.Next(5, 10), rnd.Next(10, 20)),
                new Point(rnd.Next(2, 5), rnd.Next(5, 10)),
                new Point(-rnd.Next(5, 10), rnd.Next(10, 20)),
                new Point(-rnd.Next(10, 20), rnd.Next(5, 10)),
                new Point(-rnd.Next(15, 30), rnd.Next(2, 5)),
                new Point(-rnd.Next(10, 20), -10)
            };
            Shape.Points = myPointCollection;

            // Farbe
            Shape.Fill = Brushes.DarkGray;
        }
    }
}