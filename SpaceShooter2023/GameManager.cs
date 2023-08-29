using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Threading;

namespace SpaceShooter2023
{
    public static class GameManager
    {
        private static int _gameSpeed { get; set; }
        private static DispatcherTimer _timer { get; set; }
        public static void Initialize()
        {
            // Game Speed
            _timer = new DispatcherTimer();
            _gameSpeed = Global.StartSpeed;
            SpeedManager(0);
            _timer.Tick += OnTick;




            _timer.Start();
        }

        private static void OnTick(object sender, EventArgs e)
        {
            Global.TextBlockScore.Text = "Score: " + Global.Score++;
        }

        private static void SpeedManager(int pDeltaSpeed)
        {
            if (_gameSpeed + pDeltaSpeed <= 1)
                _gameSpeed = 1;
            _gameSpeed = _gameSpeed + pDeltaSpeed;

            _timer.Interval = new TimeSpan(0, 0, 0, 0, _gameSpeed);
        }
    }
}