using Microsoft.EntityFrameworkCore.Migrations;

namespace Net5CodeFirst.Migrations
{
    public partial class Net5CodeFirstDataAccessCustomDBContext_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Schools");
        }
    }
}
