using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class NewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "EducationPlans");

            migrationBuilder.AddColumn<int>(
                name: "ShiftTimeId",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ShiftTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftTimes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ShiftTimeId",
                table: "Groups",
                column: "ShiftTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_ShiftTimes_ShiftTimeId",
                table: "Groups",
                column: "ShiftTimeId",
                principalTable: "ShiftTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_ShiftTimes_ShiftTimeId",
                table: "Groups");

            migrationBuilder.DropTable(
                name: "ShiftTimes");

            migrationBuilder.DropIndex(
                name: "IX_Groups_ShiftTimeId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ShiftTimeId",
                table: "Groups");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "EducationPlans",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
