using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssociadosAsserti.Dominio.Entidades;
using AssociadosAsserti.Dominio.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace AssociadosAsserti.Api.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }


        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> Get()
        {
            return await _repository.GetUsuarios();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Usuario usuario)
        {
            try
            {
                _repository.Save(usuario);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
            }

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
