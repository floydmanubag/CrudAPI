using CrudAPI.Interfaces;
using CrudAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WarehouseController : Controller
    {
        private readonly IRepository _repository;
        public WarehouseController(IRepository repository)
        {
            _repository= repository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Role>))]
        public IActionResult GetRoles()
        {
            var roles = _repository.GetRoles;

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(roles);
        }
    }
}
