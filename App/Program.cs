using Domain.Modelos;
using Infra.Banco.Migracao;
using Infra.Repositorios;

namespace App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                ConfiguracaoDaMigracao.CriaMigracao();
            } catch (Exception)
            {
                Console.WriteLine("Erro ao fazer a migracao com o banco de dados.");
            }

            var repo = new RepositorioEstadio();
            var estadio = new Estadio();
            repo.Remover(estadio);

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMenuInicial());
        }
    }
}