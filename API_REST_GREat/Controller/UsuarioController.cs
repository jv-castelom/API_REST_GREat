using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST_GREat.Data;
using API_REST_GREat.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_REST_GREat.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IEFCoreRepository _repo;

        public UsuarioController(IEFCoreRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<UsuarioController>
        [EnableCors("Policy")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetallUsers());
        }

        // GET api/<UsuarioController>/5
        [EnableCors("Policy")]
        [HttpGet("byDoc")]
        public IActionResult GetById(string doc)
        {
            var user = _repo.GetUserByDoc(doc);

            if(user != null)
                return Ok(user);
            return BadRequest("Usuario ao encontrado");
        }

        // GET api/<UsuarioController>/5
        [EnableCors("Policy")]
        [HttpGet("{nome}")]
        public IActionResult GetByNome(string nome)
        {
            
            return Ok();
        }
        // POST api/<UsuarioController>
        [EnableCors("Policy")]
        [HttpPost]
        public IActionResult Post([FromBody] Usuario user)
        {
            _repo.Add(user);

            if (_repo.SaveChanges())
                return Ok(user);
            return BadRequest("Nao cadastrou");
        }

        // PUT api/<UsuarioController>/5
        [EnableCors("Policy")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Usuario user)
        {
            user.Id = id;
            var usuario = _repo.GetUserById(id);
            usuario = user;
            _repo.Update(usuario);

            if (_repo.SaveChanges())
                return Ok(user);
            return BadRequest("Usuario nao encontrado");
        }

        // DELETE api/<UsuarioController>/5
        [EnableCors("Policy")]
        [HttpDelete("{doc}")]
        public IActionResult Delete(string doc)
        {
            var user = _repo.GetUserByDoc(doc);
            _repo.Remove(user);
            if(_repo.SaveChanges())
                return Ok("Deletado com Sucesso");
            return BadRequest("Usuario nao encontrado");
        }
    }
}
