using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccesLayer.Migrations
{
    public partial class mig_add_relation_customerAccount_appUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppuserID",
                table: "CustomerAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccounts_AppuserID",
                table: "CustomerAccounts",
                column: "AppuserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppuserID",
                table: "CustomerAccounts",
                column: "AppuserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppuserID",
                table: "CustomerAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccounts_AppuserID",
                table: "CustomerAccounts");

            migrationBuilder.DropColumn(
                name: "AppuserID",
                table: "CustomerAccounts");
        }
    }
}
