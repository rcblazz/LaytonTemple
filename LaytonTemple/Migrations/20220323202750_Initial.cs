using Microsoft.EntityFrameworkCore.Migrations;

namespace LaytonTemple.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "timeslots",
                columns: table => new
                {
                    TimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Timeslot = table.Column<string>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timeslots", x => x.TimeId);
                });

            migrationBuilder.CreateTable(
                name: "TourGroup",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<long>(nullable: true),
                    Timeslot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourGroup", x => x.GroupId);
                });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 1, true, "03/23/2022 8 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 66, true, "03/28/2022 8 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 65, true, "03/27/2022 8 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 64, true, "03/27/2022 7 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 63, true, "03/27/2022 6 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 62, true, "03/27/2022 5 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 61, true, "03/27/2022 4 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 60, true, "03/27/2022 3 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 59, true, "03/27/2022 2 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 58, true, "03/27/2022 1 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 57, true, "03/27/2022 12 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 56, true, "03/27/2022 11 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 55, true, "03/27/2022 10 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 54, true, "03/27/2022 9 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 53, true, "03/27/2022 8 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 52, true, "03/26/2022 8 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 51, true, "03/26/2022 7 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 50, true, "03/26/2022 6 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 49, true, "03/26/2022 5 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 48, true, "03/26/2022 4 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 67, true, "03/28/2022 9 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 47, true, "03/26/2022 3 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 68, true, "03/28/2022 10 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 70, true, "03/28/2022 12 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 89, true, "03/29/2022 6 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 88, true, "03/29/2022 5 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 87, true, "03/29/2022 4 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 86, true, "03/29/2022 3 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 85, true, "03/29/2022 2 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 84, true, "03/29/2022 1 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 83, true, "03/29/2022 12 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 82, true, "03/29/2022 11 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 81, true, "03/29/2022 10 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 80, true, "03/29/2022 9 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 79, true, "03/29/2022 8 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 78, true, "03/28/2022 8 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 77, true, "03/28/2022 7 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 76, true, "03/28/2022 6 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 75, true, "03/28/2022 5 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 74, true, "03/28/2022 4 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 73, true, "03/28/2022 3 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 72, true, "03/28/2022 2 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 71, true, "03/28/2022 1 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 69, true, "03/28/2022 11 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 90, true, "03/29/2022 7 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 46, true, "03/26/2022 2 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 44, true, "03/26/2022 12 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 20, true, "03/24/2022 2 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 19, true, "03/24/2022 1 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 18, true, "03/24/2022 12 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 17, true, "03/24/2022 11 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 16, true, "03/24/2022 10 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 15, true, "03/24/2022 9 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 14, true, "03/24/2022 8 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 13, true, "03/23/2022 8 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 12, true, "03/23/2022 7 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 11, true, "03/23/2022 6 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 10, true, "03/23/2022 5 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 9, true, "03/23/2022 4 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 8, true, "03/23/2022 3 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 7, true, "03/23/2022 2 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 6, true, "03/23/2022 1 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 5, true, "03/23/2022 12 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 4, true, "03/23/2022 11 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 3, true, "03/23/2022 10 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 2, true, "03/23/2022 9 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 21, true, "03/24/2022 3 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 45, true, "03/26/2022 1 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 22, true, "03/24/2022 4 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 24, true, "03/24/2022 6 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 43, true, "03/26/2022 11 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 42, true, "03/26/2022 10 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 41, true, "03/26/2022 9 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 40, true, "03/26/2022 8 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 39, true, "03/25/2022 8 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 38, true, "03/25/2022 7 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 37, true, "03/25/2022 6 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 36, true, "03/25/2022 5 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 35, true, "03/25/2022 4 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 34, true, "03/25/2022 3 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 33, true, "03/25/2022 2 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 32, true, "03/25/2022 1 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 31, true, "03/25/2022 12 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 30, true, "03/25/2022 11 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 29, true, "03/25/2022 10 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 28, true, "03/25/2022 9 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 27, true, "03/25/2022 8 A.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 26, true, "03/24/2022 8 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 25, true, "03/24/2022 7 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 23, true, "03/24/2022 5 P.M." });

            migrationBuilder.InsertData(
                table: "timeslots",
                columns: new[] { "TimeId", "Available", "Timeslot" },
                values: new object[] { 91, true, "03/29/2022 8 P.M." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "timeslots");

            migrationBuilder.DropTable(
                name: "TourGroup");
        }
    }
}
