using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaximumClone.Migrations
{
    public partial class FixHallTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chair_Hall_HallId",
                table: "Chair");

            migrationBuilder.DropForeignKey(
                name: "FK_Hall_Cinemas_CinemaId",
                table: "Hall");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hall",
                table: "Hall");

            migrationBuilder.RenameTable(
                name: "Hall",
                newName: "Halls");

            migrationBuilder.RenameIndex(
                name: "IX_Hall_CinemaId",
                table: "Halls",
                newName: "IX_Halls_CinemaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Halls",
                table: "Halls",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chair_Halls_HallId",
                table: "Chair",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_Cinemas_CinemaId",
                table: "Halls",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chair_Halls_HallId",
                table: "Chair");

            migrationBuilder.DropForeignKey(
                name: "FK_Halls_Cinemas_CinemaId",
                table: "Halls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Halls",
                table: "Halls");

            migrationBuilder.RenameTable(
                name: "Halls",
                newName: "Hall");

            migrationBuilder.RenameIndex(
                name: "IX_Halls_CinemaId",
                table: "Hall",
                newName: "IX_Hall_CinemaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hall",
                table: "Hall",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chair_Hall_HallId",
                table: "Chair",
                column: "HallId",
                principalTable: "Hall",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hall_Cinemas_CinemaId",
                table: "Hall",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
