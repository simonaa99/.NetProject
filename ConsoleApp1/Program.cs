using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using TakmicenjeContext context = new TakmicenjeContext();
            //var u =context.Ucesnics.Include(u=>u.Mesto).Include(u=>u.Tim).FirstOrDefault();
            //Console.WriteLine(u.ToString());
            //context.Takmicenja.Where(s => s.Tema == "Inovacija bankarstva").ToList().ForEach(s => Console.WriteLine(s));
            //Fakultet f1 = new Fakultet { NazivFakulteta = "FON" };
            //Fakultet f2 = new Fakultet();
            //f2.NazivFakulteta = "Matematicki";
            //Fakultet f3 = new Fakultet();
            //f3.NazivFakulteta = "FPN";
            //Fakultet f4 = new();
            //f4.NazivFakulteta = "Filoloski";
            //context.Fakulteti.Add(f1);
            //context.Fakulteti.Add(f2);
            //context.Add(f3);
            //context.Add(f4);

            //Mesto m1 = new Mesto { NazivMesta = "Beograd" };
            //Mesto m2 = new Mesto { NazivMesta = "Novi Sad" };
            //Mesto m3 = new Mesto { NazivMesta = "Nis" };
            //Mesto m4 = new Mesto { NazivMesta = "Subotica" };
            //context.Add(m1);
            //context.Add(m2);
            //context.Add(m3);
            //context.Add(m4);

            //Tim t1 = new Tim { NazivTima = "Lideri", FakultetId = 1 };
            //Tim t2 = new Tim { NazivTima = "Hakeri", FakultetId = 2 };
            //Tim t3 = new Tim { NazivTima = "Lumijeri", FakultetId = 3 };
            //Tim t4 = new Tim { NazivTima = "Kuleri", FakultetId = 4 };
            //Tim t5 = new Tim { NazivTima = "Celicni", FakultetId = 2 };
            //Tim t6 = new Tim { NazivTima = "Junaci", FakultetId = 3 };
            //context.Add(t1);
            //context.Add(t2);
            //context.Add(t3);
            //context.Add(t4);
            //context.Add(t5);
            //context.Add(t6);

            Ucesnik u1 = new Ucesnik { Ime = "Milan", Prezime = "Lakic", JMBG = "1407002154011",Kontakt = "0605412541", MestoId = 4, GodinaStudija = 2, TimId = 1 };
            Ucesnik u2 = new Ucesnik { Ime = "Ana", Prezime = "Miric", JMBG = "0205001321456", Kontakt = "0621456321", MestoId = 2, GodinaStudija = 3, TimId = 2 };
            Ucesnik u3 = new Ucesnik { Ime = "Jovan", Prezime = "Petrovic", JMBG = "0607000214785", Kontakt = "061478963", MestoId = 3, GodinaStudija = 1, TimId = 2 };
            Ucesnik u4 = new Ucesnik { Ime = "Lidija", Prezime = "Dudic", JMBG = "1903002456987", Kontakt = "0614567892", MestoId = 1, GodinaStudija = 2, TimId = 4 };
            Ucesnik u5 = new Ucesnik { Ime = "Luka", Prezime = "Popovic", JMBG = "0112999874563", Kontakt = "0612364100", MestoId = 2, GodinaStudija = 4, TimId = 2 };
            Ucesnik u6 = new Ucesnik { Ime = "Bojana", Prezime = "Sakic", JMBG = "0101003654785", Kontakt = "0645123647", MestoId = 1, GodinaStudija = 1, TimId = 4 };



            context.Add(u1);
            context.Add(u2);
            context.Add(u3);
            context.Add(u4);
            context.Add(u5);
            context.Add(u6);
            context.SaveChanges();
            //Administrator a = new Administrator {Ime = "Petar", Prezime = "Petrovic", Username ="pera123", Password = "pera" };
            //context.Add(a);
            List<Takmicenje> t = context.Takmicenjes.Include(c => c.Statistike).ThenInclude(s=>s.Tim).ToList();
            foreach (Takmicenje course in t)
            {
                Console.WriteLine($"Takmicenje: " + course.Tema);
                Console.WriteLine("Enrolled students:");
                context.Statistikas.Include(s => s.Tim);
                course.Statistike.ForEach(s => Console.WriteLine(s));
                //foreach(Student s in course.EnrolledStudents)
                //{
                //    Console.WriteLine(s);
                //}
               }

            //var tim = context.Ucesnics.Where(t => t.OsobaId == 1).FirstOrDefault();
            //context.Remove(tim);
            //context.SaveChanges();

            //var persons = context.Osobas.Include(o=>o.).ToList();

            //foreach (var item in persons)
            //{
            //    if (item is Administrator a)
            //   {
            //       Console.WriteLine("Admin " + a.Username);
            //   }
            //   if (item is Ucesnik s)
            //   {
            //        Console.WriteLine("Ucesnik " + s.ToString());
            //    }
            //}
            //    //context.SaveChanges();
            //}
        }
    }
}
