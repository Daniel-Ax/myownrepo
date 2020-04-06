namespace HF2.Model
{
    public class SimpleGame : GameBase
    {
        public SimpleGame(int size) : base()
        {
            Fields = new Field[size, size];
            for (int row = 0; row < size; row++)
                for (int col = 0; col < size; col++)
                    Fields[row, col] = new Field() { Row = row, Column = col, Owner = 0 };
            NumberOfPlayers = 1;

            InitializeGame();
        }

        public override void InitializeGame()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    if ((row % 2 == 0 && column % 2 == 1) || (row % 2 == 1 && column % 2 == 0))
                    {
                        if (row < 3)
                            Fields[column, row].Owner = 2;
                        else if (row > 4)
                            Fields[column, row].Owner = 1;
                        else
                            Fields[column, row].Owner = 0;
                    }
                }
            }
        }
    }
}
