using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloTransporta.Migrations
{
    /// <inheritdoc />
    public partial class CreateSubscriptionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "subscriptions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    start_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    plan_id = table.Column<int>(type: "int", nullable: false),
                    subscriber_id = table.Column<int>(type: "int", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscriptions", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subscriptions");
        }
    }
}
