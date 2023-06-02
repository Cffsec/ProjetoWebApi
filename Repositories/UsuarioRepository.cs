using ProjetoWebApi.Contexts;
using ProjetoWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoWebApi.Repositories
{
    public class UsuarioRepository
    {
        private readonly ProjetoContext _context;

        public UsuarioRepository(ProjetoContext context)
        {
            _context = context;
        }

        public Usuario Login(string email, string password)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == password);
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public void Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Atualizar(int id, Usuario usuario)
        {
            Usuario usuarioBuscado = _context.Usuarios.Find(id);

            if (usuarioBuscado != null)
            {
                usuarioBuscado.Senha = usuario.Senha;
                usuarioBuscado.Senha = usuario.Senha;
            }

            _context.Usuarios.Update(usuarioBuscado);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuarioBuscado = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuarioBuscado);
            _context.SaveChanges();

        }
    }
}