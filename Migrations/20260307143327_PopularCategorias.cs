using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCShop.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('Graphics Card', 'A hardware component responsible for rendering images, videos, and graphics on a computer display.')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('CPU', 'The main hardware component responsible for executing instructions and processing data in a computer.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
