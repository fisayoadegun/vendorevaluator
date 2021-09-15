using Microsoft.EntityFrameworkCore.Migrations;

namespace GMTVendorEvaluationWebApp.Migrations
{
    public partial class testcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "type_of_business",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type_of_business",
                table: "Vendor");
        }
    }
}
