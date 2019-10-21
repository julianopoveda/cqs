namespace Dominio.Interfaces.Handlers
{
    public interface IQueryDispatcher
    {
        TResult Dispatch<TFilter, TResult>(TFilter filter)
        where TFilter: new()
        where TResult: new();
    }
}