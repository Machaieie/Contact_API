using Contacto.Data;
using Contacto.Model;
using Contacto.Repositorys.Interface;
using Microsoft.EntityFrameworkCore;

namespace Contacto.Repositorys
{
    public class ContactoRepository : IContacto
    {
        private readonly DataContext _dataContext;
        public ContactoRepository(DataContext dataContext) 
        { 
            _dataContext = dataContext;
        }
        public async Task<ContactoModelo> Adicionar(ContactoModelo contactoModelo)
        {
            await _dataContext.AddAsync(contactoModelo);
            await _dataContext.SaveChangesAsync();
            return contactoModelo;
        }

        public async Task<ContactoModelo> Atualizar(ContactoModelo contactoModelo, int id)
        {
            ContactoModelo contacto = await PegarComId(id);
            if(contacto == null) 
            {
                throw new Exception($"Contacto com o id: {id} não encontrado");

            }
            contacto.Nome = contactoModelo.Nome;
            contacto.Email = contactoModelo.Email;
            contacto.Contacto = contactoModelo.Contacto;
            _dataContext.contacto.Update(contacto);
            await _dataContext.SaveChangesAsync();
            return contactoModelo;
        }

        public async Task<List<ContactoModelo>> Listar()
        {
            return await _dataContext.contacto.ToListAsync();
        }

        public async Task<ContactoModelo> PegarComId(int id)
        {
            return await _dataContext.contacto.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ContactoModelo> Remover(int id)
        {
            ContactoModelo contacto = await PegarComId(id);
            if (contacto == null)
            {
                throw new Exception($"Contacto com o id: {id} não encontrado");

            }

            _dataContext.contacto.Remove(contacto);
            await _dataContext.SaveChangesAsync();
            return true;
        }
    }
}
