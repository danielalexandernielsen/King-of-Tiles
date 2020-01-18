using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AreaBattle
{
    class Draw
    {
        public static BoxView[,] canvasData = new BoxView[30, 41];
        public static Color[,] colorData = new Color[30, 41];
        public static Random randomize = new Random();
        static int canvasWidth = canvasData.GetLength(0);
        static int canvasHeight = canvasData.GetLength(1);

        public static List<Color> colors = new List<Color>
            {
                Color.FromHex("DA0032"), // Red
                Color.FromHex("0AA174"), // Green
                Color.FromHex("3465AA"), // Blue
                Color.FromHex("EB9B00"), // Orange
                Color.FromHex("7C378A"), // Purple
            };

        public static void Tiles()
        {
            for (int x = 1; x < canvasWidth; x++)
            {
                for (int y = 1; y < canvasHeight; y++)
                {
                    colorData[x, y] = colors[randomize.Next(0, 5)];

                    if ((colorData[x, y] != colorData[x, y - 1]) && (colorData[x, y] != colorData[x - 1, y]))
                        colorData[x, y] = colors[randomize.Next(0, 5)];

                    canvasData[x, y] = new BoxView { Color = colorData[x, y] };
                    Canvas.board.Children.Add(canvasData[x, y], x - 1, y - 1);
                }
            }
        }

        public static void Update(Color replacementColor, Color sourceColor, int startX, int startY)
        {
            var Q = new Queue<Tuple<int, int>>();
            Q.Enqueue(new Tuple<int, int>(startX, startY));

            while (Q.Count > 0)
            {
                int x = Q.Peek().Item1;
                int y = Q.Peek().Item2;

                canvasData[x, y].Color = replacementColor;

                Q.Dequeue();
                Player.Score.Add(new Tuple<int, int>(x, y));

                if (y - 1 >= 1)
                    if (canvasData[x, y - 1].Color == sourceColor)
                    {
                        canvasData[x, y - 1].Color = replacementColor;
                        Q.Enqueue(new Tuple<int, int>(x, y - 1));
                    }

                if (y + 1 <= 40)
                    if (canvasData[x, y + 1].Color == sourceColor)
                    {
                        canvasData[x, y + 1].Color = replacementColor;
                        Q.Enqueue(new Tuple<int, int>(x, y + 1));
                    }

                if (x - 1 >= 1)
                    if (canvasData[x - 1, y].Color == sourceColor)
                    {
                        canvasData[x - 1, y].Color = replacementColor;
                        Q.Enqueue(new Tuple<int, int>(x - 1, y));
                    }

                if (x + 1 <= 29)
                    if (canvasData[x + 1, y].Color == sourceColor)
                    {
                        canvasData[x + 1, y].Color = replacementColor;
                        Q.Enqueue(new Tuple<int, int>(x + 1, y));
                    }
            }
        }



        public static void GameOver()
        {
            Canvas.board.Opacity = 0.2;

            Label winner = new Label
            {
                TextColor = Player.Color,
                FontFamily = "pixelated.ttf#Pixelated",
                FontSize = 110,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            if (Player.turn == 1)            
                winner.Text = " WINNER\n" + "   PLAYER\n" + "       ONE!";            
            else
                winner.Text = " WINNER\n" + "   PLAYER\n" + "       TWO!";

            Canvas.layout.Children.Add(winner, 0, 0);
            Player.gameOver = true;
        }
    }
}