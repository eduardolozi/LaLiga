using Domain.Modelos;

namespace Infra.InterfacesRepositorios
{
    public interface IRepositoryTime : IRepository<Time>
    {
        List<Time> ObterTodos();
        Time ObterPorId(int id);
        void Adicionar(Time entidade);
        void Remover(Time entidade);
        void Atualizar(Time entidade);
    }
}
