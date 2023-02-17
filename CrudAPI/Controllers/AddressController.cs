using CrudAPI.Interfaces;
using CrudAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [Route("api/Address")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly IRepository _repository;
        public AddressController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]

        [ProducesResponseType(200, Type = typeof(IEnumerable<RoleTable>))]

        public IActionResult GetRoles() 
        {

            var roles = _repository.GetRoles();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(roles);
        }
    }
}
