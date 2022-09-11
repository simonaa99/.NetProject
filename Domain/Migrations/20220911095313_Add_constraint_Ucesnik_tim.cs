using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class Add_constraint_Ucesnik_tim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucesnik_Tim_TimId",
                table: "Ucesnik");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucesnik_Tim_TimId",
                table: "Ucesnik",
                column: "TimId",
                principalTable: "Tim",
                principalColumn: "TimId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucesnik_Tim_TimId",
                table: "Ucesnik");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucesnik_Tim_TimId",
                table: "Ucesnik",
                column: "TimId",
                principalTable: "Tim",
                principalColumn: "TimId");
        }
    }
}
