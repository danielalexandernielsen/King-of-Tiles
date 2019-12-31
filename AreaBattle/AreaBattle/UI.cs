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

            var buttonGreen = new Button { BackgroundColor = colors[1] };
            buttonGreen.Clicked += Player.ClickedGreen;

            var buttonBlue = new Button { BackgroundColor = colors[2] };
            buttonBlue.Clicked += Player.ClickedBlue;

            var buttonOrange = new Button { BackgroundColor = colors[3] };
            buttonOrange.Clicked += Player.ClickedOrange;

            var buttonPurple = new Button { BackgroundColor = colors[4] };
            buttonPurple.Clicked += Player.ClickedPurple;

            // if (playerOne != buttonRed.BackgroundColor && playerTwo != buttonRed.BackgroundColor)
            gameUI.Children.Add(buttonRed, 1, 3);

            // if (playerOne != buttonGreen.BackgroundColor && playerTwo != buttonGreen.BackgroundColor)
            gameUI.Children.Add(buttonGreen, 2, 3);

            // if (playerOne != buttonBlue.BackgroundColor && playerTwo != buttonBlue.BackgroundColor)
            gameUI.Children.Add(buttonBlue, 3, 3);

            // if (playerOne != buttonOrange.BackgroundColor && playerTwo != buttonOrange.BackgroundColor)
            gameUI.Children.Add(buttonOrange, 4, 3);

            // if (playerOne != buttonPurple.BackgroundColor && playerTwo != buttonPurple.BackgroundColor)
            gameUI.Children.Add(buttonPurple, 5, 3);
        }

        static int second = 0;
        static Color[] timeArray = new Color[60];

        public static void Time(Grid gameUI, Grid timeBar)

        {
            if (second == 0 || second == 60)
            {
                for (int i = 0; i < 60; i++)
                {
                    timeArray[i] = Color.Gray;
                    timeBar.Children.Add(new Image { BackgroundColor = timeArray[i] }, i, 0);
                    second = 0;

                    gameUI.Children.Add(timeBar, 1, 1);
                    Grid.SetColumnSpan(timeBar, 5);
                }
            }

            int time = 59 - second;

            timeArray[time] = Color.FromHex("E9E2D7");
            timeBar.Children.Add(new Image { BackgroundColor = timeArray[time] }, time, 0);
            second++;
        }

        static Color[] scoreArray = new Color[100];
        static Grid catchGameUI;
        static Grid catchScoreBar;

        public static void SetStartScore(Grid gameUI, Grid scoreBar)
        {
            catchGameUI = gameUI;
            catchScoreBar = scoreBar;

            for (int score = 0; score < scoreArray.Length; score++)
                scoreBar.Children.Add(new Image { BackgroundColor = Color.Gray }, score, 0);

            gameUI.Children.Add(scoreBar, 1, 5);
            Grid.SetColumnSpan(scoreBar, 5);
        }

        public static void UpdateScore(Color colorFromButton, int nrOfOwnedTiles)
        {
            double player1percentage = nrOfOwnedTiles / 10.73;

            System.Diagnostics.Debug.WriteLine("nrOfOwnedTiles: ");
            System.Diagnostics.Debug.WriteLine(nrOfOwnedTiles);
            System.Diagnostics.Debug.WriteLine("player1percentage: ");
            System.Diagnostics.Debug.WriteLine(player1percentage);

            for (int score = 0; score < Convert.ToInt32(player1percentage); score++)
                catchScoreBar.Children.Add(new Image { BackgroundColor = colorFromButton }, score, 0);

            catchGameUI.Children.Add(catchScoreBar, 1, 5);
            Grid.SetColumnSpan(catchScoreBar, 5);
        }
    }
}