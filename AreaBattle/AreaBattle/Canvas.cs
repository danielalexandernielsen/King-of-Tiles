using Xamarin.Forms;

namespace AreaBattle
{
    class Canvas
    {

        public static void Generate(out Grid layout, out Grid canvas, out Grid gameInterface, out Grid time, out Grid score)
        {
            layout = new Grid
            {
                RowSpacing = 0,

                RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(8, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                    }
            };
            canvas = new Grid
            {
                ColumnSpacing = 0,
                RowSpacing = 0,

                ColumnDefinitions =
                    {
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { },
                    },
                RowDefinitions =
                    {
                        new RowDefinition { }, new RowDefinition { }, new RowDefinition { }, new RowDefinition { },
                        new RowDefinition { }, new RowDefinition { }, new RowDefinition { }, new RowDefinition { },
                        new RowDefinition { }, new RowDefinition { }, new RowDefinition { }, new RowDefinition { },
                        new RowDefinition { }, new RowDefinition { }, new RowDefinition { }, new RowDefinition { },
                        new RowDefinition { }, new RowDefinition { }, new RowDefinition { }, new RowDefinition { },
                        new RowDefinition { }, new RowDefinition { }, new RowDefinition { }, new RowDefinition { },
                        new RowDefinition { }, new RowDefinition { }, new RowDefinition { }, new RowDefinition { },
                        new RowDefinition { }, new RowDefinition { }, new RowDefinition { }, new RowDefinition { },
                        new RowDefinition { }, new RowDefinition { }, new RowDefinition { }, new RowDefinition { },
                        new RowDefinition { },
                    }
            };

            gameInterface = new Grid
            {
                ColumnSpacing = 10,
                RowSpacing = 0,
                BackgroundColor = Color.FromHex("E9E2D7"),

                ColumnDefinitions =
                    {
                        new ColumnDefinition { },
                        new ColumnDefinition { },
                        new ColumnDefinition { },
                        new ColumnDefinition { },
                        new ColumnDefinition { },
                        new ColumnDefinition { },
                        new ColumnDefinition { },
                    },
                RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(1.25, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(0.5, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(1.25, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(4, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(1.25, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(0.5, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(1.25, GridUnitType.Star) },
                    }
            };

            time = new Grid
            {
                ColumnSpacing = 0,
                RowSpacing = 0,

                ColumnDefinitions =
                    {
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                    },
                RowDefinitions =
                    {
                        new RowDefinition { },
                    }
            };

            score = new Grid
            {
                ColumnSpacing = 0,
                RowSpacing = 0,

                ColumnDefinitions =
                    {
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { },
                    },
                RowDefinitions =
                    {
                        new RowDefinition { },
                    }
            };
        }
    }
}