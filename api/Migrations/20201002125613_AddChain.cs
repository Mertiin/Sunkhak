using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Api.Migrations
{
    public partial class AddChain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChainId",
                table: "Bars",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Chain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chain", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bars_ChainId",
                table: "Bars",
                column: "ChainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bars_Chain_ChainId",
                table: "Bars",
                column: "ChainId",
                principalTable: "Chain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bars_Chain_ChainId",
                table: "Bars");

            migrationBuilder.DropTable(
                name: "Chain");

            migrationBuilder.DropIndex(
                name: "IX_Bars_ChainId",
                table: "Bars");

            migrationBuilder.DropColumn(
                name: "ChainId",
                table: "Bars");
        }
    }
}
