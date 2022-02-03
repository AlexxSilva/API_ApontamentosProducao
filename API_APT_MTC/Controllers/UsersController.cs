using API_APT_MTC.Filters;
using API_APT_MTC.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;

namespace API_APT_MTC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [APIKeyAuth]
    public class UsersController : Controller
    {

        public readonly IRepositorio_Users _repo;
        public UsersController(IRepositorio_Users repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public IActionResult GetAllUsers() //Task<IActionResult>
        {
            try
            {

                var results = _repo.GetAllUsuariosAtivos(); // var results = await _repo.GetAllUsuariosAtivos();
                return Ok(results);
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");

            }
        }



    }
}
