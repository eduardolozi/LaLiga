using FluentMigrator;

namespace Infra.Banco.Tabelas
{

    [Migration(20231213214000)]
    public class AdicionaTabelaJogador : Migration
    {
        public override void Up()
        {
            Create.Table("Jogador")
                .WithColumn("JogadorId").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("Idade").AsString().NotNullable()
                .WithColumn("PernaBoa").AsString().NotNullable()
                .WithColumn("Posicao").AsString().NotNullable()
                .WithColumn("Nacionalidade").AsString().NotNullable()
                .WithColumn("NumeroCamisa").AsInt32().NotNullable()
                .WithColumn("Foto").AsCustom("VARCHAR(MAX)").Nullable()
                .WithColumn("TimeId").AsString().Nullable()
                .WithColumn("Time").AsCustom("VARCHAR(MAX)").Nullable();
        }

        public override void Down()
        {
            Delete.Table("pokemons");
        }
    }
}
