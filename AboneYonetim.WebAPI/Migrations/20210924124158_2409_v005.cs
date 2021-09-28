using Microsoft.EntityFrameworkCore.Migrations;

namespace AboneYonetim.WebAPI.Migrations
{
    public partial class _2409_v005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FATURALAR_TAHSILATLAR_TahsilatID",
                table: "FATURALAR");

            migrationBuilder.DropIndex(
                name: "IX_FATURALAR_TahsilatID",
                table: "FATURALAR");

            migrationBuilder.DropColumn(
                name: "TahsilatID",
                table: "FATURALAR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TahsilatID",
                table: "FATURALAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FATURALAR_TahsilatID",
                table: "FATURALAR",
                column: "TahsilatID");

            migrationBuilder.AddForeignKey(
                name: "FK_FATURALAR_TAHSILATLAR_TahsilatID",
                table: "FATURALAR",
                column: "TahsilatID",
                principalTable: "TAHSILATLAR",
                principalColumn: "ObjectID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
