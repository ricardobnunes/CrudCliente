using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options)
            : base(options)
        {
        }

        public DbSet<ClienteItem>ClienteItems { get; set; }
    }
}