using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace AreaBattle
{
    class Draw
    {
        public static Color[,] canvasData = new Color[29, 37];
        static int canvasWidth = canvasData.GetLength(0);
        static int canvasHeight = canvasData.GetLength(1);
        static Random randomize = new Random();
        public static Grid catchCanvas;

        public static void Tile(Grid canvas, List<Color> colors)
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

                    canvas.Children.Add(new BoxView { Color = canvasData[row, col] }, row, col);
                }
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