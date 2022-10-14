using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CriptoADS2022.Migrations
{
    public partial class atualizamoeda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conta_Clientes_clienteid",
                table: "Conta");

            migrationBuilder.DropForeignKey(
                name: "FK_Conta_Moedas_moedaid",
                table: "Conta");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Moedas",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AddColumn<float>(
                name: "capital",
                table: "Moedas",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "sigla",
                table: "Moedas",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "var24h",
                table: "Moedas",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "var7d",
                table: "Moedas",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "vol24",
                table: "Moedas",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "voltotal",
                table: "Moedas",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<int>(
                name: "moedaid",
                table: "Conta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "clienteid",
                table: "Conta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Clientes_clienteid",
                table: "Conta",
                column: "clienteid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Moedas_moedaid",
                table: "Conta",
                column: "moedaid",
                principalTable: "Moedas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conta_Clientes_clienteid",
                table: "Conta");

            migrationBuilder.DropForeignKey(
                name: "FK_Conta_Moedas_moedaid",
                table: "Conta");

            migrationBuilder.DropColumn(
                name: "capital",
                table: "Moedas");

            migrationBuilder.DropColumn(
                name: "sigla",
                table: "Moedas");

            migrationBuilder.DropColumn(
                name: "var24h",
                table: "Moedas");

            migrationBuilder.DropColumn(
                name: "var7d",
                table: "Moedas");

            migrationBuilder.DropColumn(
                name: "vol24",
                table: "Moedas");

            migrationBuilder.DropColumn(
                name: "voltotal",
                table: "Moedas");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Moedas",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "moedaid",
                table: "Conta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "clienteid",
                table: "Conta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Clientes_clienteid",
                table: "Conta",
                column: "clienteid",
                principalTable: "Clientes",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Moedas_moedaid",
                table: "Conta",
                column: "moedaid",
                principalTable: "Moedas",
                principalColumn: "id");
        }
    }
}
