using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace AreaBattle
{
    class Player
    {

        public static HashSet<Tuple<Color, int, int>> coreTiles = new HashSet<Tuple<Color, int, int>>();
        static HashSet<Tuple<Color, int, int>> player2Tiles = new HashSet<Tuple<Color, int, int>>();

        public static void ClickedRed(object sender, EventArgs e) { SwitchColor(Color.FromHex("DA0032")); }
        public static void ClickedGreen(object sender, EventArgs e) { SwitchColor(Color.FromHex("0AA174")); }
        public static void ClickedBlue(object sender, EventArgs e) { SwitchColor(Color.FromHex("3465AA")); }
        public static void ClickedOrange(object sender, EventArgs e) { SwitchColor(Color.FromHex("EB9B00")); }
        public static void ClickedPurple(object sender, EventArgs e) { SwitchColor(Color.FromHex("7C378A")); }


        public static void Start(out Color playerOneColor, out Color playerTwoColor)
        {
            playerOneColor = Draw.canvasData[28, 36];
            playerTwoColor = Draw.canvasData[0, 0];

            coreTiles.Add(new Tuple<Color, int, int>(playerOneColor, 28, 36));
            player2Tiles.Add(new Tuple<Color, int, int>(playerTwoColor, 0, 0));
        }


        public static void SwitchColor(Color colorFromButton)
        {
            Color originalColor = Draw.canvasData[28, 36];
            FindOwnedArea(colorFromButton, originalColor, 28, 36);
        }


        static void FindOwnedArea(Color replacementColor, Color originalColor, int startX, int startY)
        {

            var Q = new Queue<Tuple<int, int>>();
            Q.Enqueue(new Tuple<int, int>(startX, startY));

            while (Q.Count > 0)
            {
                int x = Q.Peek().Item1;
                int y = Q.Peek().Item2;

                Q.Dequeue();

                if (replacementColor == originalColor)
                    return;

                if (y - 1 >= 0)
                    if (Draw.canvasData[x, y - 1] == originalColor)
                    {
                        Draw.canvasData[x, y - 1] = replacementColor;
                        Draw.catchCanvas.Children.Add(new BoxView { Color = replacementColor }, x, y - 1);
                        Q.Enqueue(new Tuple<int, int>(x, y - 1));
                    }

                if (y + 1 <= 36)
                    if (Draw.canvasData[x, y + 1] == originalColor)
                    {
                        Draw.canvasData[x, y + 1] = replacementColor;
                        Draw.catchCanvas.Children.Add(new BoxView { Color = replacementColor }, x, y + 1);
                        Q.Enqueue(new Tuple<int, int>(x, y + 1));
                    }

                if (x - 1 >= 0)
                    if (Draw.canvasData[x - 1, y] == originalColor)
                    {
                        Draw.canvasData[x - 1, y] = replacementColor;
                        Draw.catchCanvas.Children.Add(new BoxView { Color = replacementColor }, x - 1, y);
                        Q.Enqueue(new Tuple<int, int>(x - 1, y));
                    }

                if (x + 1 <= 28)
                    if (Draw.canvasData[x + 1, y] == originalColor)
                    {
                        Draw.canvasData[x + 1, y] = replacementColor;
                        Draw.catchCanvas.Children.Add(new BoxView { Color = replacementColor }, x + 1, y);
                        Q.Enqueue(new Tuple<int, int>(x + 1, y));
                    }
            }
        }
    }
}