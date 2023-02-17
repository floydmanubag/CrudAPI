using CrudAPI.DTO;
using CrudAPI.Interfaces;
using CrudAPI.Models;
using DBDataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Controllers
{
    [Route("api/Roles")]
    [ApiController]

    public class RolesController : Controller
    {
        private readonly IRepository _repository;
        public RolesController(IRepository repository)
        {
            _repository= repository;
        }

        [HttpGet]

        [ProducesResponseType(200, Type = typeof(IEnumerable<RoleTable>))]

        public IActionResult GetRoles() //dto
        {

            var roles = _repository.GetRoles();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(roles);
        }

    }

}
