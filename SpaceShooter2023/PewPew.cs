using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SpaceShooter2023
{
    public class PewPew : SpaceObject
    {
        public PewPew()
        {
            Alive = true;
        }
        public void Design()
        {
            // Define the vertices for the PewPewLaser Shape-Point
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(new Point(-10, 0));
            myPointCollection.Add(new Point(-4, -4));
            myPointCollection.Add(new Point(4, -4));
            myPointCollection.Add(new Point(10, 0));
            myPointCollection.Add(new Point(4, 4));
            myPointCollection.Add(new Point(-4, 4));
            Shape.Points = myPointCollection;

            // Optional: Set the fill color and stroke of the shape
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
        public bool OutOfRange()
        {
            if (X_Position >= Global.WindowWidth)
                return true;
            return false;
        }
    }
}