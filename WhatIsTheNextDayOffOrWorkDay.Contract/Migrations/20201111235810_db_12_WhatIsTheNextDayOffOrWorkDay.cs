using Microsoft.EntityFrameworkCore.Migrations;

namespace WhatIsTheNextDayOffOrWorkDay.Repository.Migrations
{
    public partial class db_12_WhatIsTheNextDayOffOrWorkDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pessoas",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pessoas");
        }
    }
}
