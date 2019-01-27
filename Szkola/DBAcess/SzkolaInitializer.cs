using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Szkola.Models;

namespace Szkola.DBAcess
{
    public class SzkolaInitializer :DropCreateDatabaseIfModelChanges<SzkolaContext>
    {
        protected override void Seed(SzkolaContext context)
        {
            var studenci = new List<Student>
            {
                new Student{ImieStudent="Jan",Nazwiskostudent="Jankowski"  },
                new Student{ImieStudent="Paweł", Nazwiskostudent="Pawłowski"}
            };
            studenci.ForEach(s => context.Studenci.Add(s));
            context.SaveChanges();

            var kursy = new List<Kurs>
            {
                new Kurs{IdKurs=1, Nazwa="Matematyka",LStudentów=11},
                new Kurs{IdKurs=2,Nazwa="Polski",LStudentów=22}
            };
            kursy.ForEach(s => context.Kursy.Add(s));
            context.SaveChanges();
            var nauczyciele = new List<Nauczyciel>
            {
                new Nauczyciel{IdKurs=1, IdStudent =1, Ocena=Ocena.cztery},
                new Nauczyciel{IdKurs=2,IdStudent=2, Ocena=Ocena.trzy}
            };
            nauczyciele.ForEach(s => context.Nauczyciele.Add(s));
            context.SaveChanges();
        }
    }
}