using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCShop.Migrations
{
    public partial class PopularHardware : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Hardwares(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsHardwarePreferido, Nome, Preco) VALUES(1,'A mid-range AMD graphics card designed for smooth 1080p gaming.', 'AMD RDNA 2 GPU, great for 1080p gaming, smooth performance, supports ray tracing.',1, 'images/hardwares/rx6600_thumbnail.jpg', 'images/hardwares/rx6600_imageurl.jpg',0, 'RX 6600 8GB', 199.99)");
            migrationBuilder.Sql("INSERT INTO Hardwares(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsHardwarePreferido, Nome, Preco) VALUES(1,'A mid-range NVIDIA graphics card designed for smooth 1080p gaming with ray tracing.', 'NVIDIA Ampere GPU, strong 1080p/1440p performance, ray tracing and DLSS support.',1, 'images/hardwares/rtx3060_thumbnail.jpg', 'images/hardwares/rtx3060_imageurl.jpg',0, 'RTX 3060 12GB', 269.99)");
            migrationBuilder.Sql("INSERT INTO Hardwares(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsHardwarePreferido, Nome, Preco) VALUES(1,'A high-end NVIDIA graphics card designed for 4K gaming and demanding creative workloads.', 'High-end NVIDIA GPU, 4K gaming, ray tracing, DLSS, and heavy creative workloads.',1, 'images/hardwares/gtx3090_thumbnail.jpg', 'images/hardwares/gtx3090_imageurl.jpg',0, 'RTX 3090 24GB', 699.99)");
            migrationBuilder.Sql("INSERT INTO Hardwares(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsHardwarePreferido, Nome, Preco) VALUES(2,'A mid-range AMD processor with integrated Radeon graphics.', 'AMD 6-core/12-thread CPU with integrated Radeon graphics, good for daily tasks and light gaming.',1, 'images/hardwares/r5600g_thumbnail.jpg', 'images/hardwares/r5600g_imageurl.jpg',1, 'Ryzen 5 5600g', 179.99)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Hardwares");
        }
    }
}
