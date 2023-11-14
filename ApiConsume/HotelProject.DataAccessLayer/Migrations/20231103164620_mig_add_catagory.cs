using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig_add_catagory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageCatagoryId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MessageCatagories",
                columns: table => new
                {
                    MessageCatagoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageCatagoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageCatagories", x => x.MessageCatagoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MessageCatagoryId",
                table: "Contacts",
                column: "MessageCatagoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCatagories_MessageCatagoryId",
                table: "Contacts",
                column: "MessageCatagoryId",
                principalTable: "MessageCatagories",
                principalColumn: "MessageCatagoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCatagories_MessageCatagoryId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "MessageCatagories");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_MessageCatagoryId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "MessageCatagoryId",
                table: "Contacts");
        }
    }
}
