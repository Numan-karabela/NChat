using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NChat.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Messages_MessageId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Messages_SentMessagesId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SentMessagesId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MessageId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SentMessagesId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ReceivedId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Messages",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceivedId",
                table: "Messages",
                column: "ReceivedId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_ReceivedId",
                table: "Messages",
                column: "ReceivedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_ReceivedId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReceivedId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Messages");

            migrationBuilder.AddColumn<Guid>(
                name: "SentMessagesId1",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "ReceivedId",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "MessageId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_SentMessagesId1",
                table: "Users",
                column: "SentMessagesId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MessageId",
                table: "AspNetUsers",
                column: "MessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Messages_MessageId",
                table: "AspNetUsers",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Messages_SentMessagesId1",
                table: "Users",
                column: "SentMessagesId1",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
