using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class CountryCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "citys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCapital = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_citys_countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Iran" },
                    { 2, "France" },
                    { 3, "Irland" },
                    { 4, "Usa" }
                });

            migrationBuilder.InsertData(
                table: "citys",
                columns: new[] { "Id", "CountryId", "IsCapital", "Name" },
                values: new object[,]
                {
                    { 1, 1, true, "Tehran" },
                    { 2, 1, false, "Shiraz" },
                    { 3, 1, false, "Tabriz" },
                    { 4, 2, true, "Paris" },
                    { 5, 2, false, "Lyon" },
                    { 6, 3, true, "Dublin" },
                    { 7, 4, false, "NewYork" },
                    { 8, 4, true, "Washington DC" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_citys_CountryId",
                table: "citys",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "citys");

            migrationBuilder.DropTable(
                name: "countries");
        }
    }
}
