using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: DB tabloları ile proje classlarını bağlar
    public class DeveloperStudentContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=developer_student;Trusted_Connection=true");
        }
        public DbSet<Bolum> Bolumler { get; set; }//hangi class ın hangi tabloya karşılık geldiğini söyler.
        public DbSet<Kullanici> Kullanıcılar { get; set; }
        public DbSet<Unvan> Unvan { get; set; }

        public DbSet<Alan> Alanlar { get; set; }

        public DbSet<Ders> Dersler { get; set; }

        public DbSet<Diploma> Diplomalar { get; set; }

        public DbSet<Lise> Liseler { get; set; }

        public DbSet<Net> Netler { get; set; }

        public DbSet<Program> Program { get; set; }

        public DbSet<Soru> Soru { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<SoruHavuz> SoruHavuz { get; set; }
        public DbSet<Universite> Universiteler { get; set; }
        public DbSet<VeliTakip> VeliKontrol { get; set; }
        public DbSet<Veli> Veliler { get; set; }
        public DbSet<Gun> Gunler { get; set; }
        public DbSet<SoruTip> SoruTipleri { get; set; }
        public DbSet<SoruYanit> SoruYanit { get; set; }

        public DbSet<Deneme> Denemeler { get; set; }
        public DbSet<Sınıf> Sınıf { get; set; }

        public DbSet<DersKategori> DersKategori{ get; set; }








    }
}
