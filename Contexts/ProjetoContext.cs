using ProjetoWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace ProjetoWebApi.Contexts
{
    public class ProjetoContext : DbContext
    {
        public ProjetoContext()
        {
        }
        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        {  
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=???????;Password=?????????????;Server=???????\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=False;");
            }
        }

        public DbSet<Projeto> Projetos {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}
    }
}
