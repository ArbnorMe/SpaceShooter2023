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
        private int tempAsteroid = 0;

        //public List<PewPew> _shots = new List<PewPew>();
        internal List<PewPew> _shotsToRemove = new List<PewPew>();

        public void LetThePewPewFly()
        {
            foreach (PewPew x in Global.ListWithPewPews)
            {
                if (x.OutOfRange())
                {
                    _shotsToRemove.Add(x);
                    x.RemoveFromCanvas();
                    tempAsteroid = Global.NumberOfAsteroids - Global.ListWithAsteroids.Count;
                    for (int i = 0; i < tempAsteroid; i++)
                    {
                        Global.ListWithAsteroids.Add(new Asteroid());
                        Global.ListWithAsteroids[i].Design();

                    }
                }
            }
            foreach (PewPew x in _shotsToRemove)
                Global.ListWithPewPews.Remove(x);
            foreach (PewPew x in Global.ListWithPewPews)
            {
                x.RemoveFromCanvas();
                x.Move();
                x.Show();
            }
            
        }
    }
}