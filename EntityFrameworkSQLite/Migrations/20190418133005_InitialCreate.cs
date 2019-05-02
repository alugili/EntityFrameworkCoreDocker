using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkSQLite.Migrations
{
  public partial class InitialCreate : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Orders",
          columns: table => new
          {
            OrderId = table.Column<int>(nullable: false)
                  .Annotation("Sqlite:Autoincrement", true),
            Name = table.Column<string>(nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Orders", x => x.OrderId);
          });

      migrationBuilder.InsertData(
          table: "Orders",
          columns: new[] { "OrderId", "Name" },
          values: new object[] { 1, "MSDN Order" });

      migrationBuilder.InsertData(
          table: "Orders",
          columns: new[] { "OrderId", "Name" },
          values: new object[] { 2, "Docker Order" });

      migrationBuilder.InsertData(
          table: "Orders",
          columns: new[] { "OrderId", "Name" },
          values: new object[] { 3, "EFCore Order" });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(name: "Orders");
    }
  }
}
