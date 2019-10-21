namespace Dominio.Interfaces.Handlers
{
    public interface IQueryHandler<TFilter, TResult>
    where TFilter: new()
    where TResult: new()
    {
        TResult Retrieve(TFilter filter);
    }
}