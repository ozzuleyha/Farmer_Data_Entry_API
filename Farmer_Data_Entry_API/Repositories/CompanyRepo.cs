using Dapper;
using Farmer_Data_Entry_API.Context;
using Farmer_Data_Entry_API.DTOs;
using Farmer_Data_Entry_API.Entities;
using System.Data;

namespace Farmer_Data_Entry_API.Repositories
{
    public class CompanyRepo : ICompanyRepo
    {
        private readonly DapperContext _context;
        public CompanyRepo(DapperContext context) => _context = context;
        //Her birinde bir sp çağrılacak
        public async Task<Company> CreateCompany(CompanyDTO company)
        {
            var procedureName = "createCompany";
            var parameters = new DynamicParameters();
            parameters.Add("Name", company.Name, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var createdCompany = await connection.QueryFirstOrDefaultAsync<Company>(procedureName, parameters, commandType: CommandType.StoredProcedure);
                return createdCompany;
            }
        }

        public async Task DeleteCompany(int id)
        {
            var procedureName = "deleteCompany";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            var procedureName = "getCompanies";
            
            using (var connection = _context.CreateConnection())
            {
                var companies = await connection.QueryAsync<Company>(procedureName,  commandType: CommandType.StoredProcedure);

                return companies.ToList();
            }
        }

        //UID yapılacak idler


        public async Task<Company> GetCompany(int id)
        {
            var procedureName = "getCompany";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);

            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<Company>(procedureName, parameters, commandType: CommandType.StoredProcedure);
                
                return company;
            }
        }

        public Task UpdateCompany(int id, CompanyDTO company)
        {
            throw new NotImplementedException();
        }
    }
}
