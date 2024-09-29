namespace BrewStore.Core.Infraestrutura.Repositorio
{
    public interface IRepositorio<T>
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
