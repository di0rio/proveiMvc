using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using proveiMvc.Models;

namespace proveiMvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<proveiMvc.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<proveiMvc.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<proveiMvc.Models.Produto> Produto { get; set; } = default!;
        public DbSet<proveiMvc.Models.Venda> Venda { get; set; } = default!;
        public DbSet<proveiMvc.Models.VendaProduto> VendaProduto { get; set; } = default!;
    }
}
