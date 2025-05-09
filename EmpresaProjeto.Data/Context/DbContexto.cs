﻿using EmpresaProjeto.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaProjeto.Data.Context
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions options)
            :base(options) 
        {
            
        }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Mensagem> Mensagens { get; set; }
    }
}
