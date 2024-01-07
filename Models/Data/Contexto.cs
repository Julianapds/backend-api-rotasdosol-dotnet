using Microsoft.EntityFrameworkCore;

namespace ApiViagem.Models.Data;
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }
  public DbSet<Cliente> Clientes { get; set; }
    }


