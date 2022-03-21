using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LiJiT.API.Migrations
{
    public partial class changeAboutModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "aboutContents",
                newName: "Title2");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "aboutContents",
                newName: "Title1");

            migrationBuilder.AddColumn<string>(
                name: "Content1",
                table: "aboutContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content2",
                table: "aboutContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "aboutContents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "aboutContents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageAbout",
                table: "aboutContents",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "aboutContents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShareLink",
                table: "aboutContents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telephon",
                table: "aboutContents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "aboutContents",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content1",
                table: "aboutContents");

            migrationBuilder.DropColumn(
                name: "Content2",
                table: "aboutContents");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "aboutContents");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "aboutContents");

            migrationBuilder.DropColumn(
                name: "ImageAbout",
                table: "aboutContents");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "aboutContents");

            migrationBuilder.DropColumn(
                name: "ShareLink",
                table: "aboutContents");

            migrationBuilder.DropColumn(
                name: "Telephon",
                table: "aboutContents");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "aboutContents");

            migrationBuilder.RenameColumn(
                name: "Title2",
                table: "aboutContents",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Title1",
                table: "aboutContents",
                newName: "Content");
        }
    }
}
