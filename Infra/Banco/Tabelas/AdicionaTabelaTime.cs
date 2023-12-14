using FluentMigrator;

namespace Infra.Banco.Tabelas
{
    [Migration(20231213214000)]
    public class AdicionaTabelaTime : Migration
    {
        public override void Up()
        {
            Create.Table("Time")
                .WithColumn("TimeId").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("AnoFundacao").AsDateTime().NotNullable()
                .WithColumn("FotoEscudo").AsCustom("VARCHAR(MAX)").Nullable()
                .WithColumn("Jogadores").AsCustom("DECIMAL(3,2)").NotNullable()
                .WithColumn("Estadio").AsBoolean().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Time");
        }
    }
}
