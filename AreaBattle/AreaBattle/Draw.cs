using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AreaBattle
{
    class Draw
    {
        public static BoxView[,] canvasData = new BoxView[29, 37];
        public static Color[,] colorData = new Color[29, 37];
        static int canvasWidth = canvasData.GetLength(0);
        static int canvasHeight = canvasData.GetLength(1);
        static Random randomize = new Random();

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
            for (int row = 0; row < canvasWidth; row++)
            {
                for (int col = 0; col < canvasHeight; col++)
                {
                    colorData[row, col] = colors[randomize.Next(0, 5)];

                    if (row > 0 && col > 0)
                    {
                        if ((colorData[row, col] != colorData[row, col - 1]) && (colorData[row, col] != colorData[row - 1, col]))
                            colorData[row, col] = colors[randomize.Next(0, 5)];
                    }
                    else if (row == 0 && col > 0)
                    {
                        if (colorData[row, col] != colorData[row, col - 1])
                            colorData[row, col] = colors[randomize.Next(0, 5)];
                    }
                    else if (col == 0 && row > 0)
                    {
                        if (colorData[row, col] != colorData[row - 1, col])
                            colorData[row, col] = colors[randomize.Next(0, 5)];
                    }

                    canvasData[row, col] = new BoxView { Color = colorData[row, col] };
                    Canvas.board.Children.Add(canvasData[row, col], row, col);
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

                if (y - 1 >= 0)
                    if (canvasData[x, y - 1].Color == sourceColor)
                    {
                        canvasData[x, y - 1].Color = replacementColor;
                        Q.Enqueue(new Tuple<int, int>(x, y - 1));
                    }

                if (y + 1 <= 36)
                    if (canvasData[x, y + 1].Color == sourceColor)
                    {
                        canvasData[x, y + 1].Color = replacementColor;
                        Q.Enqueue(new Tuple<int, int>(x, y + 1));
                    }

                if (x - 1 >= 0)
                    if (canvasData[x - 1, y].Color == sourceColor)
                    {
                        canvasData[x - 1, y].Color = replacementColor;
                        Q.Enqueue(new Tuple<int, int>(x - 1, y));
                    }

                if (x + 1 <= 28)
                    if (canvasData[x + 1, y].Color == sourceColor)
                    {
                        canvasData[x + 1, y].Color = replacementColor;
                        Q.Enqueue(new Tuple<int, int>(x + 1, y));
                    }
            }
        }
    }
}