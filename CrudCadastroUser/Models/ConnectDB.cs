using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CrudCadastroUser.Models
{
    public class connectDB : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
    }
} 