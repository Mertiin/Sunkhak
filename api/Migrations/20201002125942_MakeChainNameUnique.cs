using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class MakeChainNameUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Chains_Name",
                table: "Chains",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Chains_Name",
                table: "Chains");
        }
    }
}
