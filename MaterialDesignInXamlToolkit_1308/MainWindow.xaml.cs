using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;

namespace MaterialDesignInXamlToolkit_1308
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateContent();
        }

        private void CreateContent()
        {
            var content = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(5, GridUnitType.Star)},
                    new ColumnDefinition {Width = new GridLength(5, GridUnitType.Star)}
                },
                RowDefinitions =
                {
                    new RowDefinition {Height = new GridLength(5, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(5, GridUnitType.Star)}
                }
            };

            var icon0 = new PackIcon
            {
                Kind = PackIconKind.MaterialDesign, Width = 200, Height = 200, Foreground = Brushes.Black
            };

            var icon1 = new PackIcon
            {
                Kind = PackIconKind.MaterialDesign, Width = 200, Height = 200, Foreground = Brushes.Black
            };

            var icon2 = new PackIcon
            {
                Kind = PackIconKind.MaterialDesign, Width = 200, Height = 200, Foreground = Brushes.Black
            };

            var icon3 = new PackIcon
            {
                Kind = PackIconKind.MaterialDesign, Width = 200, Height = 200, Foreground = Brushes.Black
            };

            Grid.SetRow(icon0, 0);
            Grid.SetColumn(icon0, 0);
            content.Children.Add(icon0);

            Grid.SetRow(icon1, 0);
            Grid.SetColumn(icon1, 1);
            content.Children.Add(icon1);

            Grid.SetRow(icon2, 1);
            Grid.SetColumn(icon2, 0);
            content.Children.Add(icon2);

            Grid.SetRow(icon3, 1);
            Grid.SetColumn(icon3, 1);
            content.Children.Add(icon3);

            SomeContentContainer.Content = content;

            try
            {
                // This fails!
                SomeScrollViewer.SetValue(StyleProperty, FindResource("MaterialDesignScrollBarMinimal"));
            }
            catch
            {
#if DEBUG
                Debug.WriteLine("Failed to change SomeScrollViewer's style");
#endif
            }
        }
    }
}