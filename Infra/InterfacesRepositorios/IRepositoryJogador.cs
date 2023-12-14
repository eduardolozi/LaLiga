using Domain.Modelos;

namespace Infra.InterfacesRepositorios
{
    public interface IRepositoryJogador : IRepository<Jogador>
    {
        List<Jogador> ObterTodos();
        Jogador ObterPorId(int id);
        void Adicionar(Jogador entidade);
        void Remover(Jogador entidade);
        void Atualizar(Jogador entidade);
    }
}
