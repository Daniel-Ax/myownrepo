using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HW2.View
{
    public sealed partial class Contact : Page
    {
        public Contact()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MenuSplitView.IsPaneOpen == false)
            {
                MenuSplitView.IsPaneOpen = true;
            }
            else if (MenuSplitView.IsPaneOpen)
            {
                MenuSplitView.IsPaneOpen = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GameMenu));
        }
    }
}
