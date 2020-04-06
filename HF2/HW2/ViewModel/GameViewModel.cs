using System.Collections.ObjectModel;
using System.Linq;
using HW2.Model;

namespace HW2.ViewModel
{
    public class GameViewModel : ObservableObject
    {
        public readonly GameBase Model;

        public GameViewModel(GameBase model) : base()
        {
            this.Model = model;
            Model.PropertyChanged += Model_PropertyChanged;
            InitFieldsBasedOnModel();
        }

        public ObservableCollection<FieldViewModelList> Fields { get; set; }

        private void InitFieldsBasedOnModel()
        {
            var fieldCommand = new BoardCommand(this);
            Fields = new ObservableCollection<FieldViewModelList>();
            for (int row = 0; row < Model.FieldsOfTheBoard.GetLength(0); row++)
            {
                var rowList = new FieldViewModelList();
                for (int col = 0; col < Model.FieldsOfTheBoard.GetLength(1); col++)
                {
                    rowList.Add(
                        new FieldViewModel(Model.FieldsOfTheBoard[row, col])
                        { FieldCommand = fieldCommand }
                        );
                }
                Fields.Add(rowList);
            }
        }

        private FieldViewModel selectedField;
        public FieldViewModel SelectedField
        {
            get => selectedField;
            set
            {
                if (selectedField != value)
                {
                    if (selectedField != null)
                        selectedField.IsSelected = false;
                    selectedField = value;
                    if (selectedField != null)
                        selectedField.IsSelected = true;
                    Notify();
                }
            }
        }

        public int CurrentPlayer { get => Model.CurrentPlayer; }

        public int? Winner { get => Model.Winner; }
        public bool IsGameRunning { get => Model.IsGameRunning; }

        private readonly string[] dependentPropertyNames =
            { nameof(GameBase.Winner), nameof(GameBase.IsGameRunning),
              nameof(GameBase.CurrentPlayer) };

        private void Model_PropertyChanged(object sender,
            System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (dependentPropertyNames.Contains(e.PropertyName))
                Notify(e.PropertyName);
        }

        public BoardCommand FieldCommand { get; private set; }

        internal void EndOfTurn()
        {
            SelectedField = null;
            Model.EndOfTurn();
        }

    }
}
