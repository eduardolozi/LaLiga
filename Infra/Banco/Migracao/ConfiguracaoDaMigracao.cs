using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;


namespace Infra.Banco.Migracao
{
    public class ConfiguracaoDaMigracao
    {
        private static readonly string StringDeConexao = ConfigurationManager.ConnectionStrings["LaLigaBD"].ConnectionString;

        public static void CriaMigracao()
        {
            using (var serviceProvider = CriacaoDeServicos())
            using (var scope = serviceProvider.CreateScope())
            {
                AtualizarBancoDeDados(scope.ServiceProvider);
            }
        }

        private static ServiceProvider CriacaoDeServicos()
        {
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(StringDeConexao)
                    .ScanIn(typeof(AddTimeTable).Assembly, typeof(AddJogadorTable).Assembly, typeof(AddEstadioTable).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        private static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
        {
            var inicializador = serviceProvider.GetRequiredService<IMigrationRunner>();
            try
            {
                inicializador.MigrateUp();
                Console.WriteLine("Migrações aplicadas com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro durante a aplicação das migrações: {ex.Message}");
            }
        }
    }
}
