using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AreaBattle
{
    class Player
    {
        public static void ClickedRed(object sender, EventArgs e) { SwitchColor(Color.FromHex("DA0032")); }
        public static void ClickedGreen(object sender, EventArgs e) { SwitchColor(Color.FromHex("0AA174")); }
        public static void ClickedBlue(object sender, EventArgs e) { SwitchColor(Color.FromHex("3465AA")); }
        public static void ClickedOrange(object sender, EventArgs e) { SwitchColor(Color.FromHex("EB9B00")); }
        public static void ClickedPurple(object sender, EventArgs e) { SwitchColor(Color.FromHex("7C378A")); }

        public static Color One;
        public static Color Two;

        public static void Start()
        {
            One = Draw.canvasData[28, 36].Color;
            Two = Draw.canvasData[0, 0].Color;
        }


        public static void SwitchColor(Color colorFromButton)
        {
            Color sourceColor = Draw.canvasData[28, 36].Color;
            Draw.Update(colorFromButton, sourceColor, 28, 36);
        }
    }
}