using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnySync.Brazor.Migrations
{
    /// <inheritdoc />
    public partial class libraryfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_users_library_library_id",
                table: "users");

            migrationBuilder.DropIndex(
                name: "ix_users_library_id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "library_id",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "library",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_library_user_id",
                table: "library",
                column: "user_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_library_users_user_id",
                table: "library",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_library_users_user_id",
                table: "library");

            migrationBuilder.DropIndex(
                name: "ix_library_user_id",
                table: "library");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "library");

            migrationBuilder.AddColumn<int>(
                name: "library_id",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_users_library_id",
                table: "users",
                column: "library_id");

            migrationBuilder.AddForeignKey(
                name: "fk_users_library_library_id",
                table: "users",
                column: "library_id",
                principalTable: "library",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
