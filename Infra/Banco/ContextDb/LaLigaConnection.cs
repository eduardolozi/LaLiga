using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.SqlServer;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;

namespace Infra.Banco.ContextDb
{
    public class LaLigaConnection : DataConnection
    {
        private static string stringDeConexao = ConfigurationManager.ConnectionStrings["LaLigaBD"].ConnectionString;
        public static DataConnection ObterConexao()
        {
            DataConnection conexao = SqlServerTools.CreateDataConnection(stringDeConexao);
            return conexao;
        }
    }
}
