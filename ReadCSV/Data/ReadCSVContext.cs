using Microsoft.EntityFrameworkCore;
using ReadCSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadCSV.Data
{
    public class ReadCSVContext: DbContext
    {

        public ReadCSVContext(DbContextOptions<ReadCSVContext> options)
            : base(options)
        {

        }
        public DbSet<Covid> Covid { get; set; }
    }
}
