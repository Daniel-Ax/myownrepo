using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HW2.View
{

    public sealed partial class Devs : Page
    {
        Dictionary<string, string> developerTeam = new Dictionary<string, string>()
        {   {"Mikó Ádám","Model, Video" },
            {"Gonda Ábel","View, ViewModel" },
            {"Ács Dániel","View, Description" },
        };

        public string Developers { get; set; }

        public Devs()
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

        private void View(object sender, RoutedEventArgs e)
        {
            var developers = from x in developerTeam
                             where x.Value.Contains("View")
                             select x;

            textBoxForDevNames.Text = getAsString(developers);
        }

        private void ViewModel(object sender, RoutedEventArgs e)
        {
            var developers = from x in developerTeam
                             where x.Value.Contains("ViewModel")
                             select x;

            textBoxForDevNames.Text = getAsString(developers);
        }

        private void Model(object sender, RoutedEventArgs e)
        {
            var developers = from x in developerTeam
                             where x.Value.Contains("Model")
                             select x;

            textBoxForDevNames.Text = getAsString(developers);
        }
        private void Video(object sender, RoutedEventArgs e)
        {
            var developers = from x in developerTeam
                             where x.Value.Contains("Video")
                             select x;

            textBoxForDevNames.Text = getAsString(developers);
        }
        private void Desription(object sender, RoutedEventArgs e)
        {
            var developers = from x in developerTeam
                             where x.Value.Contains("Description")
                             select x;

            textBoxForDevNames.Text = getAsString(developers);
        }

        private string getAsString(IEnumerable<KeyValuePair<string, string>> developers)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var x in developers)
            {
                sb.Append(x.Key + " ");
            }

            return sb.ToString();
        }
    }
}
