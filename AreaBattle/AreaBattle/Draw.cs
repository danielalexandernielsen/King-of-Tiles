using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace AreaBattle
{
    class Draw
    {
        public static Color[,] canvasData = new Color[29, 37];
        public static int canvasWidth = canvasData.GetLength(0);
        public static int canvasHeight = canvasData.GetLength(1);
        static Random randomize = new Random();
        static Grid catchCanvas;

        public static void StartField(List<Color> colors, Grid canvas)
        {
            catchCanvas = canvas;

            for (int row = 0; row < canvasWidth; row++)
            {
                for (int col = 0; col < canvasHeight; col++)
                {
                    canvasData[row, col] = colors[randomize.Next(0, 5)];

                    if (row > 0 && col > 0)
                    {
                        if ((canvasData[row, col] != canvasData[row, col - 1]) && (canvasData[row, col] != canvasData[row - 1, col]))
                            canvasData[row, col] = colors[randomize.Next(0, 5)];
                    }
                    else if (row == 0 && col > 0)
                    {
                        if (canvasData[row, col] != canvasData[row, col - 1])
                            canvasData[row, col] = colors[randomize.Next(0, 5)];
                    }
                    else if (col == 0 && row > 0)
                    {
                        if (canvasData[row, col] != canvasData[row - 1, col])
                            canvasData[row, col] = colors[randomize.Next(0, 5)];
                    }

                    canvas.Children.Add(new Image { BackgroundColor = canvasData[row, col] }, row, col);
                }
            }
        }

        public static void PlayerAreaExpansion(HashSet<Tuple<Color, int, int>> playerOneTiles)
        {
            for (int tile = 0; tile < playerOneTiles.Count; tile++)
            {
                Color color = playerOneTiles.ElementAt(tile).Item1;
                int x = playerOneTiles.ElementAt(tile).Item2;
                int y = playerOneTiles.ElementAt(tile).Item3;

                canvasData[x, y] = color;
                catchCanvas.Children.Add(new Image { BackgroundColor = canvasData[x, y] }, x, y);
            }
        }


        public static void SetColors(out List<Color> colors)
        {
            colors = new List<Color>();
            colors.Add(Color.FromHex("DA0032")); // Red
            colors.Add(Color.FromHex("0AA174")); // Green
            colors.Add(Color.FromHex("3465AA")); // Blue
            colors.Add(Color.FromHex("EB9B00")); // Orange
            colors.Add(Color.FromHex("7C378A")); // Purple
        }
    }
}