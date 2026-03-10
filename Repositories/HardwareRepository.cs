using Microsoft.EntityFrameworkCore;
using PCShop.Context;
using PCShop.Models;
using PCShop.Repositories.Interfaces;

namespace PCShop.Repositories
{
    public class HardwareRepository : IHardwareRepository
    {
        private readonly AppDbContext _context;
        public HardwareRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Hardware> Hardwares => _context.Hardwares.Include(c => c.Categoria);

        public IEnumerable<Hardware> HardwaresPreferidos => _context.Hardwares.
                                    Where(i => i.IsHardwarePreferido)
                                    .Include(c => c.Categoria);

        public Hardware GetHardwareById(int hardwareId)
        {
            return _context.Hardwares.FirstOrDefault(i => i.HardwareId == hardwareId);
        }
    }
}
