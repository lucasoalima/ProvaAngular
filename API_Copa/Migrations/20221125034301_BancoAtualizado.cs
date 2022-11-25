using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class BancoAtualizado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId",
                table: "Jogos");

            migrationBuilder.RenameColumn(
                name: "SelecaoBId",
                table: "Jogos",
                newName: "SelecaoBid");

            migrationBuilder.RenameColumn(
                name: "SelecaoAId",
                table: "Jogos",
                newName: "SelecaoAid");

            migrationBuilder.RenameColumn(
                name: "SelecaoB_gols",
                table: "Jogos",
                newName: "SelecaoBplacar");

            migrationBuilder.RenameColumn(
                name: "SelecaoA_gols",
                table: "Jogos",
                newName: "SelecaoAplacar");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_SelecaoBId",
                table: "Jogos",
                newName: "IX_Jogos_SelecaoBid");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_SelecaoAId",
                table: "Jogos",
                newName: "IX_Jogos_SelecaoAid");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAid",
                table: "Jogos",
                column: "SelecaoAid",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBid",
                table: "Jogos",
                column: "SelecaoBid",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAid",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBid",
                table: "Jogos");

            migrationBuilder.RenameColumn(
                name: "SelecaoBid",
                table: "Jogos",
                newName: "SelecaoBId");

            migrationBuilder.RenameColumn(
                name: "SelecaoAid",
                table: "Jogos",
                newName: "SelecaoAId");

            migrationBuilder.RenameColumn(
                name: "SelecaoBplacar",
                table: "Jogos",
                newName: "SelecaoB_gols");

            migrationBuilder.RenameColumn(
                name: "SelecaoAplacar",
                table: "Jogos",
                newName: "SelecaoA_gols");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_SelecaoBid",
                table: "Jogos",
                newName: "IX_Jogos_SelecaoBId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_SelecaoAid",
                table: "Jogos",
                newName: "IX_Jogos_SelecaoAId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAId",
                table: "Jogos",
                column: "SelecaoAId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId",
                table: "Jogos",
                column: "SelecaoBId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
