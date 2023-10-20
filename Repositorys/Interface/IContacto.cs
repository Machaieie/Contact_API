using Contacto.Model;

namespace Contacto.Repositorys.Interface
{
    public interface IContacto
    {
        Task<List<ContactoModelo>> Listar();
        Task<ContactoModelo> PegarComId(int id);
        Task<ContactoModelo> Adicionar(ContactoModelo contactoModelo);
        Task<ContactoModelo> Remover( int id);
        Task<ContactoModelo> Atualizar(ContactoModelo contactoModelo, int id);
    }
}
