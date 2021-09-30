using Microsoft.EntityFrameworkCore.Migrations;

namespace GMTVendorEvaluationWebApp.Migrations
{
    public partial class departmentevaluation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "departmental_evaluation",
                table: "Product_Service",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "departmental_evaluation",
                table: "Product_Service");
        }
    }
}
