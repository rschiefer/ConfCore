using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfCore.Web.Models
{
    public class ConfCoreDbContext : DbContext
    {
        public DbSet<Presenter> Presenters { get; set; }
    }
}
