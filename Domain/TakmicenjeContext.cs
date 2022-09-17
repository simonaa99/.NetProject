using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Domain
{
    public class TakmicenjeContext:IdentityDbContext<Administrator,IdentityRole<int>,int>
    {
        public TakmicenjeContext([NotNull] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Ucesnik> Ucesnics { get; set; }
        public DbSet<Takmicenje> Takmicenjes { get; set; }
        public DbSet<Ucesce> Ucesces { get; set; }
        public DbSet<Fakultet> Fakultets { get; set; }
        public DbSet<Mesto> Mestos { get; set; }
        public DbSet<Tim> Tims { get; set; }
        public DbSet<Administrator> Administrators{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder
            // .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=CaseStudyTakmicenje_Database; Trusted_Connection = True;");
            //.LogTo(Debug.WriteLine)
            //.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ucesce>().ToTable("Ucesce");
            modelBuilder.Entity<Ucesce>(s => s.HasKey(s => new { s.TimId, s.TakmicenjeId }));
            modelBuilder.Entity<Ucesce>().HasOne(s => s.Tim).WithMany(t => t.Ucesca).HasForeignKey(s => s.TimId);
            modelBuilder.Entity<Ucesce>().HasOne(s => s.Takmicenje).WithMany(tk => tk.Ucesca).HasForeignKey(s => s.TakmicenjeId);

            modelBuilder.Entity<Ucesnik>().ToTable("Ucesnik");
            modelBuilder.Entity<Ucesnik>().HasKey(u => u.UcesnikId);
            modelBuilder.Entity<Ucesnik>().HasOne(u => u.Tim).WithMany().HasForeignKey(u => u.TimId);
            modelBuilder.Entity<Ucesnik>().HasOne(u => u.Mesto).WithMany().HasForeignKey(u => u.MestoId);

            modelBuilder.Entity<Tim>().ToTable("Tim");
            modelBuilder.Entity<Tim>().HasKey(t => t.TimId);
            modelBuilder.Entity<Tim>().HasOne(t => t.Fakultet).WithMany().HasForeignKey(t => t.FakultetId);

            modelBuilder.Entity<Takmicenje>().ToTable("Takmicenje");
            modelBuilder.Entity<Takmicenje>().Property(tk => tk.TakmicenjeId).ValueGeneratedNever();
           // modelBuilder.Entity<Takmicenje>().HasKey(tk => tk.TakmicenjeId);
            
            modelBuilder.Entity<Takmicenje>().HasMany(tk => tk.Ucesca);

            modelBuilder.Entity<Mesto>().ToTable("Mesto");
            modelBuilder.Entity<Mesto>().HasKey(m => m.MestoId);

            modelBuilder.Entity<Fakultet>().ToTable("Fakultet");
            modelBuilder.Entity<Fakultet>().HasKey(f => f.FakultetId);

            modelBuilder.Entity<Administrator>().ToTable("Administrator");

            base.OnModelCreating(modelBuilder);


        }
    }

 
}
