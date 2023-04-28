using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class AddSliderHelpId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_SliderHelp_SliderHelpId",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "SliderId",
                table: "SliderHelp");

            migrationBuilder.AlterColumn<int>(
                name: "SliderHelpId",
                table: "Sliders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_SliderHelp_SliderHelpId",
                table: "Sliders",
                column: "SliderHelpId",
                principalTable: "SliderHelp",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_SliderHelp_SliderHelpId",
                table: "Sliders");

            migrationBuilder.AlterColumn<int>(
                name: "SliderHelpId",
                table: "Sliders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SliderId",
                table: "SliderHelp",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_SliderHelp_SliderHelpId",
                table: "Sliders",
                column: "SliderHelpId",
                principalTable: "SliderHelp",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
