using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SpaceShooter2023
{
    public class PewPew : SpaceObject
    {
        //public Rect HitBox { get; private set; }
        public PewPew()
        {
            Alive = true;
        }

        public void Design()
        {
            // Define the vertices for the PewPewLaser Shape-Point
            PointCollection myPointCollection = new PointCollection
            {
                new Point(-10, 0),
                new Point(-4, -4),
                new Point(4, -4),
                new Point(10, 0),
                new Point(4, 4),
                new Point(-4, 4)
            };
            Shape.Points = myPointCollection;

            // Farbe und Dicke 
            Shape.Fill = Brushes.Red;
            Shape.Stroke = Brushes.DarkRed;
            Shape.StrokeThickness = 1;
        }
        public void SetStartPosition(int EingabeX, int EingabeY)
        {
            X_Position = EingabeX;
            Y_Position = EingabeY;
            X_Vector = Global.GameSpeed + 2;
        }

        //// Wird im Asteroiden gemacht

        //public void AsteroidCollision()
        //{
        //    for (int i = Global.ListWithAsteroids.Count - 1; i >= 0; i--)
        //    {
        //        var asteroid = Global.ListWithAsteroids[i];
        //        if (this.HitBox.IntersectsWith(new Rect(asteroid.X_Position, asteroid.Y_Position, asteroid.Shape.Width, asteroid.Shape.Height)))
        //        {
        //            asteroid.RemoveFromCanvas();
        //            Global.ListWithAsteroids.RemoveAt(i);
        //            this.Alive = false;
        //            break;
        //        }
        //    }
        //}
        public bool OutOfRange()
        {
            if (X_Position >= Global.WindowWidth)
                return true;
            return false;
        }
    }
}