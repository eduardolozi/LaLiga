using FluentMigrator;


namespace Infra.Banco.Migracao
{
    [Migration(20231214172000)]
    public class AddTimeTable : Migration
    {
        public override void Up()
        {
            Create.Table("Time")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("AnoFundacao").AsDateTime().NotNullable()
                .WithColumn("FotoEscudo").AsCustom("VARCHAR(MAX)").Nullable();
        }

        public override void Down()
        {
            Delete.Table("Time");
        }
    }
}
