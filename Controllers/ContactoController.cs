using Contacto.Model;
using Contacto.Repositorys;
using Contacto.Repositorys.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contacto.Controllers
{
    [Route("api/contacto")]
    [ApiController]
    public class ContactoController : ControllerBase
    {
        private readonly IContacto _contacto;
        public ContactoController(IContacto contacto ) 
        { 
            _contacto = contacto;
        }

        [HttpGet]
        public async Task<ActionResult<List<ContactoModelo>>> buscarTodos()
        {
            return Ok(await _contacto.Listar());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<ContactoModelo>>> buscarComId(int id)
        {
            ContactoModelo contacto = await _contacto.PegarComId(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return Ok(contacto);
        }

        [HttpPost]
        public async Task<ActionResult<List<ContactoModelo>>> Adicionar([FromBody] ContactoModelo contacto)
        {
            if (contacto == null)
            {
                return BadRequest();
            }
            ContactoModelo model = await _contacto.Adicionar(contacto);
            return Ok(model);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ContactoModelo>> Atualizar([FromBody] ContactoModelo contacto, int id)
        {
            ContactoModelo contactoModel = await _contacto.Atualizar(contacto, id);
            return Ok(contactoModel);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Apagar(int id)
        {
            bool apagou = await _contacto.Remover(id);
            if (!apagou)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
