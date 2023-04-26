using Farmer_Data_Entry_API.DTOs;
using Farmer_Data_Entry_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Farmer_Data_Entry_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyRepo _companyRepo;
        public CompaniesController(ICompanyRepo companyRepo) => _companyRepo = companyRepo;
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            //var dbCompany = await _companyRepo.GetCompany(id);
            //if (dbCompany is null)
            //{
            //    return NotFound();
            //}
            await _companyRepo.DeleteCompany(id);
            return NoContent();
        }
    
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            var company = await _companyRepo.GetCompany(id);
            if (company is null)
            {
                return NotFound();
            }
            return Ok(company);
        }
        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _companyRepo.GetCompanies();
            
            return Ok(companies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyDTO company)
        {
            var createdCompany = await _companyRepo.CreateCompany(company);
            return Ok(createdCompany);
        }


    }
}
