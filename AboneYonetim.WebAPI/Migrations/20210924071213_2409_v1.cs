using Microsoft.EntityFrameworkCore.Migrations;

namespace AboneYonetim.WebAPI.Migrations
{
    public partial class _2409_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TAHSILATLAR_FaturaID",
                table: "TAHSILATLAR");

            migrationBuilder.AddColumn<int>(
                name: "TahsilatID",
                table: "FATURALAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TAHSILATLAR_FaturaID",
                table: "TAHSILATLAR",
                column: "FaturaID");

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
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FATURALAR_TAHSILATLAR_TahsilatID",
                table: "FATURALAR");

            migrationBuilder.DropIndex(
                name: "IX_TAHSILATLAR_FaturaID",
                table: "TAHSILATLAR");

            migrationBuilder.DropIndex(
                name: "IX_FATURALAR_TahsilatID",
                table: "FATURALAR");

            migrationBuilder.DropColumn(
                name: "TahsilatID",
                table: "FATURALAR");

            migrationBuilder.CreateIndex(
                name: "IX_TAHSILATLAR_FaturaID",
                table: "TAHSILATLAR",
                column: "FaturaID",
                unique: true);
        }
    }
}
