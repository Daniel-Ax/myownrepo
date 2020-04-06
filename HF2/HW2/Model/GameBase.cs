namespace HW2.Model
{
    public abstract class GameBase : ObservableObject
    {
        public GameBase() { }

        public abstract void InitializeGame();

        public Board[,] FieldsOfTheBoard { get; protected set; }
        public int NumberOfPlayers { get; protected set; }

        private int currentPlayer = 1;
        public int CurrentPlayer
        {
            get => currentPlayer;
            set
            {
                if (currentPlayer != value)
                {
                    currentPlayer = value;
                    Notify();
                }
            }
        }

        private int? winner = null;

        public int? Winner
        {
            get => winner;
            private set
            {
                if (winner != value)
                {
                    winner = value;
                    Notify();
                    Notify(nameof(IsGameRunning));
                }
            }
        }

        public bool IsGameRunning => Winner is null;

        public void EndOfTurn()
        {
            if (!CheckGameOver())
            {
                if (CurrentPlayer < NumberOfPlayers)
                    CurrentPlayer++;
                else
                    CurrentPlayer = 1;
            }
        }

        private bool CheckGameOver()
        {
            return false;
        }
    }
}
