using Infra.Banco.Migracao;

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

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMenuInicial());
        }
    }
}