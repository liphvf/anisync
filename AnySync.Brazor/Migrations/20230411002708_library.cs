using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AnySync.Brazor.Migrations
{
    /// <inheritdoc />
    public partial class library : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "library_id",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "library_id",
                table: "mangas_entries",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "library_id",
                table: "animes_entries",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "library",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_library", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "ix_users_library_id",
                table: "users",
                column: "library_id");

            migrationBuilder.CreateIndex(
                name: "ix_mangas_entries_library_id",
                table: "mangas_entries",
                column: "library_id");

            migrationBuilder.CreateIndex(
                name: "ix_animes_entries_library_id",
                table: "animes_entries",
                column: "library_id");

            migrationBuilder.AddForeignKey(
                name: "fk_animes_entries_library_library_id",
                table: "animes_entries",
                column: "library_id",
                principalTable: "library",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_mangas_entries_library_library_id",
                table: "mangas_entries",
                column: "library_id",
                principalTable: "library",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_users_library_library_id",
                table: "users",
                column: "library_id",
                principalTable: "library",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_animes_entries_library_library_id",
                table: "animes_entries");

            migrationBuilder.DropForeignKey(
                name: "fk_mangas_entries_library_library_id",
                table: "mangas_entries");

            migrationBuilder.DropForeignKey(
                name: "fk_users_library_library_id",
                table: "users");

            migrationBuilder.DropTable(
                name: "library");

            migrationBuilder.DropIndex(
                name: "ix_users_library_id",
                table: "users");

            migrationBuilder.DropIndex(
                name: "ix_mangas_entries_library_id",
                table: "mangas_entries");

            migrationBuilder.DropIndex(
                name: "ix_animes_entries_library_id",
                table: "animes_entries");

            migrationBuilder.DropColumn(
                name: "library_id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "library_id",
                table: "mangas_entries");

            migrationBuilder.DropColumn(
                name: "library_id",
                table: "animes_entries");
        }
    }
}
