using Domain.Modelos;
using Infra.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class RepositorioEstadio : IRepositoryEstadio
    {
        public List<Estadio> ObterTodos()
        {
            return null;
        }
        public Estadio ObterPorId(int id)
        {
            return null;
        }
        public void Adicionar(Estadio estadio)
        {

        }
        public void Remover(Estadio estadio)
        {

        }
        public void Atualizar(Estadio estadio)
        {

        }
    }
}
