using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GMTVendorEvaluationWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Criteria",
                columns: table => new
                {
                    criteriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    criteria_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria", x => x.criteriaID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    departmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    department_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.departmentID);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    vendorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contact_person = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.vendorID);
                });

            migrationBuilder.CreateTable(
                name: "Product_Service",
                columns: table => new
                {
                    product_serviceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vendor_id = table.Column<int>(type: "int", nullable: false),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    product_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_delivered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vendorID = table.Column<int>(type: "int", nullable: true),
                    departmentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Service", x => x.product_serviceID);
                    table.ForeignKey(
                        name: "FK_Product_Service_Department_departmentID",
                        column: x => x.departmentID,
                        principalTable: "Department",
                        principalColumn: "departmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Service_Vendor_vendorID",
                        column: x => x.vendorID,
                        principalTable: "Vendor",
                        principalColumn: "vendorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    evaluationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_serviceID = table.Column<int>(type: "int", nullable: false),
                    criteriaID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.evaluationID);
                    table.ForeignKey(
                        name: "FK_Evaluation_Criteria_criteriaID",
                        column: x => x.criteriaID,
                        principalTable: "Criteria",
                        principalColumn: "criteriaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluation_Product_Service_product_serviceID",
                        column: x => x.product_serviceID,
                        principalTable: "Product_Service",
                        principalColumn: "product_serviceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_criteriaID",
                table: "Evaluation",
                column: "criteriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_product_serviceID",
                table: "Evaluation",
                column: "product_serviceID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Service_departmentID",
                table: "Product_Service",
                column: "departmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Service_vendorID",
                table: "Product_Service",
                column: "vendorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "Criteria");

            migrationBuilder.DropTable(
                name: "Product_Service");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
