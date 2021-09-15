using Microsoft.EntityFrameworkCore.Migrations;

namespace GMTVendorEvaluationWebApp.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Service_Department_departmentID",
                table: "Product_Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Service_Vendor_vendorID",
                table: "Product_Service");

            migrationBuilder.DropColumn(
                name: "department_id",
                table: "Product_Service");

            migrationBuilder.DropColumn(
                name: "vendor_id",
                table: "Product_Service");

            migrationBuilder.AlterColumn<int>(
                name: "vendorID",
                table: "Product_Service",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "departmentID",
                table: "Product_Service",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Service_Department_departmentID",
                table: "Product_Service",
                column: "departmentID",
                principalTable: "Department",
                principalColumn: "departmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Service_Vendor_vendorID",
                table: "Product_Service",
                column: "vendorID",
                principalTable: "Vendor",
                principalColumn: "vendorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Service_Department_departmentID",
                table: "Product_Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Service_Vendor_vendorID",
                table: "Product_Service");

            migrationBuilder.AlterColumn<int>(
                name: "vendorID",
                table: "Product_Service",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "departmentID",
                table: "Product_Service",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "department_id",
                table: "Product_Service",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "vendor_id",
                table: "Product_Service",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Service_Department_departmentID",
                table: "Product_Service",
                column: "departmentID",
                principalTable: "Department",
                principalColumn: "departmentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Service_Vendor_vendorID",
                table: "Product_Service",
                column: "vendorID",
                principalTable: "Vendor",
                principalColumn: "vendorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
