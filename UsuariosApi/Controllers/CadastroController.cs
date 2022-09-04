using FluentResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Data.Requests;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController()]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private CadastroService _cadastroService;

        public CadastroController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto createDto)
        {
            Result result = _cadastroService.CadastraUsuario(createDto);
            if (result.IsFailed) return StatusCode(500);
            return Ok(result.Successes);
        }
        [HttpGet("/ativa")]
        public IActionResult AtivaConta([FromQuery]AtivaContaRequest request)
        {
            Result result = _cadastroService.AtivaContaUsuario(request);
            if (result.IsFailed) return StatusCode(500);
            return Ok(result.Successes);
        }
    }
}
