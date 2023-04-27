using Farmer_Data_Entry_API.DTOs;
using Farmer_Data_Entry_API.Entities;

namespace Farmer_Data_Entry_API.Repositories
{
    public interface IFarmerRepo
    {
        public Task<IEnumerable<Farmer>> GetFarmers();
        public Task<Farmer> GetFarmer(Guid id);
        public Task UpdateFarmer(Guid id, FarmerDTO farmer);
        public Task DeleteFarmer(Guid id);
        public Task<Farmer> CreateFarmer(FarmerDTO farmer);
    }
}
