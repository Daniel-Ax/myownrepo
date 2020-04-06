namespace HW2.Model.Operations
{
    public abstract class OperationBase : IOperation
    {
        protected GameBase game;
        public OperationBase(GameBase game)
        {
            this.game = game;
        }

        public abstract bool TryExecute(Board selectedField, Board currentField);

    }
}
