using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AreaBattle
{
    public class Game : ContentPage
    {

        public Game()
        {
            Canvas.Generate();
            Draw.Tile();
            Player.Start();
            Device.StartTimer(TimeSpan.FromSeconds(1.0), UpdateTime);
            UI.InitializeButton();
            UI.Score();
            Sound.Play();

            Canvas.layout.Children.Add(Canvas.board, 0, 0);
            Canvas.layout.Children.Add(Canvas.interFace, 0, 1);
            Content = Canvas.layout;
        }

        private static bool UpdateTime()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                UI.Time();
            });
            return true;
        }
    }
}