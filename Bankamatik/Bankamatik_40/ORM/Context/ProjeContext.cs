using Bankamatik_40.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik_40.ORM.Context
{
    internal class ProjeContext:DbContext
    {
        public ProjeContext():base("Server=202-8\\SQLDERS; Database=Bank; Integrated Security=True")
        {

        }

        public DbSet<İndivual> İndivuals { get; set; }

        public DbSet<Company> Companies { get; set; }
    }
}
