using Farmer_Data_Entry_API.DTOs;
using Farmer_Data_Entry_API.Entities;

namespace Farmer_Data_Entry_API.Repositories
{
    public interface IVillageRepo
    {
        public Task<IEnumerable<Village>> GetVillages();
        public Task<Village> GetVillage(int id);
        public Task UpdateVillage(int id, VillageDTO company);
        public Task DeleteVillage(int id);
        public Task<Village> CreateVillage(VillageDTO company);
    }
}
