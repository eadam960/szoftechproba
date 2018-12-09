using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProbaZhSzoftech.Models {
    public class TargyContext : DbContext {
        public TargyContext() : base("Ajandek") {
        }

        public DbSet<Targy> Targyak { get; set; }


    }
}