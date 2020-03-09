using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    UID = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    Date_Of_Birth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    BookID = table.Column<Guid>(nullable: false),
                    BName = table.Column<string>(nullable: true),
                    ISBN = table.Column<string>(nullable: true),
                    Published_date = table.Column<DateTime>(nullable: false),
                    userUID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_books_user_userUID",
                        column: x => x.userUID,
                        principalTable: "user",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_userUID",
                table: "books",
                column: "userUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
