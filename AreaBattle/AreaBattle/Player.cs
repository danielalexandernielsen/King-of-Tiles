using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace AreaBattle
{
    class Player
    {

        static HashSet<Tuple<Color, int, int>> player1Tiles = new HashSet<Tuple<Color, int, int>>();
        public static HashSet<Tuple<Color, int, int>> player1TilesEdge = new HashSet<Tuple<Color, int, int>>();
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

            player1Tiles.Add(new Tuple<Color, int, int>(playerOneColor, 28, 36));
            player2Tiles.Add(new Tuple<Color, int, int>(playerTwoColor, 0, 0));

            FindOwnedArea();
        }

        static void FindOwnedArea()
        {
            bool foundNewTile = true;
            player1TilesEdge.Clear();

            while (foundNewTile == true)
            {
                for (int tile = 0; tile < player1Tiles.Count; tile++)
                {
                    foundNewTile = false;
                    Color playerOneColor = player1Tiles.ElementAt(tile).Item1;
                    int x = player1Tiles.ElementAt(tile).Item2;
                    int y = player1Tiles.ElementAt(tile).Item3;

                    if (y - 1 >= 0)
                        if (Draw.canvasData[x, y - 1] == playerOneColor)
                            foundNewTile = player1Tiles.Add(new Tuple<Color, int, int>(playerOneColor, x, y - 1));
                        else
                            player1TilesEdge.Add(new Tuple<Color, int, int>(playerOneColor, x, y));

                    if (y + 1 <= 36)
                        if (Draw.canvasData[x, y + 1] == playerOneColor)
                            foundNewTile = player1Tiles.Add(new Tuple<Color, int, int>(playerOneColor, x, y + 1));
                        else
                            player1TilesEdge.Add(new Tuple<Color, int, int>(playerOneColor, x, y));

                    if (x - 1 >= 0)
                        if (Draw.canvasData[x - 1, y] == playerOneColor)
                            foundNewTile = player1Tiles.Add(new Tuple<Color, int, int>(playerOneColor, x - 1, y));
                        else
                            player1TilesEdge.Add(new Tuple<Color, int, int>(playerOneColor, x, y));

                    if (x + 1 <= 28)
                        if (Draw.canvasData[x + 1, y] == playerOneColor)
                            foundNewTile = player1Tiles.Add(new Tuple<Color, int, int>(playerOneColor, x + 1, y));
                        else
                            player1TilesEdge.Add(new Tuple<Color, int, int>(playerOneColor, x, y));
                }
            }
        }


        public static void SwitchColor(Color colorFromButton)
        {
            for (int tile = 0; tile < player1Tiles.Count; tile++)
            {
                int x = player1Tiles.ElementAt(tile).Item2;
                int y = player1Tiles.ElementAt(tile).Item3;

                player1Tiles.Remove(player1Tiles.ElementAt(tile));
                player1Tiles.Add(new Tuple<Color, int, int>(colorFromButton, x, y));
            }

            FindOwnedArea();
            Draw.Tiles(player1Tiles);
            UI.UpdateScore(colorFromButton, player1Tiles.Count);
        }
    }
}