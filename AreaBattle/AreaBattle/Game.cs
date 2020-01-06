using System;
using Xamarin.Forms;

namespace AreaBattle
{
    public class Game : ContentPage
    {

        public Game()
        {
            Canvas.Generate();
            Draw.Tiles();
            Player.Start();
            Device.StartTimer(TimeSpan.FromSeconds(1.00), UpdateTime);
            UI.InitializeButtons();
            UI.InitializeScore();
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