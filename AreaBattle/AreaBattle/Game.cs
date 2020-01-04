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
            Canvas.Generate(out Grid layout, out Grid canvas, out Grid interFace, out Grid time, out Grid score);
            Draw.Tile(canvas, colors);
            Player.Start();
            Device.StartTimer(TimeSpan.FromSeconds(1.0), () => UpdateTime(interFace, time));
            UI.Buttons(colors, interFace, Player.One, Player.Two);
            UI.Score(interFace, score);
            Sound.Play();

            layout.Children.Add(canvas, 0, 0);
            layout.Children.Add(interFace, 0, 1);
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