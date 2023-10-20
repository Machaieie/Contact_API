using Contacto.Data;
using Contacto.Model;
using Contacto.Repositorys.Interface;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace Contacto.Repositorys
{
    public class UsuarioRepository : IUsuario
    {
        private readonly DataContext _dataContext;
        public UsuarioRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<UsuarioModelo> Adicionar(UsuarioModelo usuario)
        {
            await _dataContext.AddAsync(usuario);
            await _dataContext.SaveChangesAsync();
            return usuario;
        }

        public async Task<UsuarioModelo> Atualizar(UsuarioModelo usuario, int id)
        {
            UsuarioModelo user = await PegarComId(id);
            if (user == null)
            {
                throw new Exception($"Usuario com o id: {id} não encontrado");

            }
            user.Usuario = usuario.Usuario;
            user.Senha = usuario.Senha;
            _dataContext.usuario.Update(user);
            await _dataContext.SaveChangesAsync();
            return user;
        }

        public async Task<List<UsuarioModelo>> Listar()
        {
            return await _dataContext.usuario.ToListAsync();
        }

        public async Task<UsuarioModelo> PegarComId(int id)
        {
            return await _dataContext.usuario.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> Remover(int id)
        {
            UsuarioModelo user = await PegarComId(id);
            if (user == null)
            {
                throw new Exception($"Usuario com o id: {id} não encontrado");

            }
            _dataContext.usuario.Remove(user);
            await _dataContext.SaveChangesAsync();
            return true;
        }
    }
}
