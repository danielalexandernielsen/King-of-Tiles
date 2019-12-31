using Xamarin.Forms;

namespace AreaBattle
{
    class Canvas
    {
        public static void Generate(out Grid layout, out Grid canvas, out Grid gameUI, out Grid time, out Grid scorePlayer1)
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

            gameUI = new Grid
            {
                ColumnSpacing = 10,
                RowSpacing = 0,
                BackgroundColor = Color.FromHex("E9E2D7"),

                ColumnDefinitions =
                    {
                        new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { },
                        new ColumnDefinition { }, new ColumnDefinition { },
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

            scorePlayer1 = new Grid
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
                        new ColumnDefinition { }, new ColumnDefinition { }, 
                        new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) }, 
                        new ColumnDefinition { }, new ColumnDefinition { },
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