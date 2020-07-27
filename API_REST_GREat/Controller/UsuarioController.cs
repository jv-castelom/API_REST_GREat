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
            try
            {
                return Ok(_repo.GetallUsers());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // GET api/<UsuarioController>/doc
        [EnableCors("Policy")]
        [HttpGet("filtro/{doc}")]
        public IActionResult GetByDoc(string doc)
        {
            try
            {
               return Ok(_repo.GetUserByDoc(doc));
                
            }
            catch (Exception)
            {

                return BadRequest("Usuario ao encontrado");
            }
        }

        // GET api/<UsuarioController>/5
        [EnableCors("Policy")]
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var user = _repo.GetUserById(id);

                if (user != null)
                    return Ok(user);
                return BadRequest("Usuario ao encontrado");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // GET api/<UsuarioController>/5
        //[EnableCors("Policy")]
        //[HttpGet("{nome}")]
        //public IActionResult GetByNome(string nome)
        //{

        //    return Ok();
        //}

        // POST api/<UsuarioController>
        [EnableCors("Policy")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UsuarioDTO user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                _repo.Add(user);
                if (await _repo.SaveChangesAsync())
                {
                    var resp_user = _repo.GetUserByDoc(user.CPF);
                    return Ok(resp_user);
                }
                    
                return BadRequest("Nao cadastrou");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<UsuarioController>/5
        [EnableCors("Policy")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UsuarioDTO user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                user.Id = id;
                var usuario = _repo.GetUserById(id);
                usuario = user;
                _repo.Update(usuario);

                if (await _repo.SaveChangesAsync())
                    return Ok(user);
                return BadRequest("Usuario nao encontrado");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            
        }

        // DELETE api/<UsuarioController>/5
        [EnableCors("Policy")]
        [HttpDelete("{doc}")]
        public async Task<IActionResult> Delete(int doc)
        {
            try
            {
                var user = _repo.GetUserById(doc);
                _repo.Remove(user);
                if (await _repo.SaveChangesAsync())
                    return Ok("Deletado com Sucesso");
                return BadRequest("Usuario nao encontrado");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            
        }
    }
}
