using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AreaBattle
{
    class Player
    {
        public static void ClickedRed(object sender, EventArgs e) { FillColorAndUpdateButtons(UI.buttonRed); }
        public static void ClickedGreen(object sender, EventArgs e) { FillColorAndUpdateButtons(UI.buttonGreen); }
        public static void ClickedBlue(object sender, EventArgs e) { FillColorAndUpdateButtons(UI.buttonBlue); }
        public static void ClickedOrange(object sender, EventArgs e) { FillColorAndUpdateButtons(UI.buttonOrange); }
        public static void ClickedPurple(object sender, EventArgs e) { FillColorAndUpdateButtons(UI.buttonPurple); }

        public static Color OneColor;
        public static Color TwoColor;
        public static HashSet<Tuple<int, int>> oneScore = new HashSet<Tuple<int, int>>();
        public static HashSet<Tuple<int, int>> twoScore = new HashSet<Tuple<int, int>>();

        public static void Start()
        {
            Player.OneColor = Draw.canvasData[28, 36].Color;
            Player.TwoColor = Draw.canvasData[0, 0].Color;
        }

        public static void FillColorAndUpdateButtons(Button button)
        {
            Color replacementColor = button.BackgroundColor;
            Color originalColor = Player.OneColor;

            Draw.Update(replacementColor, originalColor, 28, 36);
            Player.OneColor = replacementColor;
            UI.UpdateButtons();
            UI.UpdateScore(replacementColor, Player.oneScore);
        }
    }
}