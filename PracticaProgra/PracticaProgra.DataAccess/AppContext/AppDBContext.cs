﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgra.Entities.AppContext
{
    class AppDBContext:DbContext
    {
        public AppDBContext() : base("conn")
        {

        }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
    }
}
