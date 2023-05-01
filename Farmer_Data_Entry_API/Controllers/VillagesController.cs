using Farmer_Data_Entry_API.DTOs;
using Farmer_Data_Entry_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Farmer_Data_Entry_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillagesController : ControllerBase
    {
        private readonly IVillageRepo _villageRepo;
        public VillagesController(IVillageRepo villageRepo) => _villageRepo = villageRepo;

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVillage(int id)
        {
            await _villageRepo.DeleteVillage(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVillage(int id)
        {
            var village = await _villageRepo.GetVillage(id);
            if (village is null)
            {
                return NotFound();
            }
            return Ok(village);
        }
        [HttpGet]
        public async Task<IActionResult> GetVillages()
        {
            var villages = await _villageRepo.GetVillages();

            return Ok(villages);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVillage([FromBody] VillageDTO village)
        {
            var createdVillage = await _villageRepo.CreateVillage(village);
            return Ok(createdVillage);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVillage([FromBody] int id, VillageDTO village)
        {
            var updatedVillage = await _villageRepo.UpdateVillage(id, village);
            return Ok(updatedVillage);
        }

    }
}
}
