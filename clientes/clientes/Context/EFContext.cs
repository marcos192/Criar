using clientes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace clientes.Context
    {
    
    public class EFContext : DbContext
        {

        public EFContext() : base("Projeto") { }

        public DbSet<Cliente> clientes { get; set; }

        }
    }