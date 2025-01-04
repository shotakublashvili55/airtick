using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aircraft",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    regNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    capacitySecondEconom = table.Column<int>(type: "int", nullable: false),
                    capacityBuisness = table.Column<int>(type: "int", nullable: false),
                    manufactureYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aircraft", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "airline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HostAirport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_airline", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "boarding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Window = table.Column<bool>(type: "bit", nullable: false),
                    PassengerId = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boarding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ArrivalFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "flights",
                columns: table => new
                {
                    RouteNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AircraftRegNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromHostCity = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FromCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Airline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    PriceBuiAdult = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceEcoAdult = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceBuiChild = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceEcoChild = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceBaggage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Food = table.Column<bool>(type: "bit", nullable: false),
                    CancellationBefore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flights", x => x.RouteNo);
                });

            migrationBuilder.CreateTable(
                name: "passenger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passenger", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aircraft");

            migrationBuilder.DropTable(
                name: "airline");

            migrationBuilder.DropTable(
                name: "boarding");

            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "flights");

            migrationBuilder.DropTable(
                name: "passenger");
        }
    }
}
