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

            canvasData[6, 2].Color = Player.Color; canvasData[7, 2].Color = Player.Color; canvasData[8, 2].Color = Player.Color;
            canvasData[9, 2].Color = Player.Color; canvasData[10, 3].Color = Player.Color; canvasData[8, 4].Color = Player.Color;
            canvasData[9, 4].Color = Player.Color; canvasData[10, 5].Color = Player.Color; canvasData[6, 6].Color = Player.Color;
            canvasData[7, 6].Color = Player.Color; canvasData[8, 6].Color = Player.Color; canvasData[9, 6].Color = Player.Color;

            canvasData[6, 8].Color = Player.Color; canvasData[6, 10].Color = Player.Color; canvasData[6, 13].Color = Player.Color;
            canvasData[7, 8].Color = Player.Color; canvasData[7, 10].Color = Player.Color; canvasData[7, 13].Color = Player.Color;
            canvasData[8, 8].Color = Player.Color; canvasData[8, 10].Color = Player.Color; canvasData[8, 13].Color = Player.Color;
            canvasData[9, 8].Color = Player.Color; canvasData[9, 10].Color = Player.Color; canvasData[9, 13].Color = Player.Color;
            canvasData[10, 8].Color = Player.Color; canvasData[10, 10].Color = Player.Color; canvasData[10, 13].Color = Player.Color;

            canvasData[6, 15].Color = Player.Color; canvasData[6, 18].Color = Player.Color; canvasData[6, 20].Color = Player.Color;
            canvasData[7, 15].Color = Player.Color; canvasData[7, 18].Color = Player.Color; canvasData[7, 20].Color = Player.Color;
            canvasData[8, 15].Color = Player.Color; canvasData[8, 18].Color = Player.Color; canvasData[8, 20].Color = Player.Color;
            canvasData[9, 15].Color = Player.Color; canvasData[9, 18].Color = Player.Color; canvasData[9, 20].Color = Player.Color;
            canvasData[10, 15].Color = Player.Color; canvasData[10, 18].Color = Player.Color; canvasData[10, 20].Color = Player.Color;

            canvasData[6, 24].Color = Player.Color; canvasData[7, 24].Color = Player.Color; canvasData[8, 24].Color = Player.Color;
            canvasData[9, 24].Color = Player.Color; canvasData[10, 24].Color = Player.Color;

            canvasData[7, 11].Color = Player.Color; canvasData[8, 12].Color = Player.Color; canvasData[7, 16].Color = Player.Color; 
            canvasData[8, 17].Color = Player.Color; canvasData[6, 21].Color = Player.Color; canvasData[8, 21].Color = Player.Color;
            canvasData[10, 21].Color = Player.Color; canvasData[6, 25].Color = Player.Color; canvasData[8, 25].Color = Player.Color;
            canvasData[6, 26].Color = Player.Color; canvasData[7, 26].Color = Player.Color; canvasData[9, 26].Color = Player.Color;
            canvasData[10, 26].Color = Player.Color;



            for (int x = 12; x <= 26; x++)
                canvasData[x, 2].Color = Player.Color;


            for (int x = 12; x <= 26; x++)
                canvasData[x, 33].Color = Player.Color;




        }
    }
}