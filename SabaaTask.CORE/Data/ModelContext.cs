using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SabaaTask.CORE.Data
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

      
        public virtual DbSet<Userlogin> Userlogins { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("USER ID=JOR15_User86;PASSWORD=Test321;DATA SOURCE=94.56.229.181:3488/traindb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("JOR15_USER86")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

           

            modelBuilder.Entity<Userlogin>(entity =>
            {
                entity.ToTable("USERLOGIN");

                entity.HasIndex(e => e.Email, "SYS_C00375608")
                    .IsUnique();

                entity.HasIndex(e => e.Password, "SYS_C00375609")
                    .IsUnique();

                entity.HasIndex(e => e.Confirmpassword, "SYS_C00375610")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID");

                entity.Property(e => e.Confirmpassword)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMPASSWORD");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");
            });

           

            modelBuilder.HasSequence("DEPARTMENT_ID");

            modelBuilder.HasSequence("SEQ_1");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
