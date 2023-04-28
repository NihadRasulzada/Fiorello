using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class AddSliderHelp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SliderHelpId",
                table: "Sliders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SliderHelp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderHelp", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_SliderHelpId",
                table: "Sliders",
                column: "SliderHelpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_SliderHelp_SliderHelpId",
                table: "Sliders",
                column: "SliderHelpId",
                principalTable: "SliderHelp",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_SliderHelp_SliderHelpId",
                table: "Sliders");

            migrationBuilder.DropTable(
                name: "SliderHelp");

            migrationBuilder.DropIndex(
                name: "IX_Sliders_SliderHelpId",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "SliderHelpId",
                table: "Sliders");
        }
    }
}
