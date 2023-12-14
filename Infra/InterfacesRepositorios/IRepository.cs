using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.InterfacesRepositorios
{
    public interface IRepository<T> where T : class
    {
        List<T> ObterTodos();
        T ObterPorId(int id);
        void Adicionar(T entidade);
        void Remover(T entidade);
        void Atualizar(T entidade);
    }
}
}
