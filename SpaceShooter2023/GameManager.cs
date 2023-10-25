using System;
using System.Windows.Threading;

namespace SpaceShooter2023
{
    public static class GameManager
    {
        static DispatcherTimer _timer;

        // Objects
        static Player _testShip;
        static Asteroid _testAsteroid;
        static PewPew _testPewPew;
        static PowerUp _testPowerUp;

        public static void Initialize()
        {
            _timer = new DispatcherTimer();
            _timer.Tick += OnTick;
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            _timer.Start();

            // _testShip
            _testShip = new Player();
            _testShip.Design();

            // _testAsteroid
            _testAsteroid = new Asteroid();
            _testAsteroid.Design();

            // _testPewPew
            _testPewPew = new PewPew();
            _testPewPew.Design();

            // _testPowerUp
            _testPowerUp = new PowerUp();
            _testPowerUp.Design();
        }

        private static void OnTick(object sender, EventArgs e)
        {
            // _testShip
            _testShip.RemoveFromCanvas();
            _testShip.SetMovingDirection();
            _testShip.Move();
            _testShip.Show();
        }
    }
}