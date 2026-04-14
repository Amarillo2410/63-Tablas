using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloTransporta.Migrations
{
    /// <inheritdoc />
    public partial class CreateCreditWalletTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "credit_wallet",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    balance = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false),
                    person_id = table.Column<int>(type: "int", nullable: true),
                    company_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_credit_wallet", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "credit_wallet");
        }
    }
}
