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

            // Asteroide
            for (int i = 0; i < Global.NumberOfAsteroids; i++)
            {
                Global.ListWithAsteroids.Add(new Asteroid());
                Global.ListWithAsteroids[i].Design();
            }

            // _testPowerUp
            _testPowerUp = new PowerUp();
            _testPowerUp.Design();
        }

        public static void GameOver()
        {
            _timer.Stop();
            MessageBox.Show("Game Over");
        }
        private static void OnTick(object sender, EventArgs e)
        {
            // player
            player.RemoveFromCanvas();
            player.SetMovingDirection();
            player.LetThePewPewFly();
            player.Move();
            player.Show();

            // Asteroide
            for (int i = Global.ListWithAsteroids.Count - 1; i >= 0; i--)
            {
                var asteroid = Global.ListWithAsteroids[i];
                asteroid.RemoveFromCanvas();
                if (asteroid.OutOfGame())
                {
                    Global.ListWithAsteroids.RemoveAt(i);
                    var newAsteroid = new Asteroid();
                    newAsteroid.Design();
                    Global.ListWithAsteroids.Insert(i, newAsteroid);
                    continue;
                }

                asteroid.PewPewCol();
                asteroid.Move();
                asteroid.Show();
            }

            // _testPowerUp
            _testPowerUp.RemoveFromCanvas();
            _testPowerUp.SetMovingDirection();
            _testPowerUp.OutOfLevel();
            _testPowerUp.Move();
            _testPowerUp.Show();
        }
    }
}