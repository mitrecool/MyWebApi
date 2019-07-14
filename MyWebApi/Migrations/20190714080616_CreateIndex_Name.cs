using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApi.Migrations
{
    public partial class CreateIndex_Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pets",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Goods",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "GoodId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("33a644db-6d21-4126-a985-112637d1ef2a"), "New soccer ball", "Soccer ball", 111.0m },
                    { new Guid("eb9303fc-7a7f-4a50-bb1e-2df5aef221de"), "New foot ball", "Foot ball", 221.0m }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("077ded3b-8f61-4f02-bd7c-e75220ecff05"), "Cute cat", "Cat", 111.0m },
                    { new Guid("0a5bc2ae-a65b-4bf6-ae75-238d43eeb55e"), "Good boy", "Dog", 111.0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_Name",
                table: "Pets",
                column: "Name")
                .Annotation("SqlServer:Include", new[] { "Description", "Price" });

            migrationBuilder.CreateIndex(
                name: "IX_Goods_Name",
                table: "Goods",
                column: "Name")
                .Annotation("SqlServer:Include", new[] { "Description", "Price" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pets_Name",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Goods_Name",
                table: "Goods");

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodId",
                keyValue: new Guid("33a644db-6d21-4126-a985-112637d1ef2a"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodId",
                keyValue: new Guid("eb9303fc-7a7f-4a50-bb1e-2df5aef221de"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: new Guid("077ded3b-8f61-4f02-bd7c-e75220ecff05"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: new Guid("0a5bc2ae-a65b-4bf6-ae75-238d43eeb55e"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pets",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Goods",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
