using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class AddDbSetSliderHelp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_SliderHelp_SliderHelpId",
                table: "Sliders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SliderHelp",
                table: "SliderHelp");

            migrationBuilder.RenameTable(
                name: "SliderHelp",
                newName: "SliderHelps");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SliderHelps",
                table: "SliderHelps",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_SliderHelps_SliderHelpId",
                table: "Sliders",
                column: "SliderHelpId",
                principalTable: "SliderHelps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_SliderHelps_SliderHelpId",
                table: "Sliders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SliderHelps",
                table: "SliderHelps");

            migrationBuilder.RenameTable(
                name: "SliderHelps",
                newName: "SliderHelp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SliderHelp",
                table: "SliderHelp",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_SliderHelp_SliderHelpId",
                table: "Sliders",
                column: "SliderHelpId",
                principalTable: "SliderHelp",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
