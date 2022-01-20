using Microsoft.EntityFrameworkCore.Migrations;

namespace GMTVendorEvaluationWebApp.Migrations
{
	public partial class checkevaluate : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			//migrationBuilder.AddColumn<int>(
			//    name: "NumberofDepartments",
			//    table: "VendorEvaluations",
			//    type: "int",
			//    nullable: false,
			//    defaultValue: 0);

			//migrationBuilder.AddColumn<int>(
			//	name: "NumberofVendors",
			//	table: "VendorEvaluations",
			//	type: "int",
			//	nullable: false,
			//	defaultValue: 0);

			migrationBuilder.AddColumn<bool>(
				name: "departmental_evaluation",
				table: "Evaluation",
				type: "bit",
				nullable: false,
				defaultValue: false);

			////migrationBuilder.CreateTable(
			////	name: "UserRoles",
			////	columns: table => new
			////	{
			////		Id = table.Column<int>(type: "int", nullable: false)
			////			.Annotation("SqlServer:Identity", "1, 1"),
			////		RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
			////	},
			//	constraints: table =>
			//	{
			//		table.PrimaryKey("PK_UserRoles", x => x.Id);
			//	});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "UserRoles");

			migrationBuilder.DropColumn(
				name: "NumberofDepartments",
				table: "VendorEvaluations");

			migrationBuilder.DropColumn(
				name: "NumberofVendors",
				table: "VendorEvaluations");

			migrationBuilder.DropColumn(
				name: "departmental_evaluation",
				table: "Evaluation");
		}
	}
}