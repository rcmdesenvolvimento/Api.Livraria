using Api.Livraria.Models;
using Api.Livraria.Services.Autor;
using Microsoft.AspNetCore.Mvc;

namespace Api.Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {

        private readonly IAutorInterface _autorInterface;

        public AutorController(IAutorInterface autorInterface)
        {
            _autorInterface = autorInterface;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Seja bem-vindo");
        }

        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {
            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);
        }


    }
}
