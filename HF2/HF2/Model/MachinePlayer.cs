using System;

namespace HF2.Model
{
    class MachinePlayer : Player
    {
        public MachinePlayer(int[,] field) : base(field) { }

        public bool MachineTurn()
        {
            if (MachineCanHit())
                return true;

            if (MachineMove())
                return true;

            return false;
        }

        private bool MachineCanHit()
        {
            for (int oldXCoor = 0; oldXCoor < 6; oldXCoor++)
            {
                for (int oldYCoor = 0; oldYCoor < 6; oldYCoor++)
                {
                    if (base.field[oldXCoor, oldYCoor] == 2)
                    {
                        for (int newXCoor = oldXCoor + 2; newXCoor < 8; newXCoor++)
                        {
                            for (int newYCoor = oldYCoor + 2; newYCoor < 8; newYCoor++)
                            {
                                if (field[newXCoor, newYCoor] == 0)
                                {
                                    if (MachineTryHit(oldXCoor, oldYCoor, newXCoor, newYCoor))
                                    {
                                        MachineHit(oldXCoor, oldYCoor, newXCoor, newYCoor);
                                        return true;
                                    }
                                }
                            }
                        }

                    }
                }
            }
            return false;
        }

        private void MachineHit(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            int column = oldYCoor;
            for (int row = oldXCoor + 1; row < newXCoor; row++)
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

            Move(oldXCoor, oldYCoor, newXCoor, newYCoor);
        }

        private bool MachineTryHit(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            int column = oldYCoor;
            for (int row = oldXCoor + 1; row < newXCoor; row++)
            {
                if (oldYCoor > newYCoor)
                {
                    column--;
                    if (field[row, column] == 0 || field[row, column] == 2)
                        return false;

                }

                else if (oldYCoor < newYCoor)
                {
                    column++;
                    if (field[row, column] == 0 || field[row, column] == 2)
                        return false;

                }
            }
            return true;
        }

        private bool MachineMove()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    if (base.field[row, column] == 2)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            if (field[row + 1, i] == 0 && Math.Abs(column - i) == 1)
                            {
                                Move(row, column, row + 1, i);
                                return true;
                            }

                        }
                    }
                }
            }
            return false;
        }
    }
}
