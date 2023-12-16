using Domain.Modelos;
using Domain.Enums;
using Infra.Banco.ContextDb;
using Infra.InterfacesRepositorios;
using LinqToDB.Data;
using LinqToDB;

namespace Infra.Repositorios
{
    public class RepositorioJogador : IRepositoryJogador
    {
        private readonly DataConnection _conexao = LaLigaConnection.ObterConexao();

        public List<Jogador> ObterTodos()
        {
            return _conexao.GetTable<Jogador>().ToList();
        }
        public Jogador ObterPorId(int id)
        {
            var listaJogadores = ObterTodos();
            var jogador1 = listaJogadores.Where(p => p.Id == id).FirstOrDefault();
            return jogador1;
        }
        public void Adicionar(Jogador jogador)
        {
            var jogador1 = new Jogador() {
                Id = 1,
                Nome = "Messi",
                Idade = 36,
                NumeroCamisa = 10,
                Posicao = PosicaoEnum.PontaDireita,
                Nacionalidade = "Argentina",
                PernaBoa = PernaBoaEnum.Esquerda,
                TimeId = 2
            };
            _conexao.Insert(jogador1);
        }
        public void Remover(Jogador jogador)
        {
            var jogador1 = new Jogador()
            {
                Id = 3,
                Nome = "Messi",
                Idade = 36,
                NumeroCamisa = 10,
                Posicao = PosicaoEnum.PontaDireita,
                Nacionalidade = "Argentina",
                PernaBoa = PernaBoaEnum.Esquerda,
                TimeId = 2
            };
            _conexao.Delete(jogador1);
        }
        public void Atualizar(Jogador jogador)
        {
            var jogador1 = new Jogador()
            {
                Id = 4,
                Nome = "Messi",
                Idade = 37,
                NumeroCamisa = 10,
                Posicao = PosicaoEnum.SegundoAtacante,
                Nacionalidade = "Argentina",
                PernaBoa = PernaBoaEnum.Esquerda,
                TimeId = 2
            };
            _conexao.Update(jogador1);
        }
    }
}
