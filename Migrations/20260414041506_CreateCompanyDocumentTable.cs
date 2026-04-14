using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloTransporta.Migrations
{
    /// <inheritdoc />
    public partial class CreateCompanyDocumentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "company_documents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    file_url = table.Column<string>(type: "varchar(500)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    expiry_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    company_id = table.Column<int>(type: "int", nullable: false),
                    type_document_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company_documents", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "company_documents");
        }
    }
}
