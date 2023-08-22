using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patient.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileNo = table.Column<int>(type: "int", nullable: false),
                    CitizenId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactRelation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstVisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "Address1", "Address2", "City", "Country", "Street" },
                values: new object[] { new Guid("dfe2516e-37a7-4b5c-ac37-ebc58f5e0a42"), "Apartment 4A", "Building XYZ", "New York", "United States", "123 Main Street" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "AddressId", "BirthDate", "CitizenId", "ContactPerson", "ContactPhone", "ContactRelation", "Email", "FileNo", "FirstVisitDate", "Gender", "Name", "Nationality", "PhoneNumber", "RecordCreationDate" },
                values: new object[] { new Guid("d73ee5d4-be83-4bce-b6e6-2b3b309e478c"), new Guid("dfe2516e-37a7-4b5c-ac37-ebc58f5e0a42"), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456789", "Jane Smith", "987-654-3210", "Spouse", "john.doe@example.com", 1001, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "John Doe", "USA", "123-456-7890", new DateTime(2023, 8, 23, 2, 11, 11, 521, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AddressId",
                table: "Patients",
                column: "AddressId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
