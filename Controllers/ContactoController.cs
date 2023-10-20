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
    }
}
