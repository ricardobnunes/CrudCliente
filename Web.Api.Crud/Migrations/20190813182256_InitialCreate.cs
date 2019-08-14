using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Api.Crud.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(type: "varchar(40)", nullable: false),
                    CodCliente = table.Column<string>(type: "varchar(5)", nullable: false),
                    TelCliente = table.Column<string>(type: "varchar(11)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    RG = table.Column<string>(type: "varchar(9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
