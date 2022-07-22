using Entities.Concrete;
using Entities.Concrete.JoiningTables;
using System.Data.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "SERVER=DESKTOP-FHRS3PR; DATABASE=NotKayitSistemi; UID=sa; PWD=12345";
        }

        public DbSet<Basari> Basarilar { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Mudur> Mudurler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Sinav> Sinavlar { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<SiniflarDersler> SiniflarDersler { get; set; }
        public DbSet<SiniflarOgretmenler> SiniflarOgretmenler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            modelBuilder.Entity<SiniflarDersler>().HasKey(x => new { x.SinifID, x.DersID });
            modelBuilder.Entity<SiniflarOgretmenler>().HasKey(x => new { x.SinifID, x.OgretmenID });

            modelBuilder.Entity<SiniflarOgretmenler>().HasRequired(x => x.Ogretmen).WithMany(x => x.SiniflarOgretmenler).HasForeignKey(x => x.OgretmenID);
            modelBuilder.Entity<SiniflarOgretmenler>().HasRequired(x => x.Sinif).WithMany(x => x.SiniflarOgretmenler).HasForeignKey(x => x.SinifID);

            modelBuilder.Entity<SiniflarDersler>().HasRequired(x => x.Sinif).WithMany(x => x.SiniflarDersler).HasForeignKey(x => x.SinifID);
            modelBuilder.Entity<SiniflarDersler>().HasRequired(x => x.Ders).WithMany(x => x.SiniflarDersler).HasForeignKey(x => x.DersID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
