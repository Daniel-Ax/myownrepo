namespace HF2.Model
{
    public class Field : ObservableObject
    {
        public int Row { get; set; }
        public int Column { get; set; }

        private int owner = 0;
        public int Owner
        {
            get => owner;
            set
            {
                if (owner != value)
                {
                    owner = value;
                    Notify();
                }
            }
        }
        public bool IsEmpty() => (owner == 0);
    }
}
