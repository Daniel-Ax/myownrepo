namespace HF2.Model
{
    class Player
    {
        public int[,] field { get; set; }

        public Player(int[,] field)
        {
            this.field = field;
        }

        public bool Move(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            field[newXCoor, newYCoor] = field[oldXCoor, oldYCoor];
            field[oldXCoor, oldYCoor] = 0;
            return true;
        }

        protected bool IsEmpty(int newXCoor, int newYCoor)
        {
            if (field[newXCoor, newYCoor] == 0)
                return true;
            return false;
        }

    }
}
