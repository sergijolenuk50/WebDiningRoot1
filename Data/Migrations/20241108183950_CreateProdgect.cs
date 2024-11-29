using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateProdgect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bread",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bread", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drinkc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinkc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FirstDishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstDishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Garnish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garnish", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeatDishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeatDishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayWeek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreadId = table.Column<int>(type: "int", nullable: false),
                    SaladId = table.Column<int>(type: "int", nullable: false),
                    FirstDishesId = table.Column<int>(type: "int", nullable: false),
                    GarnishId = table.Column<int>(type: "int", nullable: false),
                    MeatDishesId = table.Column<int>(type: "int", nullable: false),
                    DrinkcId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Bread_BreadId",
                        column: x => x.BreadId,
                        principalTable: "Bread",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menu_Drinkc_DrinkcId",
                        column: x => x.DrinkcId,
                        principalTable: "Drinkc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menu_FirstDishes_FirstDishesId",
                        column: x => x.FirstDishesId,
                        principalTable: "FirstDishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menu_Garnish_GarnishId",
                        column: x => x.GarnishId,
                        principalTable: "Garnish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menu_MeatDishes_MeatDishesId",
                        column: x => x.MeatDishesId,
                        principalTable: "MeatDishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menu_Salad_SaladId",
                        column: x => x.SaladId,
                        principalTable: "Salad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bread",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Цільнозерновий" },
                    { 2, "з висівками" }
                });

            migrationBuilder.InsertData(
                table: "Drinkc",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Чай" },
                    { 2, "Какао" }
                });

            migrationBuilder.InsertData(
                table: "FirstDishes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Суп гороховий" });

            migrationBuilder.InsertData(
                table: "Garnish",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Каша кукурудзяна" });

            migrationBuilder.InsertData(
                table: "MeatDishes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Нагіци з курки" });

            migrationBuilder.InsertData(
                table: "Salad",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Салат з капусти" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "BreadId", "Date", "DayWeek", "DrinkcId", "FirstDishesId", "GarnishId", "MeatDishesId", "Name", "SaladId" },
                values: new object[] { 1, 1, new DateTime(1985, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Понеділок", 2, 1, 1, 1, "1-4 Клас", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Menu_BreadId",
                table: "Menu",
                column: "BreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_DrinkcId",
                table: "Menu",
                column: "DrinkcId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_FirstDishesId",
                table: "Menu",
                column: "FirstDishesId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_GarnishId",
                table: "Menu",
                column: "GarnishId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_MeatDishesId",
                table: "Menu",
                column: "MeatDishesId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_SaladId",
                table: "Menu",
                column: "SaladId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Bread");

            migrationBuilder.DropTable(
                name: "Drinkc");

            migrationBuilder.DropTable(
                name: "FirstDishes");

            migrationBuilder.DropTable(
                name: "Garnish");

            migrationBuilder.DropTable(
                name: "MeatDishes");

            migrationBuilder.DropTable(
                name: "Salad");
        }
    }
}
