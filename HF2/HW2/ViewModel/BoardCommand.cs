using HW2.Model.Operations;

namespace HW2.ViewModel
{
    public class BoardCommand : CommandBase
    {
        private readonly GameViewModel vm;
        private readonly PlayerMoveOperation playerTurn;

        public BoardCommand(GameViewModel vm) : base()
        {
            this.vm = vm;
            MachinePlayer machinePlayer = new MachinePlayer(vm.Model);
            playerTurn = new PlayerMoveOperation(vm.Model, machinePlayer);
        }

        public override void Execute(object parameter)
        {
            FieldViewModel current = parameter as FieldViewModel;

            if (current.Owner == vm.CurrentPlayer)
            {
                vm.SelectedField = current;
                return;
            }

            if (vm.SelectedField != null && vm.SelectedField != current)
            {
                if (playerTurn.TryExecute(vm.SelectedField.Model, current.Model))
                {
                    vm.EndOfTurn();
                }
            }
        }
    }
}
