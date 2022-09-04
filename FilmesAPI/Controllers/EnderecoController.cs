using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Filme;
using FilmesAPI.Services;
using FluentResults;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        EnderecoServices _enderecoServices;

        public EnderecoController(EnderecoServices enderecoServices)
        {
            _enderecoServices = enderecoServices;
        }

        [HttpPost]
        public IActionResult AdicionaEndereco([FromBody] CreateEnderecoDto enderecoDto)
        {
            ReadEnderecoDto readDto = _enderecoServices.AdicionaEndereco(enderecoDto);
            return CreatedAtAction(nameof(RecuperaEnderecoPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public List<ReadEnderecoDto> RecuperaEndereco()
        {
            List<ReadEnderecoDto> readDto = _enderecoServices.RecuperaEndereco();
            return readDto;
        }
        [HttpGet("{id}")]
        public IActionResult RecuperaEnderecoPorId(int id)
        {
            ReadEnderecoDto readDto = _enderecoServices.RecuperaEnderecoPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
        {
            Result result = _enderecoServices.AtualizaEndereco(id, enderecoDto);
            if (result.IsFailed) return NotFound();

            return NoContent();
        }

        public IActionResult DeletaEndereco(int id)
        {
            Result result = _enderecoServices.DeletaEndereco(id);
            if (result.IsFailed) return NotFound();

            return NoContent();
        }
    }
}
