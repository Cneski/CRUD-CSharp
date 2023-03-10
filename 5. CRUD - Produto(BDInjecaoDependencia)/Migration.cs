using FluentMigrator;

namespace EstoqueMercado.Migrations
{
    [Migration(20230301120000)]
    public class AdicionarTabelaProdutos : Migration
    {
        public override void Up()
        {
            Create.Table("Produtos")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("Marca").AsString().NotNullable()
                .WithColumn("CodigoBarras").AsString().NotNullable()
                .WithColumn("DataVencimento").AsDateTime().NotNullable()
                .WithColumn("DataCadastro").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Produtos");
        }

    }
}