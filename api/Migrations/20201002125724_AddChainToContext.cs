using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class AddChainToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bars_Chain_ChainId",
                table: "Bars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chain",
                table: "Chain");

            migrationBuilder.RenameTable(
                name: "Chain",
                newName: "Chains");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chains",
                table: "Chains",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bars_Chains_ChainId",
                table: "Bars",
                column: "ChainId",
                principalTable: "Chains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bars_Chains_ChainId",
                table: "Bars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chains",
                table: "Chains");

            migrationBuilder.RenameTable(
                name: "Chains",
                newName: "Chain");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chain",
                table: "Chain",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bars_Chain_ChainId",
                table: "Bars",
                column: "ChainId",
                principalTable: "Chain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
