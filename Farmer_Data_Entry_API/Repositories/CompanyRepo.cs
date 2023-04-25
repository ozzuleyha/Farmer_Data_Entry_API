using Farmer_Data_Entry_API.DTOs;
using Farmer_Data_Entry_API.Entities;

namespace Farmer_Data_Entry_API.Repositories
{
    public class CompanyRepo : ICompanyRepo
    {
        public Task<Company> CreateCompany(CompanyDTO company)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCompany(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Company>> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetCompany(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCompany(int id, CompanyDTO company)
        {
            throw new NotImplementedException();
        }
    }
}
