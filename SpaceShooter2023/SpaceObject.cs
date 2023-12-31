﻿using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SpaceShooter2023
{
    public abstract class SpaceObject
    {
        // FELDER
        public Polygon Shape = new Polygon();

        // EIGENSCHAFTEN
        public int X_Position { get; set; }
        public int Y_Position { get; set; }
        public int X_Vector { get; set; }
        public int Y_Vector { get; set; }
        public bool Alive {  get; set; }
        

        // METHODEN
        public void Show()
        {
            Canvas.SetLeft(Shape, X_Position);
            Canvas.SetTop(Shape, Y_Position);

            Global.SpaceCanvas.Children.Add(Shape);

        }

        public void RemoveFromCanvas()
        {
            Global.SpaceCanvas.Children.Remove(Shape);
        }

        public void Move()
        {
            X_Position = X_Position + X_Vector;
            Y_Position = Y_Position + Y_Vector;

            // Check if the object is going out of bounds
            if (X_Position < 0)
            {
                X_Position = 0;
            }
            else if (X_Position > Global.SpaceCanvas.ActualWidth - Shape.ActualWidth)
            {
                X_Position = (int)(Global.SpaceCanvas.ActualWidth - Shape.ActualWidth);
            }

            if (Y_Position < 0)
            {
                Y_Position = 0;
            }
            else if (Y_Position > Global.SpaceCanvas.ActualHeight - Shape.ActualHeight)
            {
                Y_Position = (int)(Global.SpaceCanvas.ActualHeight - Shape.ActualHeight);
            }
        }
    }
}