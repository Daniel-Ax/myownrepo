using HW2.Model;
using HW2.ViewModel;
using Windows.UI.Xaml.Controls;

namespace HW2.View
{
    public sealed partial class GameView : UserControl
    {
        public GameViewModel ViewModel;

        public GameView()
        {
            this.InitializeComponent();
            ViewModel = new GameViewModel(new SimpleGame(8));
        }
    }
}
