using Contacto.Model;
using Contacto.Repositorys.Interface;

namespace Contacto.Repositorys
{
    public class ContactoRepository : IContacto
    {
        public Task<ContactoModelo> Adicionar(ContactoModelo contactoModelo)
        {
            throw new NotImplementedException();
        }

        public Task<ContactoModelo> Atualizar(ContactoModelo contactoModelo, int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactoModelo>> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<ContactoModelo> PegarComId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ContactoModelo> Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
