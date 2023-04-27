using Farmer_Data_Entry_API.Entities;
using Farmer_Data_Entry_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Farmer_Data_Entry_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmersController : ControllerBase
    {
        private readonly IFarmerRepo _farmerRepo;
        public FarmersController(IFarmerRepo farmerRepo) => _farmerRepo = farmerRepo;

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFarmer(Guid id)
        {
            await _farmerRepo.DeleteFarmer(id);
            return NoContent();
        }
        //[HttpGet("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetFarmers()
        {
            var farmers = await _farmerRepo.GetFarmers();
            return Ok(farmers);
        }
    }
}
