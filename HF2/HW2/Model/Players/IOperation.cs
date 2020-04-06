namespace HW2.Model.Operations
{
    public interface IOperation
    {
        bool TryExecute(Board selectedField, Board currentField);
    }
}
