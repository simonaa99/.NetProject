using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace Domain
{
    public class TakmicenjeContext:DbContext
    {
        public DbSet<Ucesnik> Ucesnics { get; set; }
        public DbSet<Takmicenje> Takmicenjes { get; set; }
        public DbSet<Statistika> Statistikas { get; set; }
        public DbSet<Fakultet> Fakultets { get; set; }
        public DbSet<Mesto> Mestos { get; set; }
        public DbSet<Tim> Tims { get; set; }
        public DbSet<Osoba> Osobas { get; set; }
        public DbSet<Administrator> Administartors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
             .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Takmicenje_Database;");
            //.LogTo(Debug.WriteLine)
            //.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Statistika>().ToTable("Statistika");
            modelBuilder.Entity<Statistika>(s => s.HasKey(s => new { s.TimId, s.TakmicenjeId }));
            modelBuilder.Entity<Statistika>().HasOne(s => s.Tim).WithMany(t => t.Statistike).HasForeignKey(s => s.TimId);
            modelBuilder.Entity<Statistika>().HasOne(s => s.Takmicenje).WithMany(tk => tk.Statistike).HasForeignKey(s => s.TakmicenjeId);

            modelBuilder.Entity<Ucesnik>().ToTable("Ucesnik");
            modelBuilder.Entity<Ucesnik>().HasOne(u => u.Tim).WithMany().HasForeignKey(u => u.TimId);
            modelBuilder.Entity<Ucesnik>().HasOne(u => u.Mesto).WithMany().HasForeignKey(u => u.MestoId);

            modelBuilder.Entity<Tim>().ToTable("Tim");
            modelBuilder.Entity<Tim>().HasKey(t => t.TimId);
            modelBuilder.Entity<Tim>().HasOne(t => t.Fakultet).WithMany().HasForeignKey(t => t.FakultetId);

            modelBuilder.Entity<Takmicenje>().ToTable("Takmicenje");
            modelBuilder.Entity<Takmicenje>().HasKey(tk => tk.TakmicenjeId);
            modelBuilder.Entity<Takmicenje>().HasMany(tk => tk.Statistike);

            modelBuilder.Entity<Mesto>().ToTable("Mesto");
            modelBuilder.Entity<Mesto>().HasKey(m => m.MestoId);

            modelBuilder.Entity<Fakultet>().ToTable("Fakultet");
            modelBuilder.Entity<Fakultet>().HasKey(f => f.FakultetId);

            modelBuilder.Entity<Osoba>().ToTable("Osoba");
            modelBuilder.Entity<Ucesnik>().HasBaseType<Osoba>().ToTable("Ucesnik");
            modelBuilder.Entity<Administrator>().HasBaseType<Osoba>().ToTable("Administrator");
        }
    }

 
}
