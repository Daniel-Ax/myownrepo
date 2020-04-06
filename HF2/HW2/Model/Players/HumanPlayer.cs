using System;

namespace HW2.Model.Operations
{
    public class PlayerMoveOperation : OperationBase
    {
        private MachinePlayer machinePlayer;

        public PlayerMoveOperation(GameBase game, MachinePlayer machinePlayer) : base(game)
        {
            this.machinePlayer = machinePlayer;
        }

        public override bool TryExecute(Board currentField, Board selectedField)
        {
            if (IsYours(currentField.Row, currentField.Column) && IsEmpty(selectedField.Row, selectedField.Column))
            {

                if (IsNextTo(currentField.Row, currentField.Column, selectedField.Row, selectedField.Column))
                {
                    Move(currentField.Row, currentField.Column, selectedField.Row, selectedField.Column);
                    machinePlayer.MachineTurn();
                    return true;
                }

                if (UserCanHit(currentField.Column, currentField.Row, selectedField.Column, selectedField.Row))
                {
                    Hit(currentField.Row, currentField.Column, selectedField.Row, selectedField.Column);
                    machinePlayer.MachineTurn();
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
                    game.FieldsOfTheBoard[row, column].Owner = 0;
                }

                else if (oldYCoor < newYCoor)
                {
                    column++;
                    game.FieldsOfTheBoard[row, column].Owner = 0;
                }
            }
        }

        private bool UserCanHit(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            if (oldYCoor == newYCoor || oldXCoor <= newXCoor + 1)
                return false;

            if (newYCoor > oldYCoor && oldXCoor + oldYCoor != newXCoor + newYCoor)
                return false;

            if (newYCoor < oldYCoor && Math.Abs(oldXCoor - oldYCoor) != Math.Abs(newXCoor - newYCoor))
                return false;

            int column = oldYCoor;
            for (int row = oldXCoor - 1; row > newXCoor; row--)
            {
                if (oldYCoor > newYCoor)
                {
                    column--;
                    if (game.FieldsOfTheBoard[column, row].Owner == 0 || game.FieldsOfTheBoard[column, row].Owner == 1)
                        return false;
                }

                else if (oldYCoor < newYCoor)
                {
                    column++;
                    if (game.FieldsOfTheBoard[column, row].Owner == 0 || game.FieldsOfTheBoard[column, row].Owner == 1)
                        return false;
                }
            }
            return true;
        }

        private bool IsYours(int oldXCoor, int oldYCoor)
        {
            if (game.FieldsOfTheBoard[oldXCoor, oldYCoor].Owner == 1)
                return true;
            return false;
        }

        public bool Move(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            game.FieldsOfTheBoard[newXCoor, newYCoor].Owner = game.FieldsOfTheBoard[oldXCoor, oldYCoor].Owner;
            game.FieldsOfTheBoard[oldXCoor, oldYCoor].Owner = 0;
            return true;
        }

        protected bool IsEmpty(int XCoor, int YCoor)
        {
            if (game.FieldsOfTheBoard[XCoor, YCoor].Owner == 0)
                return true;
            return false;
        }

        private bool IsNextTo(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            if (Math.Abs(oldXCoor - newXCoor) == 1 && oldYCoor == newYCoor + 1)
                return true;
            return false;
        }
    }
}
