using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Sessao;
using FilmesAPI.Models;
using FilmesAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {

        SessaoService _sessaoService;
        public SessaoController(SessaoService sessaoService) {
            _sessaoService = sessaoService;
        }

        [HttpPost]
        public IActionResult AdiconaSessao(CreateSessaoDto dto)
        {
            ReadSessaoDto readDto = _sessaoService.AdicionaSessao(dto);
            
            return CreatedAtAction(nameof(RecuperaSessaoPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessaoPorId(int id)
        {
            ReadSessaoDto readDto = _sessaoService.RecuperaSessaoPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }
    }
}
