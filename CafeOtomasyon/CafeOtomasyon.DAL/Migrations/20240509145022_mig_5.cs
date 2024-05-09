using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeOtomasyon.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MasaHareketleri_MasaId",
                table: "MasaHareketleri",
                column: "MasaId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciHareketleri_KullaniciId",
                table: "KullaniciHareketleri",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_KullaniciHareketleri_Kullanicilar_KullaniciId",
                table: "KullaniciHareketleri",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasaHareketleri_Masalar_MasaId",
                table: "MasaHareketleri",
                column: "MasaId",
                principalTable: "Masalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KullaniciHareketleri_Kullanicilar_KullaniciId",
                table: "KullaniciHareketleri");

            migrationBuilder.DropForeignKey(
                name: "FK_MasaHareketleri_Masalar_MasaId",
                table: "MasaHareketleri");

            migrationBuilder.DropIndex(
                name: "IX_MasaHareketleri_MasaId",
                table: "MasaHareketleri");

            migrationBuilder.DropIndex(
                name: "IX_KullaniciHareketleri_KullaniciId",
                table: "KullaniciHareketleri");
        }
    }
}
