using System;
using System.Collections.Generic;
using System.Linq;

namespace HW2.Model.Operations
{
    public class MachinePlayer : OperationBase
    {

        public MachinePlayer(GameBase game) : base(game) { }

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
                    if (game.FieldsOfTheBoard[oldXCoor, oldYCoor].Owner == 2)
                    {
                        for (int newXCoor = oldXCoor + 2; newXCoor < 8; newXCoor++)
                        {
                            for (int newYCoor = oldYCoor + 2; newYCoor < 8; newYCoor++)
                            {
                                if (game.FieldsOfTheBoard[newXCoor, newYCoor].Owner == 0)
                                {
                                    if (MachineTryHit(oldXCoor, oldYCoor, newXCoor, newYCoor))
                                    {
                                        if (newYCoor < oldYCoor && oldXCoor + oldYCoor != newXCoor + newYCoor)
                                            return false;

                                        if (newYCoor > oldYCoor && Math.Abs(oldXCoor - oldYCoor) != Math.Abs(newXCoor - newYCoor))
                                            return false;

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
                    game.FieldsOfTheBoard[row, column].Owner = 0;
                }

                else if (oldYCoor < newYCoor)
                {
                    column++;
                    game.FieldsOfTheBoard[row, column].Owner = 0;
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
                    if (game.FieldsOfTheBoard[row, column].Owner == 0 || game.FieldsOfTheBoard[row, column].Owner == 2)
                        return false;

                }

                else if (oldYCoor < newYCoor)
                {
                    column++;
                    if (game.FieldsOfTheBoard[row, column].Owner == 0 || game.FieldsOfTheBoard[row, column].Owner == 2)
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
                    if (game.FieldsOfTheBoard[row, column].Owner == 2)
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            if (row < 7)
                            {
                                if (game.FieldsOfTheBoard[row + 1, i].Owner == 0 && Math.Abs(column - i) == 1)
                                {
                                    Move(row, column, row + 1, i);
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool Move(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            game.FieldsOfTheBoard[newXCoor, newYCoor].Owner = game.FieldsOfTheBoard[oldXCoor, oldYCoor].Owner;
            game.FieldsOfTheBoard[oldXCoor, oldYCoor].Owner = 0;
            return true;
        }

        public override bool TryExecute(Board selectedField, Board currentField)
        {
            throw new NotImplementedException();
        }
    }
}
