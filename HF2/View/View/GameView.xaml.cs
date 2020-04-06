using HF2.Model;
using HF2.ViewModel;
using Windows.UI.Xaml.Controls;

namespace HF2.View
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
