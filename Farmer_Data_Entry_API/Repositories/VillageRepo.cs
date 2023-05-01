using Dapper;
using Farmer_Data_Entry_API.Context;
using Farmer_Data_Entry_API.DTOs;
using Farmer_Data_Entry_API.Entities;
using System.Data;

namespace Farmer_Data_Entry_API.Repositories
{
    public class VillageRepo : IVillageRepo
    {

        private readonly DapperContext _context;
        public VillageRepo(DapperContext context) => _context = context;

        public async Task<Village> CreateVillage(VillageDTO village)
        {
            var procedureName = "createVillage";
            var parameters = new DynamicParameters();
            parameters.Add("Name", village.VillageName, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var createdVillage = await connection.QueryFirstOrDefaultAsync<Village>(procedureName, parameters, commandType: CommandType.StoredProcedure);
                return createdVillage;
            }
        }

        public async Task DeleteVillage(int id)
        {
            var procedureName = "deleteVillage";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                var village = await connection.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<Village> GetVillage(int id)
        {
            var procedureName = "getVillage";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);

            using (var connection = _context.CreateConnection())
            {
                var village = await connection.QueryFirstOrDefaultAsync<Village>(procedureName, parameters, commandType: CommandType.StoredProcedure);

                return village;
            }
        }

        public async Task<IEnumerable<Village>> GetVillages()
        {
             var procedureName = "getVillages";

            using (var connection = _context.CreateConnection())
            {
                var villages = await connection.QueryAsync<Village>(procedureName, commandType: CommandType.StoredProcedure);

                return villages.ToList();
            }
        }

        public async Task<Village> UpdateVillage(int id, VillageDTO village)
        {
            var procedureName = "updateVillage";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.String);
            parameters.Add("Name", village.VillageName, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var updatedVillage = await connection.QueryFirstOrDefaultAsync<Village>(procedureName, parameters, commandType: CommandType.StoredProcedure);
                return updatedVillage;
            }
        }
    }
}
