using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_testimonials",
                table: "testimonials");

            migrationBuilder.RenameTable(
                name: "testimonials",
                newName: "Testimonials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials",
                column: "TestimonialID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials");

            migrationBuilder.RenameTable(
                name: "Testimonials",
                newName: "testimonials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_testimonials",
                table: "testimonials",
                column: "TestimonialID");
        }
    }
}
