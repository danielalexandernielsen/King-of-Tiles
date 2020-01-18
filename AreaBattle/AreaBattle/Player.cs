using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AreaBattle
{
    class Player
    {
        public static int turn;
        public static bool gameOver = false;
        public static Color oneColor;
        public static Color twoColor;

        public static HashSet<Tuple<int, int>> oneScore = new HashSet<Tuple<int, int>>();
        public static HashSet<Tuple<int, int>> twoScore = new HashSet<Tuple<int, int>>();

        public static int X { get { return Player.turn == 1 ? 29 : 1; } }
        public static int Y { get { return Player.turn == 1 ? 40 : 1; } }
        public static Color Color
        {
            get { return Player.turn == 1 ? oneColor : twoColor; }
            set { _ = (Player.turn == 1 ? oneColor = value : twoColor = value); }
        }

        public static HashSet<Tuple<int, int>> Score
        {
            get { return Player.turn == 1 ? oneScore : twoScore; }
            set { _ = (Player.turn == 1 ? oneScore = value : twoScore = value); }
        }

        public static void Start()
        {
            Player.oneColor = Draw.canvasData[29, 40].Color;
            Player.twoColor = Draw.canvasData[1, 1].Color;

            if (Player.oneColor == Player.twoColor)
                while (Player.oneColor == Player.twoColor)
                {
                    Player.oneColor = Draw.colors[Draw.randomize.Next(0, 5)];
                    Player.twoColor = Draw.colors[Draw.randomize.Next(0, 5)];
                }             

            Draw.canvasData[1, 1].Color = Player.twoColor;
            Draw.canvasData[1, 2].Color = Player.twoColor;
            Draw.canvasData[2, 1].Color = Player.twoColor;

            Draw.canvasData[29, 40].Color = Player.oneColor;
            Draw.canvasData[29, 39].Color = Player.oneColor;
            Draw.canvasData[28, 40].Color = Player.oneColor;

            Player.turn = Draw.randomize.Next(1, 3);
        }

        public static int ChangeTurn() => Player.turn == 1 ? Player.turn = 2 : Player.turn = 1;

        public static void Move(Button button)
        {
            Color originalColor = Player.Color;
            Color replacementColor = button.BackgroundColor;
            bool resetCountdown = true;

            Draw.Update(replacementColor, originalColor, Player.X, Player.Y);
            Player.Color = replacementColor;
            UI.UpdateButtons();
            UI.UpdateScore(replacementColor, Player.Score);
            Player.ChangeTurn();
            UI.Time(resetCountdown);
        }

        public static void AutoMove()
        {
            Color autoPickColor;
            
            while (true)
            {
                autoPickColor = Draw.colors[Draw.randomize.Next(0, 5)];

                if (autoPickColor != Player.oneColor && autoPickColor != Player.twoColor)
                    break;                   
            }

            foreach (var button in UI.buttons)
            {
                if (button.Item1.BackgroundColor == autoPickColor)
                {
                    Player.Move(button.Item1);
                    break;
                }
            }
        }
    }
}