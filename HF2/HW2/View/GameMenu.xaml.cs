using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HW2.View
{
    public sealed partial class GameMenu : Page
    {
        public GameMenu()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MenuSplitView.IsPaneOpen == false)
            {
                MenuSplitView.IsPaneOpen = true;
            }
            else if (MenuSplitView.IsPaneOpen == true)
            {
                MenuSplitView.IsPaneOpen = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window.Current.Content = new GameView();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Devs));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Rules));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Contact));
        }
    }
}
