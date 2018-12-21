using PelaezAutoPartsDiego.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PelaezAutoPartsDiego.DbContex
{
    public class DataBaseContex:DbContext
    {
        public DataBaseContex()
            :base ("DefaulConnection")
        {

        }
        public DbSet <Usager> Usager{ get; set; }
    }
}