using System;
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
        public static int OneScore;
        public static int TwoScore;

        public static void Start()
        {
            Player.OneColor = Draw.canvasData[28, 36].Color;
            Player.TwoColor = Draw.canvasData[0, 0].Color;
        }

        public static void FillColorAndUpdateButtons(Button button)
        {
            Draw.Update(button.BackgroundColor, OneColor, 28, 36);
            Player.OneColor = Draw.canvasData[28, 36].Color;
            UI.UpdateButtons();
        }
    }
}