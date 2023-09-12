using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SpaceShooter2023
{
    public class PewPew : SpaceObject
    {
        public void SetMovingDirection()
        {
            X_Position = 50;
            Y_Position = 50;
        }
        public void Design()
        {
            // Define the vertices for the PewPewLaser Shape-Point
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(new Point(-8, 0));
            myPointCollection.Add(new Point(-4, -4));
            myPointCollection.Add(new Point(4, -4));
            myPointCollection.Add(new Point(8, 0));
            myPointCollection.Add(new Point(4, 4));
            myPointCollection.Add(new Point(-4, 4));
            Shape.Points = myPointCollection;

            // Optional: Set the fill color and stroke of the shape
            Shape.Fill = Brushes.Red;
            Shape.Stroke = Brushes.DarkRed;
            Shape.StrokeThickness = 1;
        }
    }
}