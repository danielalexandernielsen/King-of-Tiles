using Xamarin.Forms;

namespace AreaBattle
{
    class Canvas
    {
        public static Grid layout;
        public static Grid board;
        public static Grid interFace;
        public static Grid time;
        public static Grid score;

        public static void Generate()
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

            board = new Grid
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

            interFace = new Grid
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
                        new ColumnDefinition { }, new ColumnDefinition { }, new ColumnDefinition { }, 
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