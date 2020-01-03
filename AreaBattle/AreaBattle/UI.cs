using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AreaBattle
{
    class UI
    {
        public static void Buttons(List<Color> colors, Grid gameUI, Color playerOne, Color playerTwo)
        {
            var buttonRed = new Button { BackgroundColor = colors[0] };
            buttonRed.Clicked += Player.ClickedRed;
            // if (playerOne != buttonRed.BackgroundColor && playerTwo != buttonRed.BackgroundColor)
            gameUI.Children.Add(buttonRed, 1, 3);

            var buttonGreen = new Button { BackgroundColor = colors[1] };
            buttonGreen.Clicked += Player.ClickedGreen;
            // if (playerOne != buttonGreen.BackgroundColor && playerTwo != buttonGreen.BackgroundColor)
            gameUI.Children.Add(buttonGreen, 2, 3);

            var buttonBlue = new Button { BackgroundColor = colors[2] };
            buttonBlue.Clicked += Player.ClickedBlue;
            // if (playerOne != buttonBlue.BackgroundColor && playerTwo != buttonBlue.BackgroundColor)
            gameUI.Children.Add(buttonBlue, 3, 3);

            var buttonOrange = new Button { BackgroundColor = colors[3] };
            buttonOrange.Clicked += Player.ClickedOrange;
            // if (playerOne != buttonOrange.BackgroundColor && playerTwo != buttonOrange.BackgroundColor)
            gameUI.Children.Add(buttonOrange, 4, 3);

            var buttonPurple = new Button { BackgroundColor = colors[4] };
            buttonPurple.Clicked += Player.ClickedPurple;
            // if (playerOne != buttonPurple.BackgroundColor && playerTwo != buttonPurple.BackgroundColor)
            gameUI.Children.Add(buttonPurple, 5, 3);
        }

        static int second = 0;

        public static void Time(Grid gameUI, Grid timeBar)

        {
            if (second == 0 || second == 60)
            {
                for (int i = 0; i < 60; i++)
                {
                    timeBar.Children.Add(new BoxView { Color = Color.Gray }, i, 0);
                    gameUI.Children.Add(timeBar, 1, 1);
                    Grid.SetColumnSpan(timeBar, 5);
                    second = 0;
                }
            }

            timeBar.Children.Add(new BoxView { Color = Color.FromHex("E9E2D7") }, 59 - second, 0);
            second++;
        }

        static Grid catchGameUI;
        static Grid catchScoreBar;

        public static void Score(Grid gameUI, Grid scoreBar)
        {
            catchGameUI = gameUI;
            catchScoreBar = scoreBar;

            catchScoreBar.Children.Add(new BoxView { Color = Color.Gray }, 50, 0);
            catchGameUI.Children.Add(catchScoreBar, 1, 5);
            Grid.SetColumnSpan(catchScoreBar, 5);
        }

        public static void UpdateScore(Color colorFromButton, int nrOfOwnedTiles)
        {
            double player1percentage = nrOfOwnedTiles / 10.73;

            for (int score = 0; score < Convert.ToInt32(player1percentage); score++)
                catchScoreBar.Children.Add(new BoxView { Color = colorFromButton }, score, 0);

            catchGameUI.Children.Add(catchScoreBar, 1, 5);
            Grid.SetColumnSpan(catchScoreBar, 5);
        }
    }
}