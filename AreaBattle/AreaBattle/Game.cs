using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AreaBattle
{
    public class Game : ContentPage
    {

        public Game()
        {
            Draw.SetColors(out List<Color> colors);
            Canvas.Generate(out Grid layout, out Grid canvas, out Grid gameUI, out Grid timeBar, out Grid scoreBar);
            Draw.StartTiles(canvas, colors);
            Player.Start(out Color playerOne, out Color playerTwo);
            Device.StartTimer(TimeSpan.FromSeconds(1.0), () => UpdateTime(gameUI, timeBar));
            UI.Buttons(colors, gameUI, playerOne, playerTwo);
            UI.Score(gameUI, scoreBar);
            Sound.Play();

            layout.Children.Add(canvas, 0, 0);
            layout.Children.Add(gameUI, 0, 1);
            Content = layout;
        }

        private static bool UpdateTime(Grid gameUI, Grid timeBar)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                UI.Time(gameUI, timeBar);
            });
            return true;
        }
    }
}