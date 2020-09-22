using Microsoft.EntityFrameworkCore;
using ReadCSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadCSV.Data
{
    public class CadastroContext:DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext>options)
            : base(options)
        {

        }
        public DbSet<Cadastro> Cadastros { get; set; }
    }
}
