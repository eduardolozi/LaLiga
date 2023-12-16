using FluentMigrator;
using System.Data;

namespace Infra.Banco.Migracao
{
    [Migration(20231214172002)]
    public class AddEstadioTable : Migration
    {
        public override void Up()
        {
            Create.Table("Estadio")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("TimeId").AsInt32().Nullable()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("Foto").AsCustom("VARCHAR(MAX)").Nullable()
                .WithColumn("Capacidade").AsInt32().NotNullable();

            Create.ForeignKey()
                .FromTable("Estadio").ForeignColumn("TimeId")
                .ToTable("Time").PrimaryColumn("Id");
        }

        public override void Down()
        {
            Delete.Table("Estadio");
        }
    }
}