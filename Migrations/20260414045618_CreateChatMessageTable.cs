using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloTransporta.Migrations
{
    /// <inheritdoc />
    public partial class CreateChatMessageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chat_messages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    message_text = table.Column<string>(type: "varchar(1000)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sent_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    room_id = table.Column<int>(type: "int", nullable: false),
                    sender_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chat_messages", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chat_messages");
        }
    }
}
