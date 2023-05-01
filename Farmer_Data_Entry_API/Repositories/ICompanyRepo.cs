
using Farmer_Data_Entry_API.DTOs;
using Farmer_Data_Entry_API.Entities;

namespace Farmer_Data_Entry_API.Repositories
{
    public interface ICompanyRepo
    {
        public Task<IEnumerable<Company>> GetCompanies();
        public Task<Company> GetCompany(int id);
        public Task<Company> UpdateCompany(int id, CompanyDTO company);
        public Task DeleteCompany(int id);
        public Task<Company> CreateCompany(CompanyDTO company);
    }
}
