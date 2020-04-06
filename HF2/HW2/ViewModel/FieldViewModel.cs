using HW2.Model;

namespace HW2.ViewModel
{
    public class FieldViewModel : ObservableObject
    {
        public Board Model { get; internal set; }

        public FieldViewModel(Board model)
        {
            Model = model;
            model.PropertyChanged += Model_PropertyChanged;
        }

        private void Model_PropertyChanged(object sender,
            System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Board.Owner))
                Notify(nameof(Owner));
        }

        public int Owner { get => Model.Owner; }

        public BoardCommand FieldCommand { get; set; }

        private bool isSelected = false;

        public bool IsSelected
        {
            get => isSelected;
            set
            {
                if (isSelected != value)
                {
                    isSelected = value;
                    Notify();
                }
            }
        }
    }
}