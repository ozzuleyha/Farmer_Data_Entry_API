using Farmer_Data_Entry_API.DTOs;
using Farmer_Data_Entry_API.Entities;

namespace Farmer_Data_Entry_API.Repositories
{
    public class VillageRepo : IVillageRepo
    {
        public Task<Village> CreateVillage(VillageDTO company)
        {
            throw new NotImplementedException();
        }

        public Task DeleteVillage(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Village> GetVillage(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Village>> GetVillages()
        {
            throw new NotImplementedException();
        }

        public Task UpdateVillage(int id, VillageDTO company)
        {
            throw new NotImplementedException();
        }
    }
}
