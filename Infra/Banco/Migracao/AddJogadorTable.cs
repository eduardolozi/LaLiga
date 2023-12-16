using FluentMigrator;
using System.Data;

namespace Infra.Banco.Migracao
{

    [Migration(20231214172001)]
    public class AddJogadorTable : Migration
    {
        public override void Up()
        {
            Create.Table("Jogador")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("TimeId").AsInt32().Nullable()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("Idade").AsString().NotNullable()
                .WithColumn("PernaBoa").AsString().NotNullable()
                .WithColumn("Posicao").AsString().NotNullable()
                .WithColumn("Nacionalidade").AsString().NotNullable()
                .WithColumn("NumeroCamisa").AsInt32().NotNullable()
                .WithColumn("Foto").AsCustom("VARCHAR(MAX)").Nullable();

            Create.ForeignKey()
                .FromTable("Jogador").ForeignColumn("TimeId")
                .ToTable("Time").PrimaryColumn("Id");
        }

        public override void Down()
        {
            Delete.Table("Jogador");
        }
    }
}
