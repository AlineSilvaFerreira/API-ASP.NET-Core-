using Microsoft.EntityFrameworkCore;
using DonnaAgencia.Models;

namespace DonnaAgencia.Models
{
    public class DonnaDBContext : DbContext
    {
        public DonnaDBContext(DbContextOptions<DonnaDBContext> options)
            : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
