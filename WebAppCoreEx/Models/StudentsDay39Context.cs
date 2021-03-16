using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAppCoreEx.Models
{
    public partial class StudentsDay39Context : DbContext
    {
        public StudentsDay39Context()
        {
        }

        public StudentsDay39Context(DbContextOptions<StudentsDay39Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=GIRJESH-HP-BS18;database=StudentsDay39;trusted_connection=true;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Students__CA1E5D7847FF93DA");

                entity.Property(e => e.Sid).ValueGeneratedNever();

                entity.Property(e => e.Course).HasMaxLength(50);

                entity.Property(e => e.Scontact).HasMaxLength(10);

                entity.Property(e => e.Semail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
