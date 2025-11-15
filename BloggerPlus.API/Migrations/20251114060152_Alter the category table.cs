using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloggerPlus.API.Migrations
{
    /// <inheritdoc />
    public partial class Alterthecategorytable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "FeaturedImageUrl",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PublishedDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeaturedImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
