using PCShop.Models;

namespace PCShop.Repositories.Interfaces
{
    public interface IHardwareRepository
    {
        IEnumerable<Hardware> Hardwares { get; }
        IEnumerable<Hardware> HardwaresPreferidos { get; }
        Hardware GetHardwareById(int hardwareId);

    }
}
