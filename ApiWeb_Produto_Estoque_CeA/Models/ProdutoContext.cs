using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiWeb_Produto_Estoque_CeA.Models
{
    public class ProdutoContext :DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> ProdutoItems { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
