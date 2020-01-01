using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace AreaBattle
{
    class Player
    {

        public static HashSet<Tuple<Color, int, int>> coreTiles = new HashSet<Tuple<Color, int, int>>();
        public static HashSet<Tuple<Color, int, int>> edgeTiles = new HashSet<Tuple<Color, int, int>>();
        public static HashSet<Tuple<Color, int, int>> newTiles = new HashSet<Tuple<Color, int, int>>();
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

            FindOwnedArea();
        }

        static void FindOwnedArea()
        {
            bool foundNewTile = true;

            edgeTiles.Clear();
            newTiles.Clear();

            while (foundNewTile == true)
            {
                for (int tile = 0; tile < coreTiles.Count; tile++)
                {
                    foundNewTile = false;

                    Color playerColor = coreTiles.ElementAt(tile).Item1;
                    int x = coreTiles.ElementAt(tile).Item2;
                    int y = coreTiles.ElementAt(tile).Item3;

                    Tuple<Color, int, int> thisTile = new Tuple<Color, int, int>(playerColor, x, y);

                    if (y - 1 >= 0)
                        if (Draw.canvasData[x, y - 1] == playerColor)
                        {
                            foundNewTile = coreTiles.Add(new Tuple<Color, int, int>(playerColor, x, y - 1));
                            newTiles.Add(new Tuple<Color, int, int>(playerColor, x, y - 1));
                        }
                        else
                            edgeTiles.Add(new Tuple<Color, int, int>(playerColor, x, y));

                    if (y + 1 <= 36)
                        if (Draw.canvasData[x, y + 1] == playerColor)
                        {
                            foundNewTile = coreTiles.Add(new Tuple<Color, int, int>(playerColor, x, y + 1));
                            newTiles.Add(new Tuple<Color, int, int>(playerColor, x, y + 1));
                        }
                        else
                            edgeTiles.Add(new Tuple<Color, int, int>(playerColor, x, y));

                    if (x - 1 >= 0)
                        if (Draw.canvasData[x - 1, y] == playerColor)
                        {
                            foundNewTile = coreTiles.Add(new Tuple<Color, int, int>(playerColor, x - 1, y));
                            newTiles.Add(new Tuple<Color, int, int>(playerColor, x - 1, y));
                        }
                        else
                            edgeTiles.Add(new Tuple<Color, int, int>(playerColor, x, y));

                    if (x + 1 <= 28)
                        if (Draw.canvasData[x + 1, y] == playerColor)
                        {
                            foundNewTile = coreTiles.Add(new Tuple<Color, int, int>(playerColor, x + 1, y));
                            newTiles.Add(new Tuple<Color, int, int>(playerColor, x + 1, y));
                        }
                        else
                            edgeTiles.Add(new Tuple<Color, int, int>(playerColor, x, y));
                }
            }
        }


        public static void SwitchColor(Color colorFromButton)
        {
            for (int tile = 0; tile < coreTiles.Count; tile++)
            {
                int x = coreTiles.ElementAt(tile).Item2;
                int y = coreTiles.ElementAt(tile).Item3;

                Draw.canvasData[x, y] = colorFromButton;
                coreTiles.Remove(coreTiles.ElementAt(tile));
                coreTiles.Add(new Tuple<Color, int, int>(colorFromButton, x, y));
            }

            FindOwnedArea();
            Draw.Tile(coreTiles);
            UI.UpdateScore(colorFromButton, coreTiles.Count);
        }
    }
}