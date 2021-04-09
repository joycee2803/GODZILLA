using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GODZILLA.Models
{
    public partial class GODZILLADbContext : DbContext
    {
        public GODZILLADbContext()
            : base("name=GODZILLADbContext")
        {
        }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
               .Property(e => e.SoDienThoai)
               .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
               .Property(e => e.MaKhachHang)
               .IsUnicode(false);
        }
    }
}
