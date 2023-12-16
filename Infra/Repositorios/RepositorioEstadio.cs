using Domain.Modelos;
using Infra.Banco.ContextDb;
using Infra.InterfacesRepositorios;
using LinqToDB;
using LinqToDB.Data;
using Domain.Enums;
using Domain.Modelos;

namespace Infra.Repositorios
{
    public class RepositorioEstadio : IRepositoryEstadio
    {
        private readonly DataConnection _conexao = LaLigaConnection.ObterConexao();
        public List<Estadio> ObterTodos()
        {
            return _conexao.GetTable<Estadio>().ToList();
        }
        public Estadio ObterPorId(int id)
        {
            var listaEstadios = ObterTodos();
            var estadio1 = listaEstadios.Where(p => p.Id == id).FirstOrDefault();
            return estadio1;
        }
        public void Adicionar(Estadio estadio)
        {
            var estadio1 = new Estadio()
            {
                Id = 1,
                Nome = EstadioEnum.CampNou,
                Capacidade = 100000,
                TimeId = 2
            };
            _conexao.Insert(estadio1);
        }
        public void Remover(Estadio estadio)
        {
            var estadio1 = new Estadio()
            {
                Id = 1,
                Nome = EstadioEnum.CampNou,
                Capacidade = 100000,
                TimeId = 2
            };
            _conexao.Delete(estadio1);
        }
        public void Atualizar(Estadio estadio)
        {
            var estadio1 = new Estadio()
            {
                Id = 1,
                Nome = EstadioEnum.CampNou,
                Capacidade = 99000,
                TimeId = 2
            };
            _conexao.Update(estadio1);
        }
    }
}
