using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeOtomasyon.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Masalar_KullaniciId",
                table: "Masalar",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Masalar_Kullanicilar_KullaniciId",
                table: "Masalar",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Masalar_Kullanicilar_KullaniciId",
                table: "Masalar");

            migrationBuilder.DropIndex(
                name: "IX_Masalar_KullaniciId",
                table: "Masalar");
        }
    }
}
