using CONTATOS.Models;
using Microsoft.EntityFrameworkCore;

namespace CONTATOS.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> Options) : base(Options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
