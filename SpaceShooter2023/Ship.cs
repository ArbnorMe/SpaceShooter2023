using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;
using System.Windows.Input;

namespace SpaceShooter2023
{
    public class Ship : SpaceObject
    {
        internal List<PewPew> _shots = new List<PewPew>();
        internal List<PewPew> _shotsToRemove = new List<PewPew>();

        public void LetThePewPewFly()
        {
            foreach (PewPew x in _shots)
            {
                if (x.OutOfRange())
                    _shotsToRemove.Add(x);
                x.RemoveFromCanvas();
            }
            foreach (PewPew x in _shotsToRemove)
                _shots.Remove(x);
            foreach (PewPew x in _shots)
            {
                x.RemoveFromCanvas();
                x.Move();
                x.Show();
            }
        }
    }
}