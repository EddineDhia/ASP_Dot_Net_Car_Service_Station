using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Service_Station.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "varchar(50)", nullable: false),
                    Model = table.Column<string>(type: "varchar(50)", nullable: false),
                    BodyType = table.Column<string>(type: "varchar(50)", nullable: false),
                    EngineSpec = table.Column<string>(type: "varchar(50)", nullable: false),
                    Energie = table.Column<string>(type: "varchar(50)", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    PlateLicence = table.Column<string>(type: "varchar(50)", nullable: false),
                    Model_Year = table.Column<int>(type: "int", nullable: false),
                    NextDateService = table.Column<DateTime>(type: "Date", nullable: false),
                    OwnerName = table.Column<string>(type: "varchar(50)", nullable: false),
                    OwnerEmail = table.Column<string>(type: "varchar(50)", nullable: false),
                    PriceInvoke = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCars",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCars", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_ServiceCars_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CarId",
                table: "Appointments",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCars_CarId",
                table: "ServiceCars",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "ServiceCars");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
