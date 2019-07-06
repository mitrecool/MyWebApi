using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApi.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "GoodId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("142c9c42-d34e-4edd-b1ed-1958a5c25f73"), "New soccer ball", "Soccer ball", 111.0m },
                    { new Guid("15ea14cd-6e9a-4666-87c2-e2d7ca75fc39"), "New foot ball", "Foot ball", 221.0m }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1abbd107-e590-4062-a170-7016630e91ac"), "Cute cat", "Cat", 111.0m },
                    { new Guid("d177e5be-9e00-41ba-98f1-ba21649ee745"), "Good boy", "Dog", 111.0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodId",
                keyValue: new Guid("142c9c42-d34e-4edd-b1ed-1958a5c25f73"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodId",
                keyValue: new Guid("15ea14cd-6e9a-4666-87c2-e2d7ca75fc39"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: new Guid("1abbd107-e590-4062-a170-7016630e91ac"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: new Guid("d177e5be-9e00-41ba-98f1-ba21649ee745"));
        }
    }
}
