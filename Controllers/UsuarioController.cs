using Contacto.Model;
using Contacto.Repositorys.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contacto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuario _usuario;
        public UsuarioController(IUsuario usuario) 
        {
            _usuario = usuario;
        }


        [HttpGet]
        public async Task<ActionResult<List<UsuarioModelo>>> buscarTodos()
        {
            return Ok(await _usuario.Listar());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<UsuarioModelo>>> buscarComId(int id)
        {
            UsuarioModelo usuario = await _usuario.PegarComId(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<List<UsuarioModelo>>> Adicionar([FromBody] UsuarioModelo usuario)
        {
            if (usuario == null)
            {
                return BadRequest();
            }
            UsuarioModelo user = await _usuario.Adicionar(usuario);
            return Ok(user);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioModelo>> Atualizar([FromBody] UsuarioModelo usuario, int id)
        {
            UsuarioModelo usuarioModelo = await _usuario.Atualizar(usuario, id);
            return Ok(usuarioModelo);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Apagar(int id)
        {
            bool apagou = await _usuario.Remover(id);
            if (!apagou)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}
