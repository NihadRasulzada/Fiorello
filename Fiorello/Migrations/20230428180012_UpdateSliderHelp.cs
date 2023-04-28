using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class UpdateSliderHelp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_SliderHelps_SliderHelpId",
                table: "Sliders");

            migrationBuilder.DropIndex(
                name: "IX_Sliders_SliderHelpId",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "SliderHelpId",
                table: "Sliders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SliderHelpId",
                table: "Sliders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_SliderHelpId",
                table: "Sliders",
                column: "SliderHelpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_SliderHelps_SliderHelpId",
                table: "Sliders",
                column: "SliderHelpId",
                principalTable: "SliderHelps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
