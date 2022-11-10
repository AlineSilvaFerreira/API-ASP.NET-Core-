using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonnaAgencia.Migrations
{
    public partial class pacote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacote_Voo_VooId",
                table: "Pacote");

            migrationBuilder.DropTable(
                name: "Voo");

            migrationBuilder.DropIndex(
                name: "IX_Pacote_VooId",
                table: "Pacote");

            migrationBuilder.DropColumn(
                name: "VooId",
                table: "Pacote");

            migrationBuilder.AlterColumn<int>(
                name: "Diarias",
                table: "Pacote",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataIda",
                table: "Pacote",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataVolta",
                table: "Pacote",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Destino",
                table: "Pacote",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Origem",
                table: "Pacote",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataIda",
                table: "Pacote");

            migrationBuilder.DropColumn(
                name: "DataVolta",
                table: "Pacote");

            migrationBuilder.DropColumn(
                name: "Destino",
                table: "Pacote");

            migrationBuilder.DropColumn(
                name: "Origem",
                table: "Pacote");

            migrationBuilder.AlterColumn<string>(
                name: "Diarias",
                table: "Pacote",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "VooId",
                table: "Pacote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Voo",
                columns: table => new
                {
                    VooId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataIda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataVolta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voo", x => x.VooId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacote_VooId",
                table: "Pacote",
                column: "VooId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacote_Voo_VooId",
                table: "Pacote",
                column: "VooId",
                principalTable: "Voo",
                principalColumn: "VooId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
