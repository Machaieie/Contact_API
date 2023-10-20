using Contacto.Model;

namespace Contacto.Repositorys.Interface
{
    public interface IUsuario
    {

        Task<List<UsuarioModelo>> Listar();
        Task<UsuarioModelo> PegarComId(int id);
        Task<UsuarioModelo> Adicionar(UsuarioModelo usuario);
        Task<bool> Remover(int id);
        Task<UsuarioModelo> Atualizar(UsuarioModelo usuario, int id);
    }
}
