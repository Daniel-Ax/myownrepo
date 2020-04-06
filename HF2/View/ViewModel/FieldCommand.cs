﻿using HF2.Model.Operations;

namespace HF2.ViewModel
{
    /// <summary>
    /// Command binded to the fields (Buttons).
    /// Additional, special booster buttons will have different binded commands.
    /// </summary>
    public class FieldCommand : CommandBase
    {
        // EVIP: readonly, assigned only in ctor
        private readonly GameViewModel vm;

        private readonly PlayerMoveOperation cloneMove;

        public FieldCommand(GameViewModel vm) : base()
        {
            this.vm = vm;
            MachinePlayer machinePlayer = new MachinePlayer(vm.Model);
            cloneMove = new PlayerMoveOperation(vm.Model,machinePlayer);
        }

        /// <summary>
        /// Executes a command initiated by clicking a field of the game.
        /// </summary>
        /// <param name="parameter">FieldViewModel on which the command is invoked.</param>
        public override void Execute(object parameter)
        {
            FieldViewModel current = parameter as FieldViewModel;

            // Clicking own field selects that field.
            if (current.Owner == vm.CurrentPlayer)
            {
                vm.SelectedField = current;
                return;
            }

            // EVIP: lazy evaluation to avoid null reference exception.
            //  &&: second operand is not evaluated if first is false.
            if (vm.SelectedField != null && vm.SelectedField != current)
            {
                // Try to execute CloneMove or Jump and finish turn if successful
                // EVIP: lazy evaluation used for trying sequence.
                //  If || operator. If first operand is true, second is not evaluated.
                if (cloneMove.TryExecute(vm.SelectedField.Model, current.Model))
                {
                    vm.EndOfTurn();
                }
            }
        }
    }
}
