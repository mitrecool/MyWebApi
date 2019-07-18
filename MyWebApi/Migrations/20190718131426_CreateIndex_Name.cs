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

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pets",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pets",
                type: "nvarchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Pets",
                type: "nvarchar(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Goods",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Goods",
                type: "nvarchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Goods",
                type: "nvarchar(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "GoodId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("90f3bf1e-18a9-4601-b03d-d83a9f99ca4d"), "New soccer ball", "Soccer ball", 111.0m },
                    { new Guid("eb0738cd-a0cb-428c-8e3a-85c99d880b80"), "New foot ball", "Foot ball", 221.0m }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("785a153a-f0d9-4d66-b75e-61cf22443be4"), "Cute cat", "Cat", 111.0m },
                    { new Guid("b61fac69-cc44-4a3c-94da-b2205062b1db"), "Good boy", "Dog", 111.0m }
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
                keyValue: new Guid("90f3bf1e-18a9-4601-b03d-d83a9f99ca4d"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodId",
                keyValue: new Guid("eb0738cd-a0cb-428c-8e3a-85c99d880b80"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: new Guid("785a153a-f0d9-4d66-b75e-61cf22443be4"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: new Guid("b61fac69-cc44-4a3c-94da-b2205062b1db"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pets",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Pets",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Goods",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Goods",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Goods",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
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
