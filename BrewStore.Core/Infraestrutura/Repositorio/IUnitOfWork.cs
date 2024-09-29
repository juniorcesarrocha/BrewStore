namespace BrewStore.Core.Infraestrutura.Repositorio
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
