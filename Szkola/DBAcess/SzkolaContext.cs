using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Szkola.Models;

namespace Szkola.DBAcess
{
    public class SzkolaContext :DbContext
    {
       public SzkolaContext(): base("SzkolaContext")
       {
       
        }
        public DbSet<Student> Studenci { get; set; }
        public DbSet<Kurs> Kursy { get; set; }
        public DbSet<Nauczyciel> Nauczyciele { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}