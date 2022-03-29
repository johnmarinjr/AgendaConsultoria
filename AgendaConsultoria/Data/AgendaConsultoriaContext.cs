using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AgendaConsultoria.Models;

namespace AgendaConsultoria.Data
{
    public class AgendaConsultoriaContext : DbContext
    {
        public AgendaConsultoriaContext (DbContextOptions<AgendaConsultoriaContext> options)
            : base(options)
        {
        }

        public DbSet<AgendaConsultoria.Models.Cliente> Cliente { get; set; }
    }
}
