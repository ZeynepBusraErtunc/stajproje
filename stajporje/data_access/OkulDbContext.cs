using Microsoft.EntityFrameworkCore;
using stajproje.Properties.model;


namespace stajproje.model

{
    public class OkulDbContext : DbContext
    {
        public OkulDbContext(DbContextOptions<OkulDbContext> options) : base(options) 
        { }

        public DbSet<Ogrenci> Ogrenci { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>(entity =>
            {
                entity.Property(o => o.ogrenciAdi)
                .HasMaxLength(50)
                .HasColumnName("ogrenciAdi");

                entity.Property(o => o.ogrenciSoyadi)
                .HasMaxLength(50)
                .HasColumnName("ogrenciSoyadi");
            });
        }
    }
}
