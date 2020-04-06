namespace HF2.Model.Operations
{
    public interface IOperation
    {
        bool TryExecute(Field selectedField, Field currentField);
    }
}
