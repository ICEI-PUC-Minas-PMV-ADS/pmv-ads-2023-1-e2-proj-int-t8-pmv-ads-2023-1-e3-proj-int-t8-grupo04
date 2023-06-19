using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyClosetWeb.Migrations
{
    
    public partial class AdicionandoImageERelacionamentoUser : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Users_UserId",
                table: "Clothes");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_UserId",
                table: "Clothes");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Clothes",
                newName: "Type");

            migrationBuilder.AddColumn<int>(
                name: "ClosetId",
                table: "Clothes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Clothes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Closet",
                columns: table => new
                {
                    ClosetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Closet", x => x.ClosetId);
                    table.ForeignKey(
                        name: "FK_Closet_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_ClosetId",
                table: "Clothes",
                column: "ClosetId");

            migrationBuilder.CreateIndex(
                name: "IX_Closet_UserId",
                table: "Closet",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Closet_ClosetId",
                table: "Clothes",
                column: "ClosetId",
                principalTable: "Closet",
                principalColumn: "ClosetId");
        }

        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Closet_ClosetId",
                table: "Clothes");

            migrationBuilder.DropTable(
                name: "Closet");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_ClosetId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "ClosetId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Clothes");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Clothes",
                newName: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_UserId",
                table: "Clothes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Users_UserId",
                table: "Clothes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
