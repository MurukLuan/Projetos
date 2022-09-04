using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Gerente;
using FilmesAPI.Models;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        GerenteService _gerenteService;

        public GerenteController(GerenteService gerenteService)
        {
            _gerenteService = gerenteService;
        }
        [HttpPost]
        public IActionResult AdicionaGerente(CreateGerenteDto gerenteDto)
        {
            ReadGerenteDto readDto = _gerenteService.AdicionaGerente(gerenteDto);
            return CreatedAtAction(nameof(RecuperaGerentePorId), new { Id = readDto.Id }, readDto);
        }
        [HttpGet("{id}")]
        public IActionResult RecuperaGerentePorId(int id)
        {
            ReadGerenteDto readDto = _gerenteService.RecuperaGerentePorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        public IActionResult DeletaGerente(int id)
        {
            Result result = _gerenteService.DeletaGerente(id);
            if (result.IsFailed) return NotFound();
            return NoContent();
        }
    }
}
