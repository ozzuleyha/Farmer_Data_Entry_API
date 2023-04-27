using Dapper;
using Farmer_Data_Entry_API.Context;
using Farmer_Data_Entry_API.DTOs;
using Farmer_Data_Entry_API.Entities;
using System.Data;

namespace Farmer_Data_Entry_API.Repositories
{
    public class FarmerRepo : IFarmerRepo
    {
        private readonly DapperContext _context;
        public FarmerRepo(DapperContext context) => _context = context; 
        public Task<Farmer> CreateFarmer(FarmerDTO farmer)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteFarmer(Guid id)
        {
            var procedureName = "deleteFarmer";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Guid, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(procedureName,parameters, commandType: CommandType.StoredProcedure);
               
            }
        }

        public async Task<Farmer> GetFarmer(Guid id)
        {
            var procedureName = "getFarmer";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Guid, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                var farmer = await connection.QueryFirstOrDefaultAsync<Farmer>(procedureName, commandType: CommandType.StoredProcedure);
                return farmer;
            }
        }

        public async Task<IEnumerable<Farmer>> GetFarmers()
        {
            var procedureName = "getFarmers";
            using(var connection = _context.CreateConnection())
            {
                var farmers = await connection.QueryAsync<Farmer>(procedureName, commandType: CommandType.StoredProcedure);
                return farmers.ToList();
            }
        }

        public Task UpdateFarmer(Guid id, FarmerDTO farmer)
        {
            throw new NotImplementedException();
        }
    }
}
