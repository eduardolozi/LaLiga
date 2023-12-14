using FluentMigrator;

namespace Infra.Banco.Tabelas
{
    [Migration(20231213214000)]
    public class AdicionaTabelaEstadio : Migration
    {
        public override void Up()
        {
            Create.Table("Estadio")
                .WithColumn("EstadioId").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("Foto").AsCustom("VARCHAR(MAX)").Nullable()
                .WithColumn("Capacidade").AsInt32().NotNullable()
                .WithColumn("TimeId").AsInt32().NotNullable()
                .WithColumn("Time").AsBoolean().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Estadio");
        }
    }
}
