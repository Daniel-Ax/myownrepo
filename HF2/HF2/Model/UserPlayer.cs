using System;

namespace HF2.Model
{
    class UserPlayer : Player
    {
        public UserPlayer(int[,] field) : base(field) { }

        public bool UserMove(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            if (IsYours(oldXCoor, oldYCoor) && base.IsEmpty(newXCoor, newYCoor))
            {
                if (IsNextTo(oldXCoor, oldYCoor, newXCoor, newYCoor))
                {
                    Move(oldXCoor, oldYCoor, newXCoor, newYCoor);
                    return true;
                }

                if (UserCanHit(oldXCoor, oldYCoor, newXCoor, newYCoor))
                {
                    Hit(oldXCoor, oldYCoor, newXCoor, newYCoor);
                    return true;
                }

            }
            return false;
        }

        private void Hit(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            Move(oldXCoor, oldYCoor, newXCoor, newYCoor);

            int column = oldYCoor;
            for (int row = oldXCoor - 1; row > newXCoor; row--)
            {
                if (oldYCoor > newYCoor)
                {
                    column--;
                    field[row, column] = 0;
                }

                else if (oldYCoor < newYCoor)
                {
                    column++;
                    field[row, column] = 0;
                }
            }
        }

        private bool UserCanHit(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            int column = oldYCoor;
            for (int row = oldXCoor - 1; row > newXCoor; row--)
            {
                if (oldYCoor > newYCoor)
                {
                    column--;
                    if (field[row, column] == 0 || field[row, column] == 1)
                        return false;

                }

                else if (oldYCoor < newYCoor)
                {
                    column++;
                    if (field[row, column] == 0 || field[row, column] == 1)
                        return false;

                }
            }
            return true;
        }

        private bool IsYours(int oldXCoor, int oldYCoor)
        {
            if (field[oldXCoor, oldYCoor] == 1)
                return true;
            return false;
        }

        private bool IsNextTo(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            if (Math.Abs(oldXCoor - newXCoor) == 1 && Math.Abs(oldYCoor - newYCoor) == 1)
                return true;
            return false;
        }
    }
}
