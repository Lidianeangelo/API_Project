using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions<ExoContext> options) :
        base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão depende da SUA máquina.
                optionsBuilder.UseSqlServer("Server=MAMUTELIDI\\SQLEXPRESS;"
                + "Database=ExoApi;Trusted_Connection=True;");
                // Exemplo 1 de string de conexão:
                // User ID=lidia;Password=1234;Server=MAMUTELIDI\\SQLEXPRESS;Database=ExoApi;-
                // + Trusted_Connection=False;
                // Exemplo 2 de string de conexão:
                // 
                //Server=MAMUTELIDI\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}


