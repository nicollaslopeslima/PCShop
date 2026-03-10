using PCShop.Context;
using PCShop.Models;

namespace PCShop.Repositories.Interfaces
{
    public class CategoriarRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriarRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
