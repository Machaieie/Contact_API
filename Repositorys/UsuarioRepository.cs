using Contacto.Model;
using Contacto.Repositorys.Interface;

namespace Contacto.Repositorys
{
    public class UsuarioRepository : IUsuario
    {
        public Task<UsuarioModelo> Adicionar(UsuarioModelo usuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModelo> Atualizar(UsuarioModelo usuario, int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioModelo>> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModelo> PegarComId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModelo> Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
