using Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.InterfacesRepositorios
{
    internal interface IRepositoryEstadio : IRepository<Estadio>
    {
        List<Estadio> ObterTodos();
        Estadio ObterPorId(int id);
        void Adicionar(Estadio entidade);
        void Remover(Estadio entidade);
        void Atualizar(Estadio entidade);
    }
}
