using Microsoft.EntityFrameworkCore.Migrations;

namespace WhatIsTheNextDayOffOrWorkDay.Repository.Migrations
{
    public partial class db_11_WhatIsTheNextDayOffOrWorkDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sequencias_Escalas_EscalaId",
                table: "Sequencias");

            migrationBuilder.AlterColumn<int>(
                name: "EscalaId",
                table: "Sequencias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sequencias_Escalas_EscalaId",
                table: "Sequencias",
                column: "EscalaId",
                principalTable: "Escalas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sequencias_Escalas_EscalaId",
                table: "Sequencias");

            migrationBuilder.AlterColumn<int>(
                name: "EscalaId",
                table: "Sequencias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sequencias_Escalas_EscalaId",
                table: "Sequencias",
                column: "EscalaId",
                principalTable: "Escalas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
