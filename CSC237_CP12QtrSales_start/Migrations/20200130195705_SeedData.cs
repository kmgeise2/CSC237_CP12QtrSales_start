using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CSC237_CP12QtrSales_start.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DOB", "DateOfHire", "Firstname", "Lastname", "ManagerId" },
                values: new object[] { 1, new DateTime(1956, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ada", "Lovelace", 0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DOB", "DateOfHire", "Firstname", "Lastname", "ManagerId" },
                values: new object[] { 2, new DateTime(1966, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Katherine", "Johnson", 1 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DOB", "DateOfHire", "Firstname", "Lastname", "ManagerId" },
                values: new object[] { 3, new DateTime(1975, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", "Hopper", 1 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SalesId", "Amount", "EmployeeId", "Quarter", "Year" },
                values: new object[,]
                {
                    { 1, 23456.0, 2, 4, 2019 },
                    { 2, 34567.0, 2, 1, 2020 },
                    { 3, 19876.0, 3, 4, 2019 },
                    { 4, 31009.0, 3, 1, 2020 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SalesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SalesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SalesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SalesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);
        }
    }
}
