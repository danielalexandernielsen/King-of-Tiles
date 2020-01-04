using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AreaBattle
{
    class UI
    {
        public static Button buttonRed = new Button { BackgroundColor = Draw.colors[0] };
        public static Button buttonGreen = new Button { BackgroundColor = Draw.colors[1] };
        public static Button buttonBlue = new Button { BackgroundColor = Draw.colors[2] };
        public static Button buttonOrange = new Button { BackgroundColor = Draw.colors[3] };
        public static Button buttonPurple = new Button { BackgroundColor = Draw.colors[4] };

        static List<Tuple<Button, int, int>> buttons = new List<Tuple<Button, int, int>>
            {
            new Tuple<Button, int, int>(buttonRed, 1, 3),
            new Tuple<Button, int, int>(buttonGreen, 2, 3),
            new Tuple<Button, int, int>(buttonBlue, 3, 3),
            new Tuple<Button, int, int>(buttonOrange, 4, 3),
            new Tuple<Button, int, int>(buttonPurple, 5, 3),
        };

        public static void InitializeButton()
        {
            buttonRed.Clicked += Player.ClickedRed;
            buttonGreen.Clicked += Player.ClickedGreen;
            buttonBlue.Clicked += Player.ClickedBlue;
            buttonOrange.Clicked += Player.ClickedOrange;
            buttonPurple.Clicked += Player.ClickedPurple;

            UpdateButtons();
        }

        public static void UpdateButtons()
        {
            foreach (var element in buttons)
            {
                Button button = element.Item1;
                int x = element.Item2;
                int y = element.Item3;

                if (Player.OneColor == button.BackgroundColor)
                    Canvas.interFace.Children.Remove(button);
                else
                    if (Canvas.interFace.Children.Contains(button) == false)
                        Canvas.interFace.Children.Add(button, x, y);
            }
        }


        static int second = 0;

        public static void Time()

        {
            if (second == 0 || second == 60)
            {
                for (int i = 0; i < 60; i++)
                {
                    Canvas.time.Children.Add(new BoxView { Color = Color.Gray }, i, 0);
                    Canvas.interFace.Children.Add(Canvas.time, 1, 1);
                    Grid.SetColumnSpan(Canvas.time, 5);
                    second = 0;
                }
            }

            Canvas.time.Children.Add(new BoxView { Color = Color.FromHex("E9E2D7") }, 59 - second, 0);
            second++;
        }


        public static void Score()
        {
            Canvas.score.Children.Add(new BoxView { Color = Color.Gray }, 50, 0);
            Canvas.interFace.Children.Add(Canvas.score, 1, 5);
            Grid.SetColumnSpan(Canvas.score, 5);
        }

        public static void UpdateScore(Color colorFromButton, int nrOfOwnedTiles)
        {
            double player1percentage = nrOfOwnedTiles / 10.73;

            for (int score = 0; score < Convert.ToInt32(player1percentage); score++)
                Canvas.score.Children.Add(new BoxView { Color = colorFromButton }, score, 0);

            Canvas.interFace.Children.Add(Canvas.score, 1, 5);
            Grid.SetColumnSpan(Canvas.score, 5);
        }
    }
}