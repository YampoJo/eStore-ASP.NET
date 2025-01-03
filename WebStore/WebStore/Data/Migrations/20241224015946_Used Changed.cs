﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Data.Migrations
{
    public partial class UsedChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ApllicationId",
                table: "AspNetUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApllicationId",
                table: "AspNetUsers");
        }
    }
}
