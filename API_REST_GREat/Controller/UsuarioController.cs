using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST_GREat.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_REST_GREat.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        List<Usuario> Usuarios = new List<Usuario>()
        {
            new Usuario()
            {
                Id = 1,
                Nome = "Amadeu",
                CPF = "042.567.543.11",
                RG = "299824336",
                Filiacao_Mae = "Creuza",
                Filiacao_Pai = "Otoim"
            },

            new Usuario()
            {
                Id = 2,
                Nome = "Barbosa",
                CPF = "042.424.543.11",
                RG = "2998242446",
                Filiacao_Mae = "Aretuza",
                Filiacao_Pai = "Zezim"
            }
        };
        // GET: api/<UsuarioController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Usuarios);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var user = Usuarios.FirstOrDefault(u => u.Id == id);
            if (user == null) return BadRequest("Aluno nao encontrado");
            
            return Ok(user);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{nome}")]
        public IActionResult GetByNome(string nome)
        {
            var user = Usuarios.FirstOrDefault(u => u.Nome.Contains(nome));
            if (user == null) return BadRequest("Aluno nao encontrado");

            return Ok(user);
        }
        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
