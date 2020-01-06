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

        public static List<Tuple<Button, int, int>> buttons = new List<Tuple<Button, int, int>>
            {
            new Tuple<Button, int, int>(buttonRed, 1, 3),
            new Tuple<Button, int, int>(buttonGreen, 2, 3),
            new Tuple<Button, int, int>(buttonBlue, 3, 3),
            new Tuple<Button, int, int>(buttonOrange, 4, 3),
            new Tuple<Button, int, int>(buttonPurple, 5, 3),
        };

        public static void InitializeButtons()
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

                if (Player.oneColor == button.BackgroundColor || Player.twoColor == button.BackgroundColor)
                    Canvas.interFace.Children.Remove(button);
                else
                    if (Canvas.interFace.Children.Contains(button) == false)
                    Canvas.interFace.Children.Add(button, x, y);
            }
        }


        static int second = 0;
        static BoxView[] timeData = new BoxView[60];
        static bool timeBarDrawn = false;

        public static void Time(bool resetTime = false)
        {
            if (second == 0 || second == 60 || resetTime == true)
            {
                for (int x = 0; x < 60; x++)
                {
                    if (timeBarDrawn == false)
                    {
                        timeData[x] = new BoxView { Color = Color.Gray };
                        Canvas.time.Children.Add(timeData[x], x, 0);
                    }
                    else
                    {
                        timeData[x].Color = Color.Gray;
                        Canvas.time.Children.Add(timeData[x], x, 0);
                    }
                }

                if (second == 60)
                {
                    second = 0;
                    Player.AutoMove();
                }

                second = 0;
                timeBarDrawn = true;
            }

            int timeReversed = 59 - second;
            timeData[timeReversed].Color = Color.FromHex("E9E2D7");
            Canvas.interFace.Children.Add(Canvas.time, 1, 1);
            Grid.SetColumnSpan(Canvas.time, 5);

            second++;
        }


        static BoxView[] scoreData = new BoxView[101];

        public static void InitializeScore()
        {
            for (int x = 0; x <= 100; x++)
            {
                if (x == 50)
                {
                    scoreData[x] = new BoxView { Color = Color.Gray };
                    Canvas.score.Children.Add(scoreData[x], x, 0);
                }

                else
                {
                    scoreData[x] = new BoxView { Color = Color.FromHex("E9E2D7") };
                    Canvas.score.Children.Add(scoreData[x], x, 0);
                }
            }
            Canvas.interFace.Children.Add(Canvas.score, 1, 5);
            Grid.SetColumnSpan(Canvas.score, 5);
        }

        public static void UpdateScore(Color replacementColor, HashSet<Tuple<int, int>> playerScore)
        {
            int nrOfOwnedTiles = playerScore.Count;
            double currentScore = Math.Ceiling(nrOfOwnedTiles / 10.73);
            int divider = 50;

            for (int x = 0; x < (int)currentScore; x++)
            {
                if (Player.turn == 1)
                    scoreData[100 - x].Color = replacementColor;
                else
                    scoreData[x].Color = replacementColor;
            }

            Canvas.interFace.Children.Add(Canvas.score, 1, 5);
            Grid.SetColumnSpan(Canvas.score, 5);
        }
    }
}