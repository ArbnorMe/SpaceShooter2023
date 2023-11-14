using System;
using System.Windows;
using System.Windows.Threading;

namespace SpaceShooter2023
{
    public static class GameManager
    {
        static DispatcherTimer _timer;

        // Objects
        static Player player;
        static Asteroid _testAsteroid;
        static PewPew _testPewPew;
        static PowerUp _testPowerUp;

        public static void Initialize()
        {
            _timer = new DispatcherTimer();
            _timer.Tick += OnTick;
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            _timer.Start();

            // player
            player = new Player();
            player.Design();
            player.Y_Position = (int)Application.Current.MainWindow.ActualHeight / 2 - player.height; // Der Spieler wird mittisch vom Fenster platziert

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
            // player
            player.RemoveFromCanvas();
            player.SetMovingDirection();
            player.Move();
            player.Show();

            // _testAsteroid
            _testAsteroid.RemoveFromCanvas();
            _testAsteroid.SetMovingDirection();
            _testAsteroid.Move();
            _testAsteroid.Show();

            // _testPewPew
            _testPewPew.RemoveFromCanvas();
            _testPewPew.SetMovingDirection();
            _testPewPew.Move();
            _testPewPew.Show();

            // _testPowerUp
            _testPowerUp.RemoveFromCanvas();
            _testPowerUp.SetMovingDirection();
            _testPowerUp.Move();
            _testPowerUp.Show();
        }
    }
}